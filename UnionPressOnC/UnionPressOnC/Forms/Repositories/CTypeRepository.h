#include "CBaseRepository.h"
#include "../Models/ITypeRepository.h"

using namespace System::Collections::Generic;
using namespace System::Data;
using namespace System::Data::SqlClient;
using namespace UnionPressOnC;

namespace UnionPressOnC
{
    class CTypeRepository : CBaseRepository, ITypeRepository
    {
    public:
        
        CTypeRepository(string connectionString)
        {
            this->connectionString = connectionString;
        }

        void AddData(TypeModel typeModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Тип_изданий values (@Тип)";
                command.Parameters.Add("@Тип", SqlDbType.NautoChar).Value = typeModel.Type;
                command.ExecuteNonQuery();
            }
        }

        void DeleteData(string type)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Тип_изданий where Тип=@Тип";
                command.Parameters.Add("@Тип", SqlDbType.NautoChar).Value = type;
                command.ExecuteNonQuery();
            }
        }

        void EditData(TypeModel typeModel)
        {
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update Тип_изданий 
                                        set Тип = @Тип
                                        where Тип = @Тип";
                command.Parameters.Add("@Тип", SqlDbType.NautoChar).Value = typeModel.Type;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<TypeModel> GetAllType()
        {
            auto typeList = new List<TypeModel>();
            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Тип] from Тип_изданий";
                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto typeModel = new TypeModel();
                        // workerModel.Surname = (int)reader[0];
                        typeModel.Type = reader[0].ToString();
                        typeList.Add(typeModel);
                    }
                }
            }
            return typeList;
        }

        IEnumerable<TypeModel> GetByValue(string value)
        {
            auto typeList = new List<TypeModel>();
            // int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string pressTyper = value;

            using (auto connection = new SqlConnection(connectionString))
            using (auto command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Тип] from Тип_изданий
                                        where Тип = @Тип
                                        ";
                //  command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@Тип", SqlDbType.NautoChar).Value = pressTyper;

                using (auto reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        auto typModel = new TypeModel();
                        typModel.Type = reader[0].ToString();
                        typeList.Add(typModel);
                    }
                }
            }
            return typeList;
        }

    }
}
