using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionPressOnSharp.Forms.Models;

namespace UnionPressOnSharp.Forms.Repositories
{
    public class CWorkersRepository : CBaseRepository, IWorkersRepository
    {
        public CWorkersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddData(WorkersModel workersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Сотрудники values (@Фамилия, @Имя, @Отчество, @Должность, @Номер_телефона)";
                command.Parameters.Add("@Фамилия", SqlDbType.NVarChar).Value = workersModel.Surname;
                command.Parameters.Add("@Имя", SqlDbType.NVarChar).Value = workersModel.Name;
                command.Parameters.Add("@Отчество", SqlDbType.NVarChar).Value = workersModel.FatherName;
                command.Parameters.Add("@Должность", SqlDbType.NVarChar).Value = workersModel.Special;
                command.Parameters.Add("@Номер_телефона", SqlDbType.NVarChar).Value = workersModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteData(string number)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Сотрудники where Номер_телефона=@Номер_телефона";
                command.Parameters.Add("@Номер_телефона", SqlDbType.NVarChar).Value = number;
                command.ExecuteNonQuery();
            }
        }

        public void EditData(WorkersModel workersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Сотрудники 
                                        set Фамилия=@Фамилия, Имя=@Имя, Отчество=@Отчество, Должность=@Должность 
                                        where Номер_телефона=@Номер_телефона";
                command.Parameters.Add("@Фамилия", SqlDbType.NVarChar).Value = workersModel.Surname;
                command.Parameters.Add("@Имя", SqlDbType.NVarChar).Value = workersModel.Name;
                command.Parameters.Add("@Отчество", SqlDbType.NVarChar).Value = workersModel.FatherName;
                command.Parameters.Add("@Должность", SqlDbType.NVarChar).Value = workersModel.Special;
                command.Parameters.Add("@Номер_телефона", SqlDbType.NVarChar).Value = workersModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<WorkersModel> GetAllWorkers()
        {
            var workerList = new List<WorkersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона] from Сотрудники";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var workerModel = new WorkersModel();
                        // workerModel.Surname = (int)reader[0];
                        workerModel.Surname = reader[0].ToString();
                        workerModel.Name = reader[1].ToString();
                        workerModel.FatherName = reader[2].ToString();
                        workerModel.Special = reader[3].ToString();
                        workerModel.Phone = reader[4].ToString();
                        workerList.Add(workerModel);
                    }
                }
            }
            return workerList;
        }

        public IEnumerable<WorkersModel> GetByValue(string value)
        {
            var workerList = new List<WorkersModel>();
           // int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string workerName = value;
            string workerSpecial = value;
            string workerSurname = value;
            string workerPhone = value;
            string workerFatherName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select [Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона] from Сотрудники
                                        where Имя=@Имя or Должность=@Должность or Отчество=@Отчество or Фамилия=@Фамилия or Номер_телефона=@Номер_телефона
                                        ";
              //  command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@Имя", SqlDbType.NVarChar).Value = workerName;
                command.Parameters.Add("@Фамилия", SqlDbType.NVarChar).Value = workerSurname;
                command.Parameters.Add("@Отчество", SqlDbType.NVarChar).Value = workerFatherName;
                command.Parameters.Add("@Должность", SqlDbType.NVarChar).Value = workerSpecial;
                command.Parameters.Add("@Номер_телефона", SqlDbType.NVarChar).Value = workerPhone;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var workerModel = new WorkersModel();
                        workerModel.Surname = reader[0].ToString();
                        workerModel.Name = reader[1].ToString();
                        workerModel.FatherName = reader[2].ToString();
                        workerModel.Special = reader[3].ToString();
                        workerModel.Phone = reader[4].ToString();
                        workerList.Add(workerModel);
                    }
                }
            }
            return workerList;
        }
    }
    
}
