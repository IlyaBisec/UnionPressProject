using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Models;
using UnionPressOnSharp.Forms.Presenters;
using UnionPressOnSharp.Forms.Repositories;
using UnionPressOnSharp.Forms.Views;
using System.Configuration;
using UnionPressOnSharp.Forms.Exports;
using UnionPressOnSharp.Forms.Classes;

namespace UnionPressOnSharp.Forms
{
    public partial class TypePress : Form, ITypeView
    {
        public TypePress()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlType.TabPages.Remove(pageSettings);
        }

        public string SearchValue
        {
            get { return txtType.Texts; }
            set { txtType.Texts = value; }
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
        public string TypePresss
        {
            get { return txtSettingsType.Texts; }
            set { txtSettingsType.Texts = value; }
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


        public void SetTypeListBindingSource(BindingSource typeList)
        {
            gridType.DataSource = typeList;
        }

        private void TypePress_Load(object sender, EventArgs e)
        {
            ColorSet();
            Logger logger = new Logger();
            logger.Log("Открытие формы", " TypePress.cs", " TransporterLoad", "78");
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            string font = "Archive";

            btnAddType.BackColor = settings.ColorButSet;
            btnDelType.BackColor = settings.ColorButSet;
            btnEditType.BackColor = settings.ColorButSet;
            btnLoadType.BackColor = settings.ColorButSet;
            btnSearchType.BackColor = settings.ColorButSet;
            btnExportType.BackColor = settings.ColorButSet;

            btnSaveSettings.BackColor = settings.ColorButSet;
            btnCancelSettings.BackColor = settings.ColorButSet;

            ExportContextMenu.BackColor = settings.ColorButSet;
            ExpMenuItemWord.BackColor = settings.ColorButSet;
            ExpMenuItemExcel.BackColor = settings.ColorButSet;

            lblType.Font = new Font(font, settings.SizeFontSet);
            lblTitle.Font = new Font(font, settings.SizeFontSet);

            lblTitle.ForeColor = settings.ColorFontLblSet;
            lblType.ForeColor = settings.ColorFontLblSet;

            txtSettingsType.BorderColor = settings.ColorTextBoxSet;
            txtSettingsType.BorderFocusColor = settings.ColorTxtFocus;
            txtSettingsType.ForeColor = settings.ColorFontLblSet;
            txtSettingsType.BackColor = settings.ColorPanelSet;

            txtType.BorderColor = settings.ColorTextBoxSet;
            txtType.BorderFocusColor = settings.ColorTxtFocus;
            txtType.BackColor = settings.ColorPanelSet;
            txtType.ForeColor = settings.ColorFontLblSet;


            pageMain.BackColor = settings.ColorPanelSet;
            pageSettings.BackColor = settings.ColorPanelSet;
            BackColor = settings.ColorPanelSet;
        }
        private void AssociateAndRaiseViewEvents()
        {
            Logger logger = new Logger();
            //Поиск
            btnSearchType.Click += delegate { SearchDataEvent?.Invoke(this, EventArgs.Empty); };
            txtType.KeyDown += (s, e) =>
            {
                counter++; searchCount++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CountSearchClick = searchCount;
                if (e.KeyCode == Keys.Enter)
                    SearchDataEvent?.Invoke(this, EventArgs.Empty);
                logger.Log("Поиск", " TypePress.cs", " btnSearchType", "125");
            };
            //Добавить
            btnAddType.Click += delegate
            {
                counter++; counterAdd++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterAdd = counterAdd;
                AddNewDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlType.TabPages.Remove(pageMain);
                tabControlType.TabPages.Add(pageSettings);
                pageSettings.Text = "Добавление нового типа печати";
                logger.Log("Добавить", " TypePress.cs", " btnAddType", "140");
            };
            //Изменить
            btnEditType.Click += delegate
            {
                counter++; counterEdit++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterEdit = counterEdit;
                EditDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlType.TabPages.Remove(pageMain);
                tabControlType.TabPages.Add(pageSettings);
                pageSettings.Text = "Изменение типа печати";
                logger.Log("Изменить", " TypePress.cs", " btnEditType", "152");
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
                    tabControlType.TabPages.Remove(pageSettings);
                    tabControlType.TabPages.Add(pageMain);
                }
                MessageBox.Show(Message);
                logger.Log("Сохранить", " TypePress.cs", " btnSaveSettings", "164");
            };
            //Отмена
            btnCancelSettings.Click += delegate
            {
                counter++; counterBack++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterBack = counterBack;
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlType.TabPages.Remove(pageSettings);
                tabControlType.TabPages.Add(pageMain);
                logger.Log("Отмена", " TypePress.cs", " btnCancelSettings", "179");
            };
            //Удалить
            btnDelType.Click += delegate
            {
                counter++; counterDelete++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterDelete = counterDelete;
                var result = MessageBox.Show("удалить выбранный тип?", "Внимание",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDataEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
                logger.Log("Удалить", " TypePress.cs", " btnDelType", "190");
            };

        }

        private void btnLoadType_Click(object sender, EventArgs e)
        {
            counter++; counterLoad++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterLoad = counterLoad;

            ITypeView typeView = this;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            ITypeRepository typeRepository = new CTypeRepository(sqlConnectionString);
            new TypePresenter(typeView, typeRepository);

            Logger logger = new Logger();
            logger.Log("Загрузка из бд", " TypePress.cs", " btnLoadType", "207");
        }

        private void btnExportType_Click(object sender, EventArgs e)
        {
            counter++; counterExport++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterExport = counterExport;
            ExportContextMenu.Show();

            Logger logger = new Logger();
            logger.Log("Экспорт", " TypePress.cs", " btnExportType", "222");
        }

        private void ExpMenuItemExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.excelExport(gridType);

            Logger logger = new Logger();
            logger.Log("Экспорт в Excel", " TypePress.cs", " ExpMenuItemExcel", "233");
        }

        private void ExpMenuItemWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            WordExport wordExport = new WordExport();

            save.Filter = "Word документы (*.doc)|*.doc";
            save.FileName = "";

            if (save.ShowDialog() == DialogResult.OK)
                wordExport.wordExport(gridType, save.FileName);

            Logger logger = new Logger();
            logger.Log("Экспорт в Word", " TypePress.cs", " ExpMenuItemWord", "242");
        }
    }
}
