#include "CBaseRepository.h"
#include "../Models/IWorkersRepository.h"

using namespace System::Collections::Generic;
using namespace System::Data;
using namespace System::Data::SqlClient;
using namespace UnionPressOnC;

namespace UnionPressOnC
{
    public class CWorkersRepository : CBaseRepository, IWorkersRepository
    {
    public:
        
        CWorkersRepository(string connectionString)
        {
            this->connectionString = connectionString;
        }

        void AddData(WorkersModel workersModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using(auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Сотрудники values (@Фамилия, @Имя, @Отчество, @Должность, @Номер_телефона)";
                command.Parameters.Add("@Фамилия", SqlDbType.NautoChar).Value = workersModel.Surname;
                command.Parameters.Add("@Имя", SqlDbType.NautoChar).Value = workersModel.Name;
                command.Parameters.Add("@Отчество", SqlDbType.NautoChar).Value = workersModel.FatherName;
                command.Parameters.Add("@Должность", SqlDbType.NautoChar).Value = workersModel.Special;
                command.Parameters.Add("@Номер_телефона", SqlDbType.NautoChar).Value = workersModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        void DeleteData(string number)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Сотрудники where Номер_телефона=@Номер_телефона";
                command.Parameters.Add("@Номер_телефона", SqlDbType.NautoChar).Value = number;
                command.ExecuteNonQuery();
            }
        }

        void EditData(WorkersModel workersModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Сотрудники 
                                        set Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество, Должность = @Должность
                                        where Номер_телефона = @Номер_телефона";
                command.Parameters.Add("@Фамилия", SqlDbType.NautoChar).Value = workersModel.Surname;
                command.Parameters.Add("@Имя", SqlDbType.NautoChar).Value = workersModel.Name;
                command.Parameters.Add("@Отчество", SqlDbType.NautoChar).Value = workersModel.FatherName;
                command.Parameters.Add("@Должность", SqlDbType.NautoChar).Value = workersModel.Special;
                command.Parameters.Add("@Номер_телефона", SqlDbType.NautoChar).Value = workersModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<WorkersModel> GetAllWorkers()
        {
            auto workerList = new List<WorkersModel>();
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона] from Сотрудники";
                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto workerModel = new WorkersModel();
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

        IEnumerable<WorkersModel> GetByValue(string value)
        {
            auto workerList = new List<WorkersModel>();
            // int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
             string workerName = value;
             string workerSpecial = value;
             string workerSurname = value;
             string workerPhone = value;
             string workerFatherName = value;

             using (auto connection = new SqlConnection(connectionString))
             using (auto command = new SqlCommand())
             {
                 connection.Open();
                 command.Connection = connection;
                 command.CommandText = "Select [Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона] from Сотрудники
                                         where Имя = @Имя or Должность = @Должность or Отчество = @Отчество or Фамилия = @Фамилия or Номер_телефона = @Номер_телефона
                                         ";
                //  command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@Имя", SqlDbType.NautoChar).Value = workerName;
                command.Parameters.Add("@Фамилия", SqlDbType.NautoChar).Value = workerSurname;
                command.Parameters.Add("@Отчество", SqlDbType.NautoChar).Value = workerFatherName;
                command.Parameters.Add("@Должность", SqlDbType.NautoChar).Value = workerSpecial;
                command.Parameters.Add("@Номер_телефона", SqlDbType.NautoChar).Value = workerPhone;

                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto workerModel = new WorkersModel();
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
