using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace UnionPressOnSharp.Forms.Classes
{
    public class LoginPass
    {
        
        public void RegistrationAccount(string login, string password, string name, string surname, string age, string sex, String connectionString)
        {
            //var settings = Properties.Settings.Default;

            if (login == "" || password == "" || name == "" || sex == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
              
                return;
            }

            if (RegisterCheck(login, connectionString))
                return;

            string commandText = "INSERT INTO dbo.Аккаунт VALUES (@Login, @Password, @Name, @Surname, @Age, @Sex)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();

          

             command.Parameters.Add("@Login", SqlDbType.NVarChar).Value = login;
             command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
             command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
             command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = surname;
             command.Parameters.Add("@Age", SqlDbType.NVarChar).Value = age;
             command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = sex;

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт уже существует");
            else
                MessageBox.Show("Аккаунт зарегистрирован");

            connection.Close();
           
        }

        public bool RegisterCheck(string login, string password, String connectionString)
        {
          
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string commandText = "SELECT * FROM Аккаунт WHERE Login=@Login AND Password=@Password";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();

            command.Parameters.Add("@Login", SqlDbType.NVarChar).Value = login;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вход выполнен");
                return true; 
            }
            else
            {
                MessageBox.Show("Ошибка, повторите попытку");
                return false;
            }

        }

        public bool RegisterCheck(string login, String connectionString)
        {
            
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string commandText = "SELECT * FROM Аккаунт WHERE Login=@Login";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();

            command.Parameters.Add("@Login", SqlDbType.NVarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вход выполнен");
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка, повторите попытку");
                return false;
            }

        }


        public void AuthorisationAccount(string login, string password, String connectionString)
        {
            //var settings = Properties.Settings.Default;

            if (login == "" || password == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (RegisterCheck(login, password, connectionString))
                return;

            string commandText = "SELECT * FROM Аккаунт WHERE Login=@login AND Password=@password";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();

           
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Неверный логин или пароль");
            else
                MessageBox.Show("Вход выполнен");

            connection.Close();
          
        }

    }
}
