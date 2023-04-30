using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Configuration;
using UnionPressOnSharp.Forms.Exports;

namespace UnionPressOnSharp.Forms
{
    public partial class Press : Form, IPressView
    {
        public Press()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlPress.TabPages.Remove(pageSettings);
        }

        public string PressCaption
        {
            get { return txtCaption.Texts; }
            set { txtCaption.Texts = value; }
        }
        public string PressOutput
        {
            get { return txtPeriodOutput.Texts; }
            set { txtPeriodOutput.Texts = value; }
        }
        public string SearchValue
        {
            get { return txtPress.Texts; }
            set { txtPress.Texts = value; }
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

        public void SetPressListBindingSource(BindingSource pressList)
        {
            gridPress.DataSource = pressList;
        }

        private void AssociateAndRaiseViewEvents()
        {
            Logger logger = new Logger();
            //Поиск
            btnSearchPress.Click += delegate { SearchDataEvent?.Invoke(this, EventArgs.Empty); };
            txtPress.KeyDown += (s, e) =>
            {
                counter++; searchCount++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CountSearchClick = searchCount;
                if (e.KeyCode == Keys.Enter)
                    SearchDataEvent?.Invoke(this, EventArgs.Empty);

                logger.Log("Поиск", "Press.cs", "btnSearchPress", "87");
            };
            //Добавить
            btnAddPress.Click += delegate
            {
                counter++; counterAdd++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterAdd = counterAdd;
                AddNewDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlPress.TabPages.Remove(pageMain);
                tabControlPress.TabPages.Add(pageSettings);
                pageSettings.Text = "Добавление нового издания";

                logger.Log("Добавление", "Press.cs", "btnAddPress", "99");
            };
            //Изменить
            btnEditPress.Click += delegate
            {
                counter++; counterEdit++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterEdit = counterEdit;
                EditDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlPress.TabPages.Remove(pageMain);
                tabControlPress.TabPages.Add(pageSettings);
                pageSettings.Text = "Изменение издания";

                logger.Log("Редактирование", "Press.cs", "btnEditPress", "112");
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
                    tabControlPress.TabPages.Remove(pageSettings);
                    tabControlPress.TabPages.Add(pageMain);
                }
                MessageBox.Show(Message);

                logger.Log("Сохранение", "Press.cs", "btnSaveSettings", "125");
            };
            //Отмена
            btnCancelSettings.Click += delegate
            {
                counter++; counterBack++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterBack = counterBack;
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlPress.TabPages.Remove(pageSettings);
                tabControlPress.TabPages.Add(pageMain);

                logger.Log("Отмена", "Press.cs", "btnCancelSettings", "141");
            };
            //Удалить
            btnDelPress.Click += delegate
            {
                counter++; counterDelete++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterDelete = counterDelete;
                var result = MessageBox.Show("удалить выбранное издание?", "Внимание",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDataEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
                logger.Log("Удаление", "Press.cs", "btnDelPress", "153");
            };

        }


        private void Press_Load(object sender, EventArgs e)
        {
            ColorSet();
            Logger logger = new Logger();
            logger.Log("Загрузка формы", "Press.cs", "Press_Load", "171");
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            string font = "Archive";

            btnAddPress.BackColor = settings.ColorButSet;
            btnDelPress.BackColor = settings.ColorButSet;
            btnEditPress.BackColor = settings.ColorButSet;
            btnLoadPress.BackColor = settings.ColorButSet;
            btnExportPress.BackColor = settings.ColorButSet;
            btnSearchPress.BackColor = settings.ColorButSet;
            btnCancelSettings.BackColor = settings.ColorButSet;
            btnSaveSettings.BackColor = settings.ColorButSet;

            ExpMenuItemExcel.BackColor = settings.ColorButSet;
            ExpMenuItemWord.BackColor = settings.ColorButSet;
            ExportContextMenu.BackColor = settings.ColorButSet;

            lblCaption.Font = new Font(font, settings.SizeFontSet);
            lblPeriodOutput.Font = new Font(font, settings.SizeFontSet);
            lblTitle.Font = new Font(font, settings.SizeFontSet);

            lblTitle.ForeColor = settings.ColorFontLblSet;
            lblCaption.ForeColor = settings.ColorFontLblSet;
            lblPeriodOutput.ForeColor = settings.ColorFontLblSet;

            txtCaption.BorderColor = settings.ColorTextBoxSet;
            txtCaption.BorderFocusColor = settings.ColorTxtFocus;
            txtCaption.ForeColor = settings.ColorFontLblSet;

            txtPeriodOutput.BorderColor = settings.ColorTextBoxSet;
            txtPeriodOutput.BorderFocusColor = settings.ColorTxtFocus;
            txtPeriodOutput.ForeColor = settings.ColorFontLblSet;

            txtPress.BorderColor = settings.ColorTextBoxSet;
            txtPress.BorderFocusColor = settings.ColorTxtFocus;
            txtPress.BackColor = settings.ColorPanelSet;
            txtPress.ForeColor = settings.ColorFontLblSet;

            pageMain.BackColor = settings.ColorPanelSet;
            pageSettings.BackColor = settings.ColorPanelSet;
            BackColor = settings.ColorPanelSet;
        }

        private void btnLoadPress_Click(object sender, EventArgs e)
        {
            counter++; counterLoad++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterLoad = counterLoad;
            IPressView pressView = this;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            IPressRepository pressRepository = new CPressRepository(sqlConnectionString);
            new PressPresenter(pressView, pressRepository);

            Logger logger = new Logger();
            logger.Log("Загрузка из бд", "Press.cs", "btnLoadPress", "222");
        }

        private void btnExportPress_Click(object sender, EventArgs e)
        {
            counter++; counterExport++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterExport = counterExport;
            ExportContextMenu.Show();

            Logger logger = new Logger();
            logger.Log("Экспорт", " Press.cs", " btnExportPress", "236");
        }

        private void ExpMenuItemExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.excelExport(gridPress);

            Logger logger = new Logger();
            logger.Log("Экспорт в Excel", " Press.cs", " ExpMenuItemExcel", "247");
        }

        private void ExpMenuItemWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            WordExport wordExport = new WordExport();

            save.Filter = "Word документы (*.doc)|*.doc";
            save.FileName = "";

            if (save.ShowDialog() == DialogResult.OK)
                wordExport.wordExport(gridPress, save.FileName);

            Logger logger = new Logger();
            logger.Log("Экспорт в Word", " Press.cs", " ExpMenuItemWord", "256");
        }
    }
}
