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

namespace UnionPressOnSharp.Forms
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;

            BackColor = settings.ColorPanelSet;
            gridStatistics.BackgroundColor = settings.ColorPanelSet;
            gridStatistics.GridColor = settings.ColorPanelSet;
            gridStatistics.RowHeadersDefaultCellStyle.BackColor = settings.ColorPanelSet;
            gridStatistics.RowsDefaultCellStyle.BackColor = settings.ColorPanelSet;
            gridStatistics.DefaultCellStyle.BackColor = settings.ColorPanelSet;
            gridStatistics.ColumnHeadersDefaultCellStyle.BackColor = settings.ColorPanelSet;
            gridStatistics.AlternatingRowsDefaultCellStyle.BackColor = settings.ColorPanelSet;
            gridStatistics.RowHeadersVisible = false;

            string[] lblContent = {
                "Количество кликов по кнопкам",
                "Количество поисков",
                "Время проведенное в приложении",
                "Количество кликов по кнопке логотип",
                "Количество кликов по кнопке 'сотрудники'",
                "Количество кликов по кнопке 'доставка'",
                "Количество кликов по кнопке 'издания'",
                "Количество кликов по кнопке 'тип изданий'",
                "Количество кликов по кнопке 'период. изданий'",
                "Количество кликов по кнопке 'график'",
                "Количество кликов по кнопке настройки",
                "Количество кликов по кнопке статистика",
                "Количество кликов по кнопке выйти",
                "Количество кликов по кнопке войти",
                "Сколько раз менялся цвет текста",
                "Сколько раз менялся цвет окон",
                "Сколько раз менялся радиус границ окна",
                "Сколько раз менялся размер границ окна",
                "Сколько раз менялся фон приложения",
                "Сколько раз менялся размер текста",
                "Сколько раз менялся цвет текста на кнопках",
                "Сколько раз менялся цвет кнопок",
                "Сколько раз менялся цвет полей ввода",
                "количество кликов по кнопке 'Default'",
                "количество сбросов значений",
                "количество кликов на 'вкл перетаскивание'",
                "Количество кликов по кнопке загрузить",
                "Количество кликов по кнопке добавить",
                "Количество кликов по кнопке изменить",
                "Количество кликов по кнопке удалить",
                "Количество кликов по кнопке сохранить",
                "Количество кликов по кнопке назад",
                "Количество кликов по кнопке Экспорт"
            };

            if (settings.StyleIsSelect == true && settings.StyleIsSelect2 == false)
                gridStatistics.ForeColor = Color.FromArgb(30, 100, 200);
            else if (settings.StyleIsSelect == false && settings.StyleIsSelect2 == true)
                gridStatistics.ForeColor = Color.HotPink;


            foreach (string rowArray in lblContent)
            {
                gridStatistics.Rows.Add(rowArray);
            }
            gridStatistics.Rows.Add(settings.CountBtnClick);

            //Tables and panels forms
            #region Tables and panels forms
            gridStatistics.Rows[0].Cells[1].Value = settings.CountBtnClick;
            gridStatistics.Rows[1].Cells[1].Value = settings.CountSearchClick;
            gridStatistics.Rows[2].Cells[1].Value = settings.AppsTime;
            gridStatistics.Rows[3].Cells[1].Value = settings.CounterLogoMP;
            gridStatistics.Rows[4].Cells[1].Value = settings.CounterWorkers;
            gridStatistics.Rows[5].Cells[1].Value = settings.CounterDostavka;
            gridStatistics.Rows[6].Cells[1].Value = settings.CounterPress;
            gridStatistics.Rows[7].Cells[1].Value = settings.CounterTypePress;
            gridStatistics.Rows[8].Cells[1].Value = settings.CounterPeriodPress;
            gridStatistics.Rows[9].Cells[1].Value = settings.CounterGraphic;
            gridStatistics.Rows[10].Cells[1].Value = settings.CounterOptions;
            gridStatistics.Rows[11].Cells[1].Value = settings.CounterStatistics;
            gridStatistics.Rows[12].Cells[1].Value = settings.CounterExit;
            gridStatistics.Rows[13].Cells[1].Value = settings.CounterConnect;
            #endregion

            //options
            #region options
            gridStatistics.Rows[14].Cells[1].Value = settings.CounterColorText;
            gridStatistics.Rows[15].Cells[1].Value = settings.CounterColorBorder;
            gridStatistics.Rows[16].Cells[1].Value = settings.CounterBorderRadius;
            gridStatistics.Rows[17].Cells[1].Value = settings.CounterBorderSize;
            gridStatistics.Rows[18].Cells[1].Value = settings.CounterStyleSet;
            gridStatistics.Rows[19].Cells[1].Value = settings.CounterTextSize;
            gridStatistics.Rows[20].Cells[1].Value = settings.CounterColorTextBtn;
            gridStatistics.Rows[21].Cells[1].Value = settings.CounterColorBtnSet;
            gridStatistics.Rows[22].Cells[1].Value = settings.CounterColorTextBoxSet;
            gridStatistics.Rows[23].Cells[1].Value = settings.CounterDefaultClick;
            gridStatistics.Rows[24].Cells[1].Value = settings.CounterDropClick;
            gridStatistics.Rows[25].Cells[1].Value = settings.CounterToggleBtnMoving;
            #endregion

            //tables
            #region tables
            gridStatistics.Rows[26].Cells[1].Value = settings.CounterLoad;
            gridStatistics.Rows[27].Cells[1].Value = settings.CounterAdd;
            gridStatistics.Rows[28].Cells[1].Value = settings.CounterEdit;
            gridStatistics.Rows[29].Cells[1].Value = settings.CounterDelete;
            gridStatistics.Rows[30].Cells[1].Value = settings.CounterSave;
            gridStatistics.Rows[31].Cells[1].Value = settings.CounterBack;
            gridStatistics.Rows[32].Cells[1].Value = settings.CounterExport;
            #endregion

            Logger logger = new Logger();
            logger.Log("Загрузка формы", " Statistics.cs", " Statistics_Load", "21");
        }




        #region labels Methods
        private void label2_Click(object sender, EventArgs e)
        {
  
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label2); Emission(label27);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //label2.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label27.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label1); Emission(label28);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            //label1.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label28.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label4); Emission(label30);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            //label4.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label30.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label3); Emission(label29);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            //label3.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label29.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label6); Emission(label34);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            //label6.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label34.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label5); Emission(label33);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            //label5.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label33.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label16); Emission(label32);
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            //label16.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label32.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label15); Emission(label31);
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            //label15.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label31.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label14); Emission(label43);
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            //label14.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label43.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label23); Emission(label42);
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            //label23.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label42.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label22); Emission(label41);
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            //label22.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label41.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label21); Emission(label40);
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            //label21.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label40.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label20); Emission(label39);
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            //label20.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label39.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label19); Emission(label38);
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            //label19.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label38.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label26); Emission(label37);
        }
    

        private void label26_MouseLeave(object sender, EventArgs e)
        {
            //label26.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label37.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label18); Emission(label36);
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            //label18.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label36.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label17); Emission(label35);
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            //label17.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label35.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }
        private void label25_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label25); Emission(label44);
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            //label25.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label44.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label24); Emission(label45);
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            //label24.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label45.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label13); Emission(label46);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            //label13.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label46.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label10); Emission(label47);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            //label10.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label47.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label9); Emission(label48);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            //label9.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label48.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label8); Emission(label49);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            //label8.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label49.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            //Emission(label7); Emission(label50);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            //label7.ForeColor = Properties.Settings.Default.ColorFontLblSet;
            //label50.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }
        #endregion

      

        private void gridStatistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var settings = Properties.Settings.Default;
            //if (settings.StyleIsSelect == true && settings.StyleIsSelect2 == false)
            //{
            //    //gridStatistics.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 100, 200);
            //    //gridStatistics.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 100, 200);
            //    gridStatistics.Rows[gridStatistics.CurrentRow.Index].DefaultCellStyle.SelectionForeColor = Color.Red;
            //}
            //else if (settings.StyleIsSelect == false && settings.StyleIsSelect2 == true)
            //{
            //    //gridStatistics.RowsDefaultCellStyle.SelectionForeColor = Color.HotPink;
            //    //gridStatistics.RowHeadersDefaultCellStyle.SelectionForeColor = Color.HotPink;
            //    gridStatistics.Rows[gridStatistics.CurrentRow.Index].DefaultCellStyle.SelectionForeColor = Color.Red;
            //}
        }

        private void gridStatistics_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var settings = Properties.Settings.Default;
            if (settings.StyleIsSelect == true && settings.StyleIsSelect2 == false)
            {
                gridStatistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStatistics.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 100, 200);
            }
            else if (settings.StyleIsSelect == false && settings.StyleIsSelect2 == true)
            {
                gridStatistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStatistics.RowsDefaultCellStyle.SelectionForeColor = Color.HotPink;
            }
        }

        private void gridStatistics_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            gridStatistics.ForeColor = Properties.Settings.Default.ColorFontLblSet;
        }
    }
}
