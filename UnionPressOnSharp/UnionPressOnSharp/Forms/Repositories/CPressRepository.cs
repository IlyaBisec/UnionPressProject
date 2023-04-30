using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionPressOnSharp.Forms.Models;
using System.Data.SqlClient;
using System.Data;

namespace UnionPressOnSharp.Forms.Repositories
{
    public class CPressRepository : CBaseRepository, IPressRepository
    {

        public CPressRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddData(PressModel pressModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Издания (Наименование, Период_выхода) values (@Наименование, @Период_выхода)";
                command.Parameters.Add("@Наименование", SqlDbType.NVarChar).Value = pressModel.Caption;
                command.Parameters.Add("@Период_выхода", SqlDbType.NVarChar).Value = pressModel.PeriodOutput;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteData(string caption)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Издания where Наименование=@Наименование";
                command.Parameters.Add("@Наименование", SqlDbType.NVarChar).Value = caption;
                command.ExecuteNonQuery();
            }
        }

        public void EditData(PressModel pressModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Издания 
                                        set Наименование=@Наименование, Период_выхода=@Период_выхода
                                        where Наименование=@Наименование";
                command.Parameters.Add("@Наименование", SqlDbType.NVarChar).Value = pressModel.Caption;
                command.Parameters.Add("@Период_выхода", SqlDbType.NVarChar).Value = pressModel.PeriodOutput;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PressModel> GetAll()
        {
            var pressList = new List<PressModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Наименование], [Период_выхода] from Издания";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pressrModel = new PressModel();

                        pressrModel.Caption = reader[0].ToString();
                        pressrModel.PeriodOutput = reader[1].ToString();;
                        pressList.Add(pressrModel);
                    }
                }
            }
            return pressList;
        }

        public IEnumerable<PressModel> GetByValue(string value)
        {
            var pressList = new List<PressModel>();

            string pressCap = value;
            string pressOut = value;;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select [Наименование], [Период_выхода] from Издания
                                        where Наименование=@Наименование or Период_выхода=@Период_выхода
                                        ";
                command.Parameters.Add("@Наименование", SqlDbType.NVarChar).Value = pressCap;
                command.Parameters.Add("@Период_выхода", SqlDbType.NVarChar).Value = pressOut;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pressModel = new PressModel();
                        pressModel.Caption = reader[0].ToString();
                        pressModel.PeriodOutput = reader[1].ToString();
                        pressList.Add(pressModel);
                    }
                }
            }
            return pressList;
        }
    }
}
