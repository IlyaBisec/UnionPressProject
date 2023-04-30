using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace UnionPressOnSharp.Forms.Classes
{
    public class FunctionsDB
	{

        #region Initialization_info
        SqlConnection sqlCon = null;

		SqlCommand cmd;
		DataTable table;
		SqlDataAdapter adapter;
		//SqlCommandBuilder builder;



		String pathType =		"INSERT INTO Тип_изданий VALUES" + "(@Тип)";
		String pathWorkers =	"INSERT INTO Сотрудники VALUES" + "(@Фамилия, @Имя, @Отчество, @Должность, @Номер_телефона)";
		String pathTransfer =	"INSERT INTO Доставка VALUES" + "(@Дата_начала, @Дата_окончания)";
		String pathPress =		"INSERT INTO Издания VALUES" + "(@Наименование, @Период_выхода)";
		String pathSeasonP =	"INSERT INTO Периодические_издания VALUES" + "(@Срок_подписки, @Стоимость, @Способ_доставки, @Популярность_%)";

		String updWorkers =			"UPDATE Сотрудники SET Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество, Должность = @Должность, Номер_телефона = @Номер_телефона";
		//String updTransfer =		"UPDATE Доставка SET Дата_начала = @Дата_начала, Дата_окончания = @Дата_окончания";
//		String updPress =			"UPDATE Издания SET Наименование = @Наименование, Период_выхода = @Период_выхода";
	//	String updSeasonPress =		"UPDATE Периодические_издания SET Срок_подписки = @Срок_подписки, Стоимость = @Стоимость, Способ_доставки = @Способ_доставки, Популярность_% =  @Популярность_%";

		//String[] workersParametr =		{ "@Фамилия", "@Имя", "@Отчество", "@Должность", "@Номер_телефона"};
		//String[] transferParametr =     { "@Дата_начала", "@Дата_окончания"};
		//String[] pressParametr =        { "@Наименование", "@[Период. выхода]" };
		//String[] seasonPParametr =      { "@Срок_подписки", "@Стоимость", "@Способ_доставки", "@Популярность_%"};

		String typeParamName =			"@Тип";				String endParamName =			"@Дата_окончания";
		String surnameParamName =		"@Фамилия";			String titleParamName =			"@Наименование";
		String nameParamName =			"@Имя";				String seasonPressParamName =	"@Период_выхода";
		String fatherNameParamName =	"@Отчество";		String subscribeParamName =		"@Срок_подписки";
		String specialParamName =		"@Должность";		String sellParamName =			"@Стоимость";
		String beginParamName =			"@Дата_начала";		String transferParamName =		"@Способ_доставки";
		String numberParamName =		"@Номер_телефона";	String popularityParamName =	"@Популярность_%";

        #endregion


        public void ConnectToDB()
		{
			sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString);
			sqlCon.Open();

			if (sqlCon == null)
			{
				sqlCon.Close(); MessageBox.Show("Ошибка, нет соединения");
			}

		}

		void WriteData(SqlCommand command)
		{
			try
			{
				ConnectToDB();
				command.Connection = sqlCon;

				command.ExecuteNonQuery();
			}

			finally
			{
				if (sqlCon != null)
					sqlCon.Close();
			}
		}


        public void LoadData(DataGridView datagridView, String path)
		{
			ConnectToDB();

			cmd = new SqlCommand(path, sqlCon);
			table = new DataTable();
			adapter = new SqlDataAdapter(path, sqlCon);

			adapter.Fill(table);
			datagridView.DataSource = table;
			cmd.ExecuteNonQuery();
		}

		#region SaveData

		public void SaveDataType(DataGridView dataGridView)
		{

			String gridValue;

			try
			{
				if (dataGridView.RowCount >= 1)
				{
					for (int i = 0; i < dataGridView.RowCount - 1; i++)
					{
						if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != null)
						{
							cmd = new SqlCommand(pathType, sqlCon);

							gridValue = dataGridView.Rows[i].Cells[0].Value.ToString();
							cmd.Parameters.AddWithValue(typeParamName, gridValue);

							WriteData(cmd);
						}
					}
				}
				MessageBox.Show("Информация сохранена", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		public void SaveDataWorkers(DataGridView dataGridView)
		{

			//String gridValue;

			try
			{
				if (dataGridView.RowCount >= 1)
				{
					for (int i = 0; i < dataGridView.RowCount - 1; i++)
					{
						if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != null)
						{
							cmd = new SqlCommand(pathWorkers, sqlCon);


							//	gridValue = dataGridView.Rows[i].Cells[0].Value.ToString();
							/*cmd.Parameters.AddWithValue(surnameParamName, dataGridView.Rows[i].Cells[0].Value.ToString());
							*/

							cmd.Parameters.Add(surnameParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[0].Value.ToString();
							cmd.Parameters.Add(nameParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[1].Value.ToString();
							cmd.Parameters.Add(fatherNameParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[2].Value.ToString();
							cmd.Parameters.Add(specialParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[3].Value.ToString();
							cmd.Parameters.Add(numberParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[4].Value.ToString();


							WriteData(cmd);

						}
					}
				}
				MessageBox.Show("Информация сохранена", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		public void SaveDataTransfer(DataGridView dataGridView)
		{

			try
			{

				if (dataGridView.RowCount >= 1)
				{
					for (int i = 0; i < dataGridView.RowCount - 1; i++)
					{
						if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != null)
						{
							cmd = new SqlCommand(pathTransfer, sqlCon);

							cmd.Parameters.Add(beginParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[0].Value.ToString();
							cmd.Parameters.Add(endParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[1].Value.ToString();

							WriteData(cmd);
						}
					}
				}
				MessageBox.Show("Информация сохранена", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		public void SaveDataPress(DataGridView dataGridView)
		{
			try
			{
				if (dataGridView.RowCount >= 1)
				{
					for (int i = 0; i < dataGridView.RowCount - 1; i++)
					{
						if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != null)
						{
							cmd = new SqlCommand(pathPress, sqlCon);

							cmd.Parameters.Add(titleParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[0].Value.ToString();
							cmd.Parameters.Add(seasonPressParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[1].Value.ToString();

							WriteData(cmd);
						}
					}
				}
				MessageBox.Show("Информация сохранена", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		public void SaveDataSeason(DataGridView dataGridView)
		{
			try
			{
				if (dataGridView.RowCount >= 1)
				{
					for (int i = 0; i < dataGridView.RowCount - 1; i++)
					{
						if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != null)
						{
							cmd = new SqlCommand(pathSeasonP, sqlCon);

							cmd.Parameters.Add(subscribeParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[0].Value.ToString();
							cmd.Parameters.Add(sellParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[1].Value.ToString();
							cmd.Parameters.Add(transferParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[2].Value.ToString();
							cmd.Parameters.Add(popularityParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[3].Value.ToString();

							WriteData(cmd);
						}
					}
				}
				MessageBox.Show("Информация сохранена", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


        #endregion

		#region UpdateData
        public void UpdateDataWorkers(DataGridView dataGridView)
        {
			try { 

				for (int i = 0; i < dataGridView.RowCount - 1; i++)
				{
					if (dataGridView.Rows[i].Cells[0].Value.ToString() != "" && dataGridView.Rows[i].Cells[0].Value != null)
					{
						cmd = new SqlCommand(updWorkers, sqlCon);

						cmd.Parameters.Add(surnameParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[0].Value.ToString();
						cmd.Parameters.Add(nameParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[1].Value.ToString();
						cmd.Parameters.Add(fatherNameParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[2].Value.ToString();
						cmd.Parameters.Add(specialParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[3].Value.ToString();
						cmd.Parameters.Add(numberParamName, SqlDbType.VarChar).Value = dataGridView.Rows[i].Cells[4].Value.ToString();

						WriteData(cmd);
					}
				}
				MessageBox.Show("Информация обновлена", "Обновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		









		public void DeleteData(DataGridView dataGridView)
		{
			/*void DeleteResult()
			{
				SqlCommand ^ command = gcnew SqlCommand();
				String ^ commandText = "EXECUTE usp_DeleteAnswers @UserId, @VotingId";
				command->Parameters->AddWithValue("@UserId", MainForm::CurrentAccount->Id);
				command->Parameters->AddWithValue("@VotingId", this->Id);
				command->CommandText = commandText;
				DatabaseManager::Write(command);
			}*/
		}


	}
}


/*if (dataGridView.RowCount >= 1)
		{
			for (int x = 0; x < dataGridView.RowCount - 1; x++)
			{
				if (dataGridView.Rows[x].Cells[0].Value.ToString() != "" && dataGridView.Rows[x].Cells[0].Value != null)
				{
					//SqlCommand cmdSave = new SqlCommand("UPDATE tblRecord SET FName=@FName,   Address=@Address, ContactNo=@ContactNo WHERE IdNo=@IdNo", sqlCon);
					cmd = new SqlCommand(path, sqlCon);

					cmd.Parameters.Add("@Тип", SqlDbType.VarChar).Value = dataGridView.Rows[x].Cells[0].Value.ToString();
					//cmdSave.Parameters.Add("@FName", SqlDbType.VarChar).Value = dgv.Rows[x].Cells[1].Value.ToString();
					//cmdSave.Parameters.Add("@Address", SqlDbType.VarChar).Value = dgv.Rows[x].Cells[2].Value.ToString();
					//cmdSave.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = dgv.Rows[x].Cells[3].Value.ToString();

					sqlCon.Open();
					cmd.ExecuteNonQuery();
					sqlCon.Close();
					MessageBox.Show("Сохранено!");
				}
			}
		}*/
