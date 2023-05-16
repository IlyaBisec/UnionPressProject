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
                command.CommandText = "insert into ������� (������������, ������_������) values (@������������, @������_������)";
                command.Parameters.Add("@������������", SqlDbType.NautoChar).Value = pressModel.Caption;
                command.Parameters.Add("@������_������", SqlDbType.NautoChar).Value = pressModel.PeriodOutput;
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
                command.CommandText = "delete from ������� where ������������=@������������";
                command.Parameters.Add("@������������", SqlDbType.NautoChar).Value = caption;
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
                command.CommandText = "update ������� 
                                        set ������������ = @������������, ������_������ = @������_������
                                        where ������������ = @������������";
                command.Parameters.Add("@������������", SqlDbType.NautoChar).Value = pressModel.Caption;
                command.Parameters.Add("@������_������", SqlDbType.NautoChar).Value = pressModel.PeriodOutput;
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
                command.CommandText = "Select [������������], [������_������] from �������";
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
                command.CommandText = "Select [������������], [������_������] from �������
                                        where ������������ = @������������ or ������_������ = @������_������
                                        ";
                command.Parameters.Add("@������������", SqlDbType.NautoChar).Value = pressCap;
                command.Parameters.Add("@������_������", SqlDbType.NautoChar).Value = pressOut;

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
