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
                command.CommandText = "insert into �������������_������� (����_��������, ���������, ������_��������, ������������) values (@����_��������, @���������, @������_��������, @������������)";
                command.Parameters.Add("@����_��������", SqlDbType.NVarChar).Value = periodModel.SrokSubscribe;
                command.Parameters.Add("@���������", SqlDbType.NVarChar).Value = periodModel.Sell;
                command.Parameters.Add("@������_��������", SqlDbType.NVarChar).Value = periodModel.TransferChoice;
                command.Parameters.Add("@������������", SqlDbType.NVarChar).Value = periodModel.Popularity;
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
                command.CommandText = "delete from �������������_������� where ������_��������=@������_��������";
                command.Parameters.Add("@������_��������", SqlDbType.NVarChar).Value = transferChoice;
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
                command.CommandText = @"update �������������_������� 
                                        set ����_�������� = @����_��������, ��������� = @���������, ������_�������� = @������_��������, ������������ = @������������
                                        where ������_�������� = @������_��������";
                command.Parameters.Add("@����_��������", SqlDbType.NVarChar).Value = periodModel.SrokSubscribe;
                command.Parameters.Add("@���������", SqlDbType.NVarChar).Value = periodModel.Sell;
                command.Parameters.Add("@������_��������", SqlDbType.NVarChar).Value = periodModel.TransferChoice;
                command.Parameters.Add("@������������", SqlDbType.NVarChar).Value = periodModel.Popularity;
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
                command.CommandText = "Select [����_��������], [���������], [������_��������], [������������] from �������������_�������";
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
                command.CommandText = "Select [����_��������], [���������], [������_��������], [������������] from �������������_�������
                                        where ��������� = @��������� or ������_�������� = @������_��������
                                        ";

                command.Parameters.Add("@���������", SqlDbType.NVarChar).Value = sell;
                command.Parameters.Add("@������_��������", SqlDbType.NVarChar).Value = choiceTransf;
                command.Parameters.Add("@������������", SqlDbType.NVarChar).Value = popularity;
                command.Parameters.Add("@����_��������", SqlDbType.NVarChar).Value = srokPodpis;

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
