using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Classes;
using UnionPressOnSharp.Forms.Models;
using UnionPressOnSharp.Forms.Presenters;
using UnionPressOnSharp.Forms.Repositories;
using UnionPressOnSharp.Forms.Views;
using UnionPressOnSharp.Forms.Exports;

namespace UnionPressOnSharp.Forms
{
    public partial class Workers : Form, IWorkersView
    {
       
        private string message;
        private bool successful;
        private bool isEdit;

        public event EventHandler SearchDataEvent;
        public event EventHandler AddNewDataEvent;
        public event EventHandler EditDataEvent;
        public event EventHandler DeleteDataEvent;
        public event EventHandler SaveDataEvent;
        public event EventHandler CancelEvent;

        private int counter = 0, searchCount = 0,
             counterLoad = 0, counterAdd = 0,
             counterEdit = 0, counterDelete = 0,
             counterSave = 0, counterBack = 0,
             counterExport = 0;

        public string WorkersSurname 
        {
            get { return txtSurname.Texts; }
            set { txtSurname.Texts = value; }
        }
        public string WorkersName 
        {
            get { return txtName.Texts; }
            set { txtName.Texts = value; }
        }
        public string WorkersFatherName 
        {
            get { return txtFatherName.Texts; }
            set { txtFatherName.Texts = value; }
        }
        public string WorkersSpecial 
        {
            get { return txtSpecial.Texts; }
            set { txtSpecial.Texts = value; }
        }
        public string WorkersNumber 
        {
            get { return txtNumber.Texts; }
            set { txtNumber.Texts = value; }
        }
        public string SearchValue
        {
            get { return txtW.Texts; }
            set { txtW.Texts = value; }
        }
        public bool isEditData 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool isSuccessful 
        { 
            get { return successful; }
            set { successful = value; }
        }
        public string Message 
        { 
            get { return message; }
            set { message = value; }
        }

        public Workers()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlW.TabPages.Remove(pageSettings);
        }
        private void AssociateAndRaiseViewEvents()
        {
            Logger logger = new Logger();
            //Поиск
            btnSearch.Click += delegate { SearchDataEvent?.Invoke(this, EventArgs.Empty); };
            txtW.KeyDown += (s, e) =>
            {
                counter++; searchCount++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CountSearchClick = counter;
                if (e.KeyCode == Keys.Enter)
                    SearchDataEvent?.Invoke(this, EventArgs.Empty);
                logger.Log("Поиск", " Workers.cs", " btnSearchType", "96");
            };
            //Добавить
            btnAddW.Click += delegate
            {
                counter++; counterAdd++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterAdd = counterAdd;
                AddNewDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlW.TabPages.Remove(pageMain);
                tabControlW.TabPages.Add(pageSettings);
                pageSettings.Text = "Добавление нового сотрудника";
                logger.Log("Добавить", " Workers.cs", " btnAddW", "107");
            };
            //Изменить
            btnEdit.Click += delegate
            {
                counter++; counterEdit++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterEdit = counterEdit;
                EditDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlW.TabPages.Remove(pageMain);
                tabControlW.TabPages.Add(pageSettings);
                pageSettings.Text = "Изменение сотрудника";
                logger.Log("Изменить", " Workers.cs", " btnEdit", "119");
            };
            //Сохранить
            btnSaveSettings.Click += delegate
            {
                counter++; counterSave++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterSave = counterSave;
                SaveDataEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlW.TabPages.Remove(pageSettings);
                    tabControlW.TabPages.Add(pageMain);
                }
                MessageBox.Show(Message);
                logger.Log("Сохранить", " Workers.cs", " btnSaveSettings", "131");
            };
            //Отмена
            btnCancelSettings.Click += delegate
            {
                counter++; counterBack++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterBack = counterBack;
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlW.TabPages.Remove(pageSettings);
                tabControlW.TabPages.Add(pageMain);
                logger.Log("Отмена", " Workers.cs", " btnCancelSettings", "146");
            };
            //Удалить
            btnDelW.Click += delegate
            {
                counter++; counterDelete++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterDelete = counterDelete;
                var result = MessageBox.Show("удалить выбранного работника?", "Внимание",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDataEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
                logger.Log("Удалить", " Workers.cs", " btnDelW", "157");
            };

        }

        private void btnAddW_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelW_Click(object sender, EventArgs e)
        {

        }

        private void btnExportW_Click(object sender, EventArgs e)
        {
            counter++; counterExport++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterExport = counterExport;
            ExportContextMenu.Show();

            Logger logger = new Logger();
            logger.Log("Экспорт", " Workers.cs", " btnExportW", "184");
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            gridW.Rows.Clear();
            ColorSet();
            Logger logger = new Logger();
            logger.Log("Открытие формы", " Workers.cs", " WorkersLoad", "195");
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            string font = "Archive";

            btnAddW.BackColor = settings.ColorButSet;
            btnDelW.BackColor = settings.ColorButSet;
            btnEdit.BackColor = settings.ColorButSet;
            btnExportW.BackColor = settings.ColorButSet;
            btnSaveSettings.BackColor = settings.ColorButSet;
            btnSearch.BackColor = settings.ColorButSet;
            btnLoadW.BackColor = settings.ColorButSet;
            btnCancelSettings.BackColor = settings.ColorButSet;

            ExpMenuItemWord.BackColor = settings.ColorButSet;
            ExpMenuItemExcel.BackColor = settings.ColorButSet;
            ExportContextMenu.BackColor = settings.ColorButSet;

            lblFatherName.Font = new Font(font, settings.SizeFontSet);
            lblName.Font = new Font(font, settings.SizeFontSet);
            lblNumber.Font = new Font(font, settings.SizeFontSet);
            lblSpecial.Font = new Font(font, settings.SizeFontSet);
            lblSurname.Font = new Font(font, settings.SizeFontSet);
            lblTitle.Font = new Font(font, settings.SizeFontSet);

            lblFatherName.ForeColor = settings.ColorFontLblSet;
            lblName.ForeColor = settings.ColorFontLblSet;
            lblNumber.ForeColor = settings.ColorFontLblSet;
            lblSpecial.ForeColor = settings.ColorFontLblSet;
            lblSurname.ForeColor = settings.ColorFontLblSet;
            lblTitle.ForeColor = settings.ColorFontLblSet;

            txtW.BorderColor = settings.ColorTextBoxSet;
            txtW.BorderFocusColor = settings.ColorTxtFocus;
            txtW.BackColor = settings.ColorPanelSet;
            txtW.ForeColor = settings.ColorFontLblSet;

            txtFatherName.BorderColor = settings.ColorTextBoxSet;
            txtFatherName.BorderFocusColor = settings.ColorTxtFocus;
            txtFatherName.ForeColor = settings.ColorFontLblSet;
            txtFatherName.BackColor = settings.ColorPanelSet;

            txtName.BorderColor = settings.ColorTextBoxSet;
            txtName.BorderFocusColor = settings.ColorTxtFocus;
            txtName.ForeColor = settings.ColorFontLblSet;
            txtName.BackColor = settings.ColorPanelSet;

            txtNumber.BorderColor = settings.ColorTextBoxSet;
            txtNumber.BorderFocusColor = settings.ColorTxtFocus;
            txtNumber.ForeColor = settings.ColorFontLblSet;
            txtNumber.BackColor = settings.ColorPanelSet;

            txtSpecial.BorderColor = settings.ColorTextBoxSet;
            txtSpecial.BorderFocusColor = settings.ColorTxtFocus;
            txtSpecial.ForeColor = settings.ColorFontLblSet;
            txtSpecial.BackColor = settings.ColorPanelSet;

            txtSurname.BorderColor = settings.ColorTextBoxSet;
            txtSurname.BorderFocusColor = settings.ColorTxtFocus;
            txtSurname.ForeColor = settings.ColorFontLblSet;
            txtSurname.BackColor = settings.ColorPanelSet;

            pageMain.BackColor = settings.ColorPanelSet;
            pageSettings.BackColor = settings.ColorPanelSet;
            BackColor = settings.ColorPanelSet;
        }


        public void SetWorkersListBindingSource(BindingSource workerList)
        {
            gridW.DataSource = workerList;
        }
        private void btnLoadW_Click_1(object sender, EventArgs e)
        {
            counter++; counterLoad++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterLoad = counterLoad;
            // FunctionsDB.LoadData(gridW, strWorkers);
            IWorkersView workersView = this;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            IWorkersRepository workersRepository = new CWorkersRepository(sqlConnectionString);
            new WorkersPresenter(workersView, workersRepository);

            Logger logger = new Logger();
            logger.Log("Загрузка из бд", " Workers.cs", "btnLoadW", "275");

        }

        private void ExpMenuItemExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.excelExport(gridW);

            Logger logger = new Logger();
            logger.Log("Экспорт в Excel", " Workers.cs", " ExpMenuItemExcel", "291");
        }

        private void ExpMenuItemWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            WordExport wordExport = new WordExport();

            save.Filter = "Word документы (*.doc)|*.doc";
            save.FileName = "";

            if (save.ShowDialog() == DialogResult.OK)
                wordExport.wordExport(gridW, save.FileName);

            Logger logger = new Logger();
            logger.Log("Экспорт в Word", " Workers.cs", " ExpMenuItemWord", "300");
        }
    }
}
