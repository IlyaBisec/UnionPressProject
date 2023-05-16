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

	String^ pathType = "INSERT INTO Тип_изданий VALUES" + "(@Тип)";
	String^ pathWorkers = "INSERT INTO Сотрудники VALUES" + "(@Фамилия, @Имя, @Отчество, @Должность, @Номер_телефона)";
	String^ pathTransfer = "INSERT INTO Доставка VALUES" + "(@Дата_начала, @Дата_окончания)";
	String^ pathPress = "INSERT INTO Издания VALUES" + "(@Наименование, @Период_выхода)";
	String^ pathSeasonP = "INSERT INTO Периодические_издания VALUES" + "(@Срок_подписки, @Стоимость, @Способ_доставки, @Популярность_%)";

	String^ updWorkers = "UPDATE Сотрудники SET Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество, Должность = @Должность, Номер_телефона = @Номер_телефона";
	

	String^ typeParamName = "@Тип";					String^ endParamName = "@Дата_окончания";
	String^ surnameParamName = "@Фамилия";			String^ titleParamName = "@Наименование";
	String^ nameParamName = "@Имя";					String^ seasonPressParamName = "@Период_выхода";
	String^ fatherNameParamName = "@Отчество";		String^ subscribeParamName = "@Срок_подписки";
	String^ specialParamName = "@Должность";		String^ sellParamName = "@Стоимость";
	String^ beginParamName = "@Дата_начала";		String^ transferParamName = "@Способ_доставки";
	String^ numberParamName = "@Номер_телефона";	String^ popularityParamName = "@Популярность_%";
	#pragma endregion

	void connectToDB()
	{
		sqlCon = gcnew SqlConnection(ConfigurationManager::ConnectionStrings["UnionPressDB"]->ConnectionString);
		sqlCon->Open();

		if (sqlCon == nullptr)
		{
			sqlCon->Close(); MessageBox::Show("Ошибка, нет соединения");
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
			MessageBox::Show("Информация сохранена", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			MessageBox::Show("Информация обновлена", "Обновлено", MessageBoxButtons::OK, MessageBoxIcon::Information);
		}

		catch (Exception^ ex)
		{
			MessageBox::Show(ex->Message, "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
		}*/
	}
};
