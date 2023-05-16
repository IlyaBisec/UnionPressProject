#include "LoginPass.h";



void registrationAccount(std::string login, std::string password,
	std::string name, std::string surname, std::string age,
	std::string sex, System::String connectionString)
{

    if (login == "" || password == "" || name == "" || sex == "")
    {
        MessageBox::Show("��������� ��� ����", "������");

        return;
    }

    if (RegisterCheck(login, connectionString))
        return;

    std::string commandText = "INSERT INTO dbo.������� VALUES (@Login, @Password, @Name, @Surname, @Age, @Sex)";

    SqlConnection^ connection = gcnew SqlConnection(connectionString);
    SqlCommand^ command = gcnew SqlCommand(commandText, connection);
    connection->Open();



    command->Parameters.Add("@Login", SqlDbType::NVarChar).Value = login;
    command->Parameters.Add("@Password", SqlDbType::NVarChar).Value = password;
    command->Parameters.Add("@Name", SqlDbType::NVarChar).Value = name;
    command->Parameters.Add("@Surname", SqlDbType::NVarChar).Value = surname;
    command->Parameters.Add("@Age", SqlDbType::NVarChar).Value = age;
    command->Parameters.Add("@Sex", SqlDbType::NVarChar).Value = sex;

    if (command->ExecuteNonQuery() == 1)
        MessageBox::Show("������� ��� ����������");
    else
        MessageBox::Show("������� ���������������");

    connection->Close();


}

void authorisationAccount(std::string login, std::string password, String connectionString)
{
    if (login == "" || password == "")
    {
        MessageBox::Show("��������� ��� ����", "������");
        return;
    }

    if (RegisterCheck(login, password, connectionString))
        return;

    std::string commandText = "SELECT * FROM ������� WHERE Login=@login AND Password=@password";

    SqlConnection^ connection = gcnew SqlConnection(connectionString);
    SqlCommand^ command = gcnew SqlCommand(commandText, connection);

    connection->Open();


    command->Parameters.Add("@login", SqlDbType::NVarChar).Value = login;
    command->Parameters.Add("@password", SqlDbType::NVarChar).Value = password;

    if (command->ExecuteNonQuery() == 1)
        MessageBox::Show("�������� ����� ��� ������");
    else
        MessageBox::Show("���� ��������");

    connection.Close();
}

bool registerCheck(std::string login, std::string password, String connectionString)
{
    DataTable^ table = gcnew DataTable();
    SqlDataAdapter^ adapter = gcnew SqlDataAdapter();

    std::string commandText = "SELECT * FROM ������� WHERE Login=@Login AND Password=@Password";
    SqlConnection^ connection = gcnew SqlConnection(connectionString);
    SqlCommand^ command = gcnew SqlCommand(commandText, connection);

    connection->Open();

    command->Parameters.Add("@Login", SqlDbType::NVarChar).Value = login;
    command->Parameters.Add("@Password", SqlDbType::NVarChar).Value = password;

    adapter->SelectCommand = command;
    adapter->Fill(table);

    if (table->Rows.Count > 0)
    {
        MessageBox::Show("���� ��������");
        return true;
    }
    else
    {
        MessageBox::Show("������, ��������� �������");
        return false;
    }
}

bool RegisterCheck(std::string login, String connectionString)
{
    DataTable^ table = gcnew DataTable();
    SqlDataAdapter^ adapter = gcnew SqlDataAdapter();

    std::string commandText = "SELECT * FROM ������� WHERE Login=@Login";
    SqlConnection^ connection = gcnew SqlConnection(connectionString);
    SqlCommand^ command = gcnew SqlCommand(commandText, connection);

    connection->Open();

    command->Parameters.Add("@Login", SqlDbType::NVarChar).Value = login;

    adapter->SelectCommand = command;
    adapter->Fill(table);

    if (table->Rows.Count > 0)
    {
        MessageBox::Show("���� ��������");
        return true;
    }
    else
    {
        MessageBox::Show("������, ��������� �������");
        return false;
    }
}