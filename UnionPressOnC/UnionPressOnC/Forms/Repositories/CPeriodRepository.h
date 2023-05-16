#include "CBaseRepository.h"
#include "../Models/IPeriodRepository.h"

using namespace System::Collections::Generic;
using namespace System::Data;
using namespace System::Data::SqlClient;
using namespace UnionPressOnC;

namespace UnionPressOnC
{
    public class CPeriodRepository : CBaseRepository, IPeriodRepository
    {
    public:
        
        CPeriodRepository(string connectionString)
        {
            this->connectionString = connectionString;
        }

        void AddData(PeriodModel periodModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Периодические_издания (Срок_подписки, Стоимость, Способ_доставки, Популярность) values (@Срок_подписки, @Стоимость, @Способ_доставки, @Популярность)";
                command.Parameters.Add("@Срок_подписки", SqlDbType.NVarChar).Value = periodModel.SrokSubscribe;
                command.Parameters.Add("@Стоимость", SqlDbType.NVarChar).Value = periodModel.Sell;
                command.Parameters.Add("@Способ_доставки", SqlDbType.NVarChar).Value = periodModel.TransferChoice;
                command.Parameters.Add("@Популярность", SqlDbType.NVarChar).Value = periodModel.Popularity;
                command.ExecuteNonQuery();
            }
        }

        void DeleteData(string transferChoice)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Периодические_издания where Способ_доставки=@Способ_доставки";
                command.Parameters.Add("@Способ_доставки", SqlDbType.NVarChar).Value = transferChoice;
                command.ExecuteNonQuery();
            }
        }

        void EditData(PeriodModel periodModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Периодические_издания 
                                        set Срок_подписки = @Срок_подписки, Стоимость = @Стоимость, Способ_доставки = @Способ_доставки, Популярность = @Популярность
                                        where Способ_доставки = @Способ_доставки";
                command.Parameters.Add("@Срок_подписки", SqlDbType.NVarChar).Value = periodModel.SrokSubscribe;
                command.Parameters.Add("@Стоимость", SqlDbType.NVarChar).Value = periodModel.Sell;
                command.Parameters.Add("@Способ_доставки", SqlDbType.NVarChar).Value = periodModel.TransferChoice;
                command.Parameters.Add("@Популярность", SqlDbType.NVarChar).Value = periodModel.Popularity;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<PeriodModel> GetAll()
        {
            auto periodList = new List<PeriodModel>();
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Срок_подписки], [Стоимость], [Способ_доставки], [Популярность] from Периодические_издания";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var periodModel = new PeriodModel();
                        periodModel.SrokSubscribe = reader[0].ToString();
                        periodModel.Sell = reader[1].ToString();
                        periodModel.TransferChoice = reader[2].ToString();
                        periodModel.Popularity = reader[3].ToString();
                        periodList.Add(periodModel);
                    }
                }
            }
            return periodList;
        }

        IEnumerable<PeriodModel> GetByValue(string value)
        {
            auto periodList = new List<PeriodModel>();

            string sell = value;
            string choiceTransf = value;
            string popularity = value;
            string srokPodpis = value;

            using (auto connection = gcnew SqlConnection(connectionString))
            using (auto command = gcnew SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Срок_подписки], [Стоимость], [Способ_доставки], [Популярность] from Периодические_издания
                                        where Стоимость = @Стоимость or Способ_доставки = @Способ_доставки
                                        ";

                command.Parameters.Add("@Стоимость", SqlDbType.NVarChar).Value = sell;
                command.Parameters.Add("@Способ_доставки", SqlDbType.NVarChar).Value = choiceTransf;
                command.Parameters.Add("@Популярность", SqlDbType.NVarChar).Value = popularity;
                command.Parameters.Add("@Срок_подписки", SqlDbType.NVarChar).Value = srokPodpis;

                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var periodModel = new PeriodModel();
                        periodModel.SrokSubscribe = reader[0].ToString();
                        periodModel.Sell = reader[1].ToString();
                        periodModel.TransferChoice = reader[2].ToString();
                        periodModel.Popularity = reader[3].ToString();
                        periodList.Add(periodModel);
                    }
                }
            }
            return periodList;
        }

    }
}
