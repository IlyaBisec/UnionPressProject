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
    public partial class PeriodPress : Form, IPeriodView
    {
        public PeriodPress()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlPeriod.TabPages.Remove(pageSettings);
        }

        public string periodSrokSubscribe
        {
            get { return txtSrok.Texts; }
            set { txtSrok.Texts = value; }
        }
        public string periodSell
        {
            get { return txtSell.Texts; }
            set { txtSell.Texts = value; }
        }
        public string periodTransferChoice
        {
            get { return txtChoiceTransp.Texts; }
            set { txtChoiceTransp.Texts = value; }
        }
        public string periodPopularity
        {
            get { return txtPopularity.Texts; }
            set { txtPopularity.Texts = value; }
        }
        public string SearchValue
        {
            get { return txtPeriod.Texts; }
            set { txtPeriod.Texts = value; }
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

        public void SetPeriodListBindingSource(BindingSource periodList)
        {
            gridPeriod.DataSource = periodList;
        }

        private void PeriodPress_Load(object sender, EventArgs e)
        {
            ColorSet();
            Logger logger = new Logger();
            logger.Log("Открытие формы", "PeriodForm.cs", "PeriodPress", "92");
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            string font = "Archive";

            btnAddPeriod.BackColor = settings.ColorButSet;
            btnEditPeriod.BackColor = settings.ColorButSet;
            btnDelPeriod.BackColor = settings.ColorButSet;
            btnExportPeriod.BackColor = settings.ColorButSet;

            ExpMenuItemExcel.BackColor = settings.ColorButSet;
            ExpMenuItemWord.BackColor = settings.ColorButSet;
            ExportContextMenu.BackColor = settings.ColorButSet;

            btnLoadPeriod.BackColor = settings.ColorButSet;
            btnSearchPeriod.BackColor = settings.ColorButSet;
            btnSaveSettings.BackColor = settings.ColorButSet;
            btnCancelSettings.BackColor = settings.ColorButSet;

            lblChoiceTransp.Font = new Font(font, settings.SizeFontSet);
            lblPopularity.Font = new Font(font, settings.SizeFontSet);
            lblSell.Font = new Font(font, settings.SizeFontSet);
            lblSrok.Font = new Font(font, settings.SizeFontSet);
            lblTitle.Font = new Font(font, settings.SizeFontSet);

            lblChoiceTransp.ForeColor = settings.ColorFontLblSet;
            lblPopularity.ForeColor = settings.ColorFontLblSet;
            lblTitle.ForeColor = settings.ColorFontLblSet;
            lblSell.ForeColor = settings.ColorFontLblSet;
            lblSrok.ForeColor = settings.ColorFontLblSet;

            txtPeriod.BorderColor = settings.ColorTextBoxSet;
            txtPeriod.BorderFocusColor = settings.ColorTxtFocus;
            txtPeriod.BackColor = settings.ColorPanelSet;
            txtPeriod.ForeColor = settings.ColorFontLblSet;

            txtSrok.BorderColor = settings.ColorTextBoxSet;
            txtSrok.BorderFocusColor = settings.ColorTxtFocus;
            txtSrok.ForeColor = settings.ColorFontLblSet;
            txtSrok.BackColor = settings.ColorPanelSet;

            txtSell.BorderColor = settings.ColorTextBoxSet;
            txtSell.BorderFocusColor = settings.ColorTxtFocus;
            txtSell.ForeColor = settings.ColorFontLblSet;
            txtSell.BackColor = settings.ColorPanelSet;

            txtChoiceTransp.BorderColor = settings.ColorTextBoxSet;
            txtChoiceTransp.BorderFocusColor = settings.ColorTxtFocus;
            txtChoiceTransp.ForeColor = settings.ColorFontLblSet;
            txtChoiceTransp.BackColor = settings.ColorPanelSet;

            txtPopularity.ForeColor = settings.ColorFontLblSet;
            txtPopularity.BorderColor = settings.ColorTextBoxSet;
            txtPopularity.BorderFocusColor = settings.ColorTxtFocus;
            txtPopularity.BackColor = settings.ColorPanelSet;

            pageMain.BackColor = settings.ColorPanelSet;
            pageSettings.BackColor = settings.ColorPanelSet;
            BackColor = settings.ColorPanelSet;
        }

        private void AssociateAndRaiseViewEvents()
        {
            Logger logger = new Logger();
            //Поиск
            btnSearchPeriod.Click += delegate { SearchDataEvent?.Invoke(this, EventArgs.Empty); };
            txtPeriod.KeyDown += (s, e) =>
            {
                counter++; searchCount++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CountSearchClick = searchCount;
                if (e.KeyCode == Keys.Enter)
                    SearchDataEvent?.Invoke(this, EventArgs.Empty);
   
                logger.Log("Поиск", "PeriodForm.cs", "btnSearchPeriod", "160");

            };
            //Добавить
            btnAddPeriod.Click += delegate
            {
                counter++; counterAdd++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterAdd = counterAdd;
                AddNewDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlPeriod.TabPages.Remove(pageMain);
                tabControlPeriod.TabPages.Add(pageSettings);
                pageSettings.Text = "Добавление нового периодического издания";
               
                logger.Log("Добавление", "PeriodForm.cs", "btnAddPeriod", "174");
            };
            //Изменить
            btnEditPeriod.Click += delegate
            {
                counter++; counterEdit++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterEdit = counterEdit;
                EditDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlPeriod.TabPages.Remove(pageMain);
                tabControlPeriod.TabPages.Add(pageSettings);
                pageSettings.Text = "Изменение периодического издания";

                logger.Log("Редактирование", "PeriodForm.cs", "btnEditPeriod", "188");
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
                    tabControlPeriod.TabPages.Remove(pageSettings);
                    tabControlPeriod.TabPages.Add(pageMain);
                }
                MessageBox.Show(Message);


                logger.Log("Сохранение", "PeriodForm.cs", "btnSaveSettings", "201");
            };
            //Отмена
            btnCancelSettings.Click += delegate
            {
                counter++; counterDelete++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterDelete = counterDelete;
                counter++; counterBack++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterBack = counterBack;
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlPeriod.TabPages.Remove(pageSettings);
                tabControlPeriod.TabPages.Add(pageMain);

                logger.Log("Отмена", "PeriodForm.cs", "btnCancelSettings", "218");
            };
            //Удалить
            btnDelPeriod.Click += delegate
            {
                var result = MessageBox.Show("удалить выбранное периодическое издание?", "Внимание",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDataEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
                logger.Log("Удаление", "PeriodForm.cs", "btnDelPeriod", "233");
            };

        }

        private void btnLoadPeriod_Click(object sender, EventArgs e)
        {
            counter++; counterLoad++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterLoad = counterLoad;
            IPeriodView periodView = this;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            IPeriodRepository periodRepository  = new CPeriodRepository(sqlConnectionString);
            new PeriodPresenter(periodView, periodRepository);

            Logger logger = new Logger();
            logger.Log("Загрузка из бд", "PeriodForm.cs", "btnLoadPeriod", "247");
        }

        private void btnExportPeriod_Click(object sender, EventArgs e)
        {
            ExportContextMenu.Show();
            counter++; counterExport++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterExport = counterExport;

            Logger logger = new Logger();
            logger.Log("Экспорт", "PeriodForm.cs", "btnExportPeriod", "261");
        }

        private void ExpMenuItemExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.excelExport(gridPeriod);

            Logger logger = new Logger();
            logger.Log("Экспорт в Excel", "PeriodForm.cs", "ExpMenuItemExcel", "272");
        }

        private void ExpMenuItemWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            WordExport wordExport = new WordExport();

            save.Filter = "Word документы (*.doc)|*.doc";
            save.FileName = "";

            if (save.ShowDialog() == DialogResult.OK)
                wordExport.wordExport(gridPeriod, save.FileName);

            Logger logger = new Logger();
            logger.Log("Экспорт в Word", "PeriodForm.cs", "ExpMenuItemWord", "281");
        }
    }
}
