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
                command.CommandText = "insert into ���������� values (@�������, @���, @��������, @���������, @�����_��������)";
                command.Parameters.Add("@�������", SqlDbType.NautoChar).Value = workersModel.Surname;
                command.Parameters.Add("@���", SqlDbType.NautoChar).Value = workersModel.Name;
                command.Parameters.Add("@��������", SqlDbType.NautoChar).Value = workersModel.FatherName;
                command.Parameters.Add("@���������", SqlDbType.NautoChar).Value = workersModel.Special;
                command.Parameters.Add("@�����_��������", SqlDbType.NautoChar).Value = workersModel.Phone;
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
                command.CommandText = "delete from ���������� where �����_��������=@�����_��������";
                command.Parameters.Add("@�����_��������", SqlDbType.NautoChar).Value = number;
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
                command.CommandText = @"update ���������� 
                                        set ������� = @�������, ��� = @���, �������� = @��������, ��������� = @���������
                                        where �����_�������� = @�����_��������";
                command.Parameters.Add("@�������", SqlDbType.NautoChar).Value = workersModel.Surname;
                command.Parameters.Add("@���", SqlDbType.NautoChar).Value = workersModel.Name;
                command.Parameters.Add("@��������", SqlDbType.NautoChar).Value = workersModel.FatherName;
                command.Parameters.Add("@���������", SqlDbType.NautoChar).Value = workersModel.Special;
                command.Parameters.Add("@�����_��������", SqlDbType.NautoChar).Value = workersModel.Phone;
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
                command.CommandText = "Select [�������], [���], [��������], [���������], [�����_��������] from ����������";
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
                 command.CommandText = "Select [�������], [���], [��������], [���������], [�����_��������] from ����������
                                         where ��� = @��� or ��������� = @��������� or �������� = @�������� or ������� = @������� or �����_�������� = @�����_��������
                                         ";
                //  command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@���", SqlDbType.NautoChar).Value = workerName;
                command.Parameters.Add("@�������", SqlDbType.NautoChar).Value = workerSurname;
                command.Parameters.Add("@��������", SqlDbType.NautoChar).Value = workerFatherName;
                command.Parameters.Add("@���������", SqlDbType.NautoChar).Value = workerSpecial;
                command.Parameters.Add("@�����_��������", SqlDbType.NautoChar).Value = workerPhone;

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
