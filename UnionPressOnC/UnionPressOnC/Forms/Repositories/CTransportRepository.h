#include "CBaseRepository.h"
#include "../Models/ITransportRepository.h"

using namespace System::Collections::Generic;
using namespace System::Data;
using namespace System::Data::SqlClient;
using namespace UnionPressOnC;

namespace UnionPressOnC
{
    public class CTransportRepository : CBaseRepository, ITransportRepository
    {
    public:
        
        CTransportRepository(string connectionString)
        {
            this->connectionString = connectionString;
        }

        void AddData(TransportModel transportModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Доставка (Дата_начала, Дата_окончания) values (@Дата_начала, @Дата_окончания)";
                command.Parameters.Add("@Дата_начала", SqlDbType.NautoChar).Value = transportModel.Begindat;
                command.Parameters.Add("@Дата_окончания", SqlDbType.NautoChar).Value = transportModel.Enddat;
                command.ExecuteNonQuery();
            }
        }

        void DeleteData(string data)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Доставка where Дата_начала=@Дата_начала";
                command.Parameters.Add("@Дата_начала", SqlDbType.NautoChar).Value = data;
                command.ExecuteNonQuery();
            }
        }

        void EditData(TransportModel transportModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update Доставка 
                                        set Дата_начала = @Дата_начала, Дата_окончания = @Дата_окончания
                                        where Дата_начала = @Дата_начала";
                command.Parameters.Add("@Дата_начала", SqlDbType.NautoChar).Value = transportModel.Begindat;
                command.Parameters.Add("@Дата_окончания", SqlDbType.NautoChar).Value = transportModel.Enddat;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<TransportModel> GetAll()
        {
            auto transportList = new List<TransportModel>();
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Дата_начала], [Дата_окончания] from Доставка";
                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto transportModel = new TransportModel();
                        transportModel.Begindat = reader[0].ToString();
                        transportModel.Enddat = reader[1].ToString();
                        transportList.Add(transportModel);
                    }
                }
            }
            return transportList;
        }

        IEnumerable<TransportModel> GetByValue(string value)
        {
            auto transportList = new List<TransportModel>();

            string dataBeg = value;
            string dataEnd = value;

            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Дата_начала], [Дата_окончания] from Доставка
                                        where Дата_начала = @Дата_начала or Дата_окончания = @Дата_окончания
                                        ";

                command.Parameters.Add("@Дата_начала", SqlDbType.NautoChar).Value = dataBeg;
                command.Parameters.Add("@Дата_окончания", SqlDbType.NautoChar).Value = dataEnd;

                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto transportModel = new TransportModel();
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
