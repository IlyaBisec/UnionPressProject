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
    public partial class Transporter : Form, ITransportView
    {
        public Transporter()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlTransporter.TabPages.Remove(pageSettings);
        }

        public string DataBegin
        {
            get { return txtBeginDate.Texts; }
            set { txtBeginDate.Texts = value; }
        }
        public string DataEnd
        {
            get { return txtEndDate.Texts; }
            set { txtEndDate.Texts = value; }
        }
        public string SearchValue
        {
            get { return txtSearchTransporter.Texts; }
            set { txtSearchTransporter.Texts = value; }
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

        public void SetTransportListBindingSource(BindingSource transportList)
        {
            gridTransporter.DataSource = transportList;
        }

        private void btnUpdateTr_Click(object sender, EventArgs e)
        {
            
        }

        private void Transporter_Load(object sender, EventArgs e)
        {
            ColorSet();
            Logger logger = new Logger();
            logger.Log("Открытие формы", " Transporter.cs", " TransporterLoad", "86");
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            string font = "Archive";

            btnAddTransporter.BackColor = settings.ColorButSet;
            btnDelTransporter.BackColor = settings.ColorButSet;
            btnEditTransporter.BackColor = settings.ColorButSet;
            btnLoadTransporter.BackColor = settings.ColorButSet;
            btnSearchTransporter.BackColor = settings.ColorButSet;

            btnExportTransporter.BackColor = settings.ColorButSet;
            ExpMenuItemExcel.BackColor = settings.ColorButSet;
            ExpMenuItemWord.BackColor = settings.ColorButSet;
            ExportContextMenu.BackColor = settings.ColorButSet;

            btnSaveSettings.BackColor = settings.ColorButSet;
            btnCancelSettings.BackColor = settings.ColorButSet;

            lblBeginDate.Font = new Font(font, settings.SizeFontSet);
            lblEndDate.Font = new Font(font, settings.SizeFontSet);
            lblTitle.Font = new Font(font, settings.SizeFontSet);

            lblTitle.ForeColor = settings.ColorFontLblSet;
            lblBeginDate.ForeColor = settings.ColorFontLblSet;
            lblEndDate.ForeColor = settings.ColorFontLblSet;

            txtBeginDate.BorderColor = settings.ColorTextBoxSet;
            txtBeginDate.BorderFocusColor = settings.ColorTxtFocus;
            txtBeginDate.ForeColor = settings.ColorFontLblSet;
            txtBeginDate.BackColor = settings.ColorPanelSet;

            txtEndDate.BorderColor = settings.ColorTextBoxSet;
            txtEndDate.ForeColor = settings.ColorFontLblSet;
            txtEndDate.BorderFocusColor = settings.ColorTxtFocus;
            txtEndDate.BackColor = settings.ColorPanelSet;

            txtSearchTransporter.BorderColor = settings.ColorTextBoxSet;
            txtSearchTransporter.BorderFocusColor = settings.ColorTxtFocus;
            txtSearchTransporter.BackColor = settings.ColorPanelSet;
            txtSearchTransporter.ForeColor = settings.ColorFontLblSet;

            pageMain.BackColor = settings.ColorPanelSet;
            pageSettings.BackColor = settings.ColorPanelSet;

            BackColor = settings.ColorPanelSet;
        }

        private void AssociateAndRaiseViewEvents()
        {
            Logger logger = new Logger();
            //Поиск
            btnSearchTransporter.Click += delegate { SearchDataEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchTransporter.KeyDown += (s, e) =>
            {
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CountSearchClick = searchCount;
                if (e.KeyCode == Keys.Enter)
                    SearchDataEvent?.Invoke(this, EventArgs.Empty);

                logger.Log("Поиск", " Transporter.cs", " btnSearchTransporter", "146");
            };
            //Добавить
            btnAddTransporter.Click += delegate
            {
                counter++; counterAdd++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterAdd = counterAdd;
                AddNewDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlTransporter.TabPages.Remove(pageMain);
                tabControlTransporter.TabPages.Add(pageSettings);
                pageSettings.Text = "Добавление новой доставки";

                logger.Log("Добавить", " Transporter.cs", " btnAddTransporter", "157");
            };
            //Изменить
            btnEditTransporter.Click += delegate
            {
                counter++; counterEdit++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterEdit = counterEdit;
                EditDataEvent?.Invoke(this, EventArgs.Empty);
                tabControlTransporter.TabPages.Remove(pageMain);
                tabControlTransporter.TabPages.Add(pageSettings);
                pageSettings.Text = "Изменение доставки";

                logger.Log("Изменение", " Transporter.cs", " btnEditTransporter", "170");
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
                    tabControlTransporter.TabPages.Remove(pageSettings);
                    tabControlTransporter.TabPages.Add(pageMain);
                }
                MessageBox.Show(Message);

                logger.Log("Сохранение", " Transporter.cs", " btnSaveSettings", "183");
            };
            //Отмена
            btnCancelSettings.Click += delegate
            {
                counter++; counterBack++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterBack = counterBack;
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlTransporter.TabPages.Remove(pageSettings);
                tabControlTransporter.TabPages.Add(pageMain);

                logger.Log("Отмена", " Transporter.cs", " btnCancelSettings", "199");
            };
            //Удалить
            btnDelTransporter.Click += delegate
            {
                counter++; counterDelete++;
                Properties.Settings.Default.CountBtnClick = counter;
                Properties.Settings.Default.CounterDelete = counterDelete;
                var result = MessageBox.Show("удалить выбранную доставку?", "Внимание",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDataEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
                logger.Log("Удалить", " Transporter.cs", " btnDelTransporter", "211");
            };

        }

        private void btnLoadTransporter_Click(object sender, EventArgs e)
        {
            counter++; counterLoad++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterLoad = counterLoad;
            ITransportView transportView = this;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            ITransportRepository transportRepository = new CTransportRepository(sqlConnectionString);
            new TransportPresenter(transportView, transportRepository);

            Logger logger = new Logger();
            logger.Log("Загрузка из бд", " Transporter.cs", " btnLoadTransporter", "228");
        }

        private void btnExportTransporter_Click(object sender, EventArgs e)
        {
            counter++; counterExport++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterExport = counterExport;
            ExportContextMenu.Show();

            Logger logger = new Logger();
            logger.Log("Экспорт", " Transporter.cs", " btnExportTransporter", "242");
        }

        private void ExpMenuItemExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.excelExport(gridTransporter);

            Logger logger = new Logger();
            logger.Log("Экспорт в Excel", " Transporter.cs", " ExpMenuItemExcel", "253");
        }

        private void ExpMenuItemWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            WordExport wordExport = new WordExport();

            save.Filter = "Word документы (*.doc)|*.doc";
            save.FileName = "";

            if (save.ShowDialog() == DialogResult.OK)
                wordExport.wordExport(gridTransporter, save.FileName);

            Logger logger = new Logger();
            logger.Log("Экспорт в Word", " Transporter.cs", " ExpMenuItemWord", "262");
        }
    }
}
