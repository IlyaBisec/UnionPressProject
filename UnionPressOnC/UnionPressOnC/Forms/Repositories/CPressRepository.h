#include "CBaseRepository.h"
#include "../Models/IPressRepository.h"

using namespace System::Collections::Generic;
using namespace System::Data;
using namespace System::Data::SqlClient;
using namespace UnionPressOnC;

namespace UnionPressOnC
{
    public class CPressRepository : CBaseRepository, IPressRepository
    {

    public:
            
        CPressRepository(string connectionString)
        {
            this->connectionString = connectionString;
        }

        void AddData(PressModel pressModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Издания (Наименование, Период_выхода) values (@Наименование, @Период_выхода)";
                command.Parameters.Add("@Наименование", SqlDbType.NautoChar).Value = pressModel.Caption;
                command.Parameters.Add("@Период_выхода", SqlDbType.NautoChar).Value = pressModel.PeriodOutput;
                command.ExecuteNonQuery();
            }
        }

        void DeleteData(string caption)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Издания where Наименование=@Наименование";
                command.Parameters.Add("@Наименование", SqlDbType.NautoChar).Value = caption;
                command.ExecuteNonQuery();
            }
        }

        void EditData(PressModel pressModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update Издания 
                                        set Наименование = @Наименование, Период_выхода = @Период_выхода
                                        where Наименование = @Наименование";
                command.Parameters.Add("@Наименование", SqlDbType.NautoChar).Value = pressModel.Caption;
                command.Parameters.Add("@Период_выхода", SqlDbType.NautoChar).Value = pressModel.PeriodOutput;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<PressModel> GetAll()
        {
            auto pressList = new List<PressModel>();
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Наименование], [Период_выхода] from Издания";
                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto pressrModel = new PressModel();

                        pressrModel.Caption = reader[0].ToString();
                        pressrModel.PeriodOutput = reader[1].ToString();;
                        pressList.Add(pressrModel);
                    }
                }
            }
            return pressList;
        }

        IEnumerable<PressModel> GetByValue(string value)
        {
            auto pressList = new List<PressModel>();

            string pressCap = value;
            string pressOut = value;;

            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Наименование], [Период_выхода] from Издания
                                        where Наименование = @Наименование or Период_выхода = @Период_выхода
                                        ";
                command.Parameters.Add("@Наименование", SqlDbType.NautoChar).Value = pressCap;
                command.Parameters.Add("@Период_выхода", SqlDbType.NautoChar).Value = pressOut;

                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto pressModel = new PressModel();
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
