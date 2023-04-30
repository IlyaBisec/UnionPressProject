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
    public class CTransportRepository : CBaseRepository, ITransportRepository
    {
        public CTransportRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddData(TransportModel transportModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Доставка (Дата_начала, Дата_окончания) values (@Дата_начала, @Дата_окончания)";
                command.Parameters.Add("@Дата_начала", SqlDbType.NVarChar).Value = transportModel.Begindat;
                command.Parameters.Add("@Дата_окончания", SqlDbType.NVarChar).Value = transportModel.Enddat;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteData(string data)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Доставка where Дата_начала=@Дата_начала";
                command.Parameters.Add("@Дата_начала", SqlDbType.NVarChar).Value = data;
                command.ExecuteNonQuery();
            }
        }

        public void EditData(TransportModel transportModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Доставка 
                                        set Дата_начала=@Дата_начала, Дата_окончания=@Дата_окончания 
                                        where Дата_начала=@Дата_начала";
                command.Parameters.Add("@Дата_начала", SqlDbType.NVarChar).Value = transportModel.Begindat;
                command.Parameters.Add("@Дата_окончания", SqlDbType.NVarChar).Value = transportModel.Enddat;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TransportModel> GetAll()
        {
            var transportList = new List<TransportModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Дата_начала], [Дата_окончания] from Доставка";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var transportModel = new TransportModel();
                        transportModel.Begindat = reader[0].ToString();
                        transportModel.Enddat = reader[1].ToString();
                        transportList.Add(transportModel);
                    }
                }
            }
            return transportList;
        }

        public IEnumerable<TransportModel> GetByValue(string value)
        {
            var transportList = new List<TransportModel>();

            string dataBeg = value;
            string dataEnd = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select [Дата_начала], [Дата_окончания] from Доставка
                                        where Дата_начала=@Дата_начала or Дата_окончания=@Дата_окончания
                                        ";

                command.Parameters.Add("@Дата_начала", SqlDbType.NVarChar).Value = dataBeg;
                command.Parameters.Add("@Дата_окончания", SqlDbType.NVarChar).Value = dataEnd;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var transportModel = new TransportModel();
                        transportModel.Begindat = reader[0].ToString();
                        transportModel.Enddat = reader[1].ToString();
                        transportList.Add(transportModel);
                    }
                }
            }
            return transportList;
        }
    }
    
}
