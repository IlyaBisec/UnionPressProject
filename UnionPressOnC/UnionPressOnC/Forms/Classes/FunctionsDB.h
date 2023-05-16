//#include "C:/Program Files (x86)/Reference Assemblies/Microsoft/Framework/.NETFramework/v4.8/System.Data.dll"

using namespace System;
using namespace System::Data;
using namespace System::Data::SqlClient;
using namespace System::Configuration;
using namespace System::Windows::Forms;

ref class FunctionsDB
{
	#pragma region Initialization_data
public:

	SqlConnection^ sqlCon = nullptr;
	
	SqlCommand^ cmd;
	DataTable^ table;
	SqlDataAdapter^ adapter;

	String^ pathType = "INSERT INTO ���_������� VALUES" + "(@���)";
	String^ pathWorkers = "INSERT INTO ���������� VALUES" + "(@�������, @���, @��������, @���������, @�����_��������)";
	String^ pathTransfer = "INSERT INTO �������� VALUES" + "(@����_������, @����_���������)";
	String^ pathPress = "INSERT INTO ������� VALUES" + "(@������������, @������_������)";
	String^ pathSeasonP = "INSERT INTO �������������_������� VALUES" + "(@����_��������, @���������, @������_��������, @������������_%)";

	String^ updWorkers = "UPDATE ���������� SET ������� = @�������, ��� = @���, �������� = @��������, ��������� = @���������, �����_�������� = @�����_��������";
	

	String^ typeParamName = "@���";					String^ endParamName = "@����_���������";
	String^ surnameParamName = "@�������";			String^ titleParamName = "@������������";
	String^ nameParamName = "@���";					String^ seasonPressParamName = "@������_������";
	String^ fatherNameParamName = "@��������";		String^ subscribeParamName = "@����_��������";
	String^ specialParamName = "@���������";		String^ sellParamName = "@���������";
	String^ beginParamName = "@����_������";		String^ transferParamName = "@������_��������";
	String^ numberParamName = "@�����_��������";	String^ popularityParamName = "@������������_%";
	#pragma endregion

	void connectToDB()
	{
		sqlCon = gcnew SqlConnection(ConfigurationManager::ConnectionStrings["UnionPressDB"]->ConnectionString);
		sqlCon->Open();

		if (sqlCon == nullptr)
		{
			sqlCon->Close(); MessageBox::Show("������, ��� ����������");
		}
	}

	//old
	void writeData(SqlCommand command)
	{
		try
		{
			connectToDB();
			command.Connection = sqlCon;
			command.ExecuteNonQuery();
		}
		finally
		{
			if (sqlCon != nullptr)
				sqlCon->Close();
		}
	}
	void loadData(DataGridView dataGridView, String^ path)
	{
		connectToDB();

		cmd = gcnew SqlCommand(path, sqlCon);
		table = gcnew DataTable();
		adapter = gcnew SqlDataAdapter(path, sqlCon);

		adapter->Fill(table);
		dataGridView.DataSource = table;
		cmd->ExecuteNonQuery();

	}
	void saveDataType(DataGridView dataGridView)
	{
		/*String^ gridValue;

		try
		{
			if (dataGridView.RowCount >= 1)
			{
				for (int i = 0; i < dataGridView.RowCount - 1; i++)
				{
					if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != nullptr)
					{
						SqlCommand^ cmd = gcnew SqlCommand(pathType, sqlCon);

						gridValue = dataGridView.Rows[i].Cells[0].Value.ToString();
						cmd.Parameters.AddWithValue(typeParamName, gridValue);

						writeData(cmd);
					}
				}
			}
			MessageBox::Show("���������� ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}*/
	}
	void deleteData(DataGridView dataGridView);
	void updateDataWorkers(DataGridView dataGridView)
	{
		/*try {

			for (int i = 0; i < dataGridView.RowCount - 1; i++)
			{
				if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != nullptr)
				{
					cmd = gcnew SqlCommand(updWorkers, sqlCon);

					cmd.Parameters.Add(surnameParamName, SqlDbType::VarChar).Value = dataGridView.Rows[i].Cells[0].Value.ToString();
					cmd.Parameters.Add(nameParamName, SqlDbType::VarChar).Value = dataGridView.Rows[i].Cells[1].Value.ToString();
					cmd.Parameters.Add(fatherNameParamName, SqlDbType::VarChar).Value = dataGridView.Rows[i].Cells[2].Value.ToString();
					cmd.Parameters.Add(specialParamName, SqlDbType::VarChar).Value = dataGridView.Rows[i].Cells[3].Value.ToString();
					cmd.Parameters.Add(numberParamName, SqlDbType::VarChar).Value = dataGridView.Rows[i].Cells[4].Value.ToString();

					writeData(cmd);
				}
			}
			MessageBox::Show("���������� ���������", "���������", MessageBoxButtons::OK, MessageBoxIcon::Information);
		}

		catch (Exception^ ex)
		{
			MessageBox::Show(ex->Message, "������", MessageBoxButtons::OK, MessageBoxIcon::Error);
		}*/
	}
};
