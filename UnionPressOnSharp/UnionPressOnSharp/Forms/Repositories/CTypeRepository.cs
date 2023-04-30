using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionPressOnSharp.Forms.Models;

namespace UnionPressOnSharp.Forms.Repositories
{
    class CTypeRepository : CBaseRepository, ITypeRepository
    {
        public CTypeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddData(TypeModel typeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Тип_изданий values (@Тип)";
                command.Parameters.Add("@Тип", SqlDbType.NVarChar).Value = typeModel.Type;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteData(string type)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Тип_изданий where Тип=@Тип";
                command.Parameters.Add("@Тип", SqlDbType.NVarChar).Value = type;
                command.ExecuteNonQuery();
            }
        }

        public void EditData(TypeModel typeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Тип_изданий 
                                        set Тип=@Тип 
                                        where Тип=@Тип";
                command.Parameters.Add("@Тип", SqlDbType.NVarChar).Value = typeModel.Type;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TypeModel> GetAllType()
        {
            var typeList = new List<TypeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select [Тип] from Тип_изданий";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var typeModel = new TypeModel ();
                        // workerModel.Surname = (int)reader[0];
                        typeModel.Type = reader[0].ToString();
                        typeList.Add(typeModel);
                    }
                }
            }
            return typeList;
        }

        public IEnumerable<TypeModel> GetByValue(string value)
        {
            var typeList = new List<TypeModel>();
            // int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string pressTyper = value;
      
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select [Тип] from Тип_изданий
                                        where Тип=@Тип
                                        ";
                //  command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@Тип", SqlDbType.NVarChar).Value = pressTyper;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var typModel = new TypeModel();
                        typModel.Type = reader[0].ToString();
                        typeList.Add(typModel);
                    }
                }
            }
            return typeList;
        }
    
    }
}
