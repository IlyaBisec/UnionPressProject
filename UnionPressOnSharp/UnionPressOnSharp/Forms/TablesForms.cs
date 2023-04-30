using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using UnionPressOnSharp.Forms.Classes;


namespace UnionPressOnSharp
{
    
    public partial class TablesForms : Form
    {

        
        FunctionsDB FunctionsDB = new FunctionsDB();

        public TablesForms()
        {
            InitializeComponent();
        }

        private void TablesForms_Load(object sender, EventArgs e)
        {
            MainGridView.Rows.Clear();
        }


        #region MenuStrip
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionsDB.ConnectToDB();
            MessageBox.Show("Подключение установлено!\nБаза данных загружена");

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (
                tabControl.SelectedIndex.ToString() == "0" || 
                tabControl.SelectedIndex.ToString() == "1" ||
                tabControl.SelectedIndex.ToString() == "2" ||
                tabControl.SelectedIndex.ToString() == "3" ||
                tabControl.SelectedIndex.ToString() == "4"
                )
            {

                FunctionsDB.SaveDataType(dataGridView1);
                FunctionsDB.SaveDataWorkers(dataGridView2);
                FunctionsDB.SaveDataSeason(dataGridView3);
                FunctionsDB.SaveDataPress(dataGridView4);
                FunctionsDB.SaveDataTransfer(dataGridView5);


                MessageBox.Show("Сохранено!");
            }
            else
            {
                MessageBox.Show("Ошибка сохранения");
                return;
               
            }
        }

        private void экспортироватьВToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #region TabButton
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string strTransfer = "доставкаBindingSource";
            string strPress = "изданияBindingSource";
            string strSeasonPress = "периодические_изданияBindingSource";
            string strWorkers = "сотрудникиBindingSource";
            string strPressType = "тип_изданийBindingSource";*/


            String strTransfer =    "SELECT [Дата_начала], [Дата_окончания] FROM  dbo.Доставка ";
            String strPress =       "SELECT [Наименование], [Период_выхода]  FROM  dbo.Издания";
            String strSeasonPress = "SELECT [Срок_подписки], [Стоимость], [Способ_доставки], [Популярность_%]  FROM  dbo.Периодические_издания";
            String strWorkers =     "SELECT [Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона]  FROM  dbo.Сотрудники";
            String strPressType =   "SELECT [Тип] FROM  dbo.Тип_изданий";

            // tabControl.TabPages[0].Controls.Add(dataGridView1);
            //MainGridView.Refresh();
            //dataGridView1.DataSource = тип_изданийTableAdapter.Fill(souz_PechatiDataSet.Тип_изданий);

            switch (tabControl.SelectedIndex.ToString())
            {
                case "0":
                    //dataGridView1.DataSource = strPressType;
                    FunctionsDB.LoadData(dataGridView1, strPressType);
                    tabControl.TabPages[0].Controls.Add(dataGridView1);
                    this.Controls.Add(dataGridView1);
                    dataGridView1.BringToFront();
                    this.Text = "Тип изданий";
                    break;
                case "1":

                    //dataGridView2.DataSource = strWorkers;
                    FunctionsDB.LoadData(dataGridView2, strWorkers);
                    tabControl.TabPages[1].Controls.Add(dataGridView2);
                    this.Controls.Add(dataGridView2);
                    dataGridView2.BringToFront();
                    this.Text = "Сотрудники";
                    break;
                case "2":
                    // dataGridView3.DataSource = strSeasonPress;
                    FunctionsDB.LoadData(dataGridView3, strSeasonPress);
                    tabControl.TabPages[2].Controls.Add(dataGridView3);
                    this.Controls.Add(dataGridView3);
                    dataGridView3.BringToFront();
                    this.Text = "Периодические издания";
                    break;
                case "3":
                    //  dataGridView4.DataSource = strPress;
                    FunctionsDB.LoadData(dataGridView4, strPress);
                    tabControl.TabPages[3].Controls.Add(dataGridView4);
                    this.Controls.Add(dataGridView4);
                    dataGridView4.BringToFront();
                    this.Text = "Издания";
                    break;
                case "4":
                    // dataGridView5.DataSource = strTransfer;
                    FunctionsDB.LoadData(dataGridView5, strTransfer);
                    tabControl.TabPages[4].Controls.Add(dataGridView5);
                    this.Controls.Add(dataGridView5);
                    dataGridView5.BringToFront();
                    this.Text = "Доставка";
                    break;
                default: 
                    MainGridView.DataSource = null;
                    MainGridView.Rows.Clear();
                    this.Text = "Пустой проект";
                    break;
            }
                   /* case "tbPage1": MessageBox.Show("Выбрана вкладка 1"); break;
                    case "tbPage2": MessageBox.Show("Выбрана вкладка 2"); break;
                    case "tbPage3": MessageBox.Show("Выбрана вкладка 3"); break;
                    case "tbPage4": MessageBox.Show("Выбрана вкладка 3"); break;
                    case "tbPage5": MessageBox.Show("Выбрана вкладка 3"); break;*/
        }
        #endregion

        #region DataGrids
        private void MainGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
#endregion
    }




    /*FunctionsDB^ functionsDB;
	String^ path = "SELECT * FROM  dbo.Доставка";
	functionsDB->LoadData(MainGridView, path);
    */






}
