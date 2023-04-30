using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Classes;

namespace UnionPressOnSharp.Forms
{
    public partial class Options : Form
    {
        private string font = "Archive";
        private int counter = 0, counterTextColor = 0,
                    counterBorderColor = 0, counterBorderRadius = 0,
                    counterBorderSize = 0,  counterStylesSet = 0,
                    counterTextSize = 0,    counterBtnTextColor = 0,
                    counterBtnColor = 0,    counterTextBoxColor = 0,
                    counterDefaultClick = 0, counterDropClick = 0,
                    counterToggleMoving = 0;
        public Options()
        {
            InitializeComponent();
        }
        private RadioButton currentButton;

        #region Condition
        private void ActiveButton(object btnSender, Color color)
        {
            if (btnSender != null)
            {
                if (currentButton != (RadioButton)btnSender)
                {
                    currentButton = (RadioButton)btnSender;
                    currentButton.FlatAppearance.BorderColor = color;
                    currentButton.FlatAppearance.BorderSize = 2;
                }

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelStyles.Controls)
            {
                if (previousBtn.GetType() == typeof(RadioButton))
                {
                    currentButton.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void ifRadioButton(RadioButton radioButton, object sender, Color color)
        {
            if (radioButton.Checked == true)
                ActiveButton(sender, color);

            else
                DisableButton();

        }
        #endregion

        #region styles
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            counterStylesSet++;
            var settings = Properties.Settings.Default;
            settings.CounterStyleSet = counterStylesSet;
            Color classicColor = Color.FromArgb(30, 100, 200);
            ifRadioButton(rdBtnStyleClassic, sender, classicColor);
            //стиль классический белый + синий
            if (rdBtnStyleClassic.Checked == true && rdBtnStyleNight.Checked != true)
            {
               
                settings.ColorButSet = classicColor;
                settings.ColorTextBoxSet = classicColor;
                settings.ColorBorderSet = classicColor;

                btnDefWinBorderColor.BackColor = classicColor;
                btnDefFontColor.BackColor = classicColor;
                btnDefAllFontColor.BackColor = classicColor;
                btnDefBtnColor.BackColor = classicColor;
                btnDefTextBoxColor.BackColor = classicColor;

                settings.ColorTxtFocus = Color.Red;

                settings.ColorFontBtnSet = Color.Gainsboro;
                btnDefFontColor.TextColor = Color.Gainsboro;

                settings.ColorFontLblSet = Color.Black;
                settings.ColorPanelSet = Color.White;

                toggleBtnMoving.OnBackColor = settings.ColorButSet;

                settings.SizeFontSet = 10;

                trackBarFontSize.BackColor = Color.White;
                trackBarRadWinBorder.BackColor = Color.White;
                trackBarSizeWinBorder.BackColor = Color.White;

                settings.StyleIsSelect = true;

                settings.Save();
            }
            else
            {
                settings.StyleIsSelect = false;
                settings.Save();
            }
            Logger logger = new Logger();
            logger.Log("Установка классического стиля", "Options.cs", "radbtnClassic", "73");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            counterStylesSet++;
            var settings = Properties.Settings.Default;
            settings.CounterStyleSet = counterStylesSet;
            Color nightColor = Color.MediumPurple;
            ifRadioButton(rdBtnStyleNight, sender, nightColor);
            //стиль современный темный + фиолетово-розовый градиент
            if (rdBtnStyleNight.Checked == true && rdBtnStyleClassic.Checked == false)
            {
              
                settings.ColorButSet = nightColor;
                settings.ColorTextBoxSet = nightColor;
                settings.ColorBorderSet = nightColor;
                settings.ColorTxtFocus = Color.HotPink;

                btnDefWinBorderColor.BackColor = nightColor;
                btnDefFontColor.BackColor = nightColor;
                btnDefAllFontColor.BackColor = nightColor;
                btnDefBtnColor.BackColor = nightColor;
                btnDefTextBoxColor.BackColor = nightColor;

                settings.ColorBorderSet = Color.FromArgb(51, 51, 70);

                settings.ColorFontBtnSet = Color.White;
                btnDefFontColor.TextColor = Color.White;

                settings.ColorFontLblSet = nightColor;
                settings.ColorPanelSet = Color.FromArgb(51, 51 ,70);

                toggleBtnMoving.OnBackColor = settings.ColorButSet;

                trackBarFontSize.BackColor = Color.FromArgb(51, 51, 70);
                trackBarRadWinBorder.BackColor = Color.FromArgb(51, 51, 70);
                trackBarSizeWinBorder.BackColor = Color.FromArgb(51, 51, 70);

                settings.SizeFontSet = 10;


                settings.StyleIsSelect2 = true;

                settings.Save();
            }
            else
            {
                settings.StyleIsSelect2 = false;
                settings.Save();
            }
            Logger logger = new Logger();
            logger.Log("Установка ночного стиля", "Options.cs", "radbtnNight", "123");
        }
        #endregion

        #region Loading components
        private void Options_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            BackColor = settings.ColorPanelSet;

            btnButtonColor.BackColor = settings.ColorButSet;
            btnDropOptions.BackColor = settings.ColorButSet;
            btnAboutA.BackColor = settings.ColorButSet;
            btnColorWinBorder.BackColor = settings.ColorBorderSet;
            btnColorWinFont.BackColor = settings.ColorFontBtnSet;
            btnColorAllFontColor.BackColor = settings.ColorFontLblSet;
            btnTextBoxColor.BackColor = settings.ColorTextBoxSet;
           
            btnDropOptions.TextColor = settings.ColorFontBtnSet;
            btnAboutA.TextColor = settings.ColorFontBtnSet;

            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(@"D:\Для Баргу\Курсачи\Курсовая работа 4 семестр(2 курс)\UnionPressOnSharp\UnionPressOnSharp\Interface\Fonts\Archive.ttf");


            label1.ForeColor = settings.ColorFontLblSet;
            label2.ForeColor = settings.ColorFontLblSet;
            label3.ForeColor = settings.ColorFontLblSet;
            label4.ForeColor = settings.ColorFontLblSet;
            label5.ForeColor = settings.ColorFontLblSet;
            label6.ForeColor = settings.ColorFontLblSet;
            label7.ForeColor = settings.ColorFontLblSet;
            label8.ForeColor = settings.ColorFontLblSet;
            label9.ForeColor = settings.ColorFontLblSet;
            label10.ForeColor = settings.ColorFontLblSet;

            label1.Font = new Font(font, settings.SizeFontSet);
            label2.Font = new Font(font, settings.SizeFontSet);
            label3.Font = new Font(font, settings.SizeFontSet);
            label4.Font = new Font(font, settings.SizeFontSet);
            label5.Font = new Font(font, settings.SizeFontSet);
            label6.Font = new Font(font, settings.SizeFontSet);
            label7.Font = new Font(font, settings.SizeFontSet);
            label8.Font = new Font(font, settings.SizeFontSet);
            label9.Font = new Font(font, settings.SizeFontSet);
            label10.Font = new Font(font, settings.SizeFontSet);

            rdBtnStyleClassic.Checked = settings.StyleIsSelect;
            rdBtnStyleNight.Checked = settings.StyleIsSelect2;

            toggleBtnMoving.Checked = settings.IsMoving;

            trackBarFontSize.Value = settings.SizeFontSet;

            trackBarSizeWinBorder.Value = settings.SizeWinBorder;
            trackBarRadWinBorder.Value = settings.RadiusWinBorder;

            Logger logger = new Logger();
            logger.Log("Откытие насроек", "Options.cs", "OptionsLoad", "177");

        }
      
        

        //private void Fonts_Load()
        //{
        //    PrivateFontCollection pfc = new PrivateFontCollection();
        //     pfc.AddFontFile(@"D:\Для Баргу\Курсачи\Курсовая работа 4 семестр(2 курс)\UnionPressOnSharp\UnionPressOnSharp\Interface\Fonts\Archive.ttf");
            
        //    label1.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label2.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label3.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label4.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label5.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label6.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label7.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label8.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label9.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        //    label10.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);



        //    btnAboutA.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnButtonColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnColorWinBorder.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnColorWinFont.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnDropOptions.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnTextBoxColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnColorAllFontColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);

        //    btnDefAllFontColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnDefBtnColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnDefFontColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnDefTextBoxColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
        //    btnDefWinBorderColor.Font = new Font(pfc.Families[0], btnFontSizeOnDefault, FontStyle.Regular);
            

        //}

        #endregion

        #region buttons
        private void btnAbout_Click(object sender, EventArgs e)
        {
            counter++;
            Properties.Settings.Default.CountBtnClick = counter;
            AboutAuthor aboutAuthor = new AboutAuthor();
            aboutAuthor.Show();

            Logger logger = new Logger();
            logger.Log("клик по кнопке об авторе(обо мне кто-то спрашивает?)", "Options.cs", "btnAbout", "274");

        }

        private void btnColorWinBorder_Click(object sender, EventArgs e)
        {
            counter++; counterBorderColor++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterColorBorder = counterBorderColor;
            if (Palitra.ShowDialog() == DialogResult.OK)
            {
                btnColorWinBorder.BackColor = Palitra.Color;
                btnColorWinBorder.Text = "";
                Properties.Settings.Default.ColorBorderSet = Palitra.Color;
                //btnColorWinBorder.Text = Palitra.Color.ToString();
            }
            Logger logger = new Logger();
            logger.Log("Установка цвета границ окна", "Options.cs", "btnColorWinBorder", "286");
        }

        private void btnColorWinFont_Click(object sender, EventArgs e)
        {
            counter++; counterBtnTextColor++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterColorTextBtn = counterBtnTextColor;
            if (Palitra2.ShowDialog() == DialogResult.OK)
            {
                btnColorWinFont.BackColor = Palitra2.Color;
                btnColorWinFont.Text = "";
              //  btnColorWinFont.Text = Palitra2.Color.ToString();

                Properties.Settings.Default.ColorFontBtnSet = Palitra2.Color;
                Properties.Settings.Default.Save();

                btnDropOptions.TextColor = Palitra2.Color;
                btnAboutA.TextColor = Palitra2.Color;
                btnColorWinBorder.TextColor = Palitra2.Color;
                btnButtonColor.TextColor = Palitra2.Color;
                btnColorAllFontColor.TextColor = Palitra2.Color;
            }
            Logger logger = new Logger();
            logger.Log("Установка цвета текста", "Options.cs", "btnColorWinFont", "302");
        }

        private void btnButtonColor_Click(object sender, EventArgs e)
        {
            counter++; counterBtnColor++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterColorBtnSet = counterBtnColor;
            if (Palitra3.ShowDialog() == DialogResult.OK)
            {
                btnButtonColor.BackColor = Palitra3.Color;
                btnButtonColor.Text = "";
                //btnButtonColor.Text = Palitra3.Color.ToString();

                Properties.Settings.Default.ColorButSet = Palitra3.Color;
                Properties.Settings.Default.Save();

                btnDropOptions.BackColor = Palitra3.Color;
                btnAboutA.BackColor = Palitra3.Color;

            }
            Logger logger = new Logger();
            logger.Log("Установка цвета кнопок", "Options.cs", "btnButtonColor", "326");
        }

        private void btnColorAllFontColor_Click(object sender, EventArgs e)
        {
            counter++; counterTextColor++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterColorText = counterTextColor;
            if (Palitra4.ShowDialog() == DialogResult.OK)
            {
                btnColorAllFontColor.BackColor = Palitra4.Color;
                btnColorAllFontColor.Text = "";
               // btnColorAllFontColor.Text = Palitra4.Color.ToString();

                Properties.Settings.Default.ColorFontLblSet = Palitra4.Color;
                Properties.Settings.Default.Save();


                label1.ForeColor = Palitra4.Color;
                label2.ForeColor = Palitra4.Color;
                label3.ForeColor = Palitra4.Color;
                label4.ForeColor = Palitra4.Color;
                label5.ForeColor = Palitra4.Color;
                label6.ForeColor = Palitra4.Color;
                label7.ForeColor = Palitra4.Color;
                label8.ForeColor = Palitra4.Color;
                label9.ForeColor = Palitra4.Color;
                label10.ForeColor = Palitra4.Color;
            }

            Logger logger = new Logger();
            logger.Log("Установка цвета текста на форме", "Options.cs", "btnColorAllFontColor", "348");
        }

        private void btnTextBoxColor_Click(object sender, EventArgs e)
        {
            counter++; counterTextBoxColor++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterColorTextBoxSet = counterTextBoxColor;
            if (Palitra5.ShowDialog() == DialogResult.OK)
            {

                btnTextBoxColor.Text = Palitra5.Color.ToString();

                Properties.Settings.Default.ColorTextBoxSet = Palitra5.Color;
                Properties.Settings.Default.Save();

            }

            Logger logger = new Logger();
            logger.Log("Установка цвета полей ввода", "Options.cs", "btnTextBoxColor", "379");
        }

        private void btnDropOptions_Click(object sender, EventArgs e)
        {
            counter++; counterDropClick++;

            var settings = Properties.Settings.Default;

            settings.CountBtnClick = counter;
            settings.CounterDropClick = counterDropClick;
           
            settings.ColorTextBoxSet = Color.FromArgb(30, 100, 200);
            settings.ColorButSet = Color.FromArgb(30, 100, 200);
            toggleBtnMoving.OnBackColor = Color.FromArgb(30, 100, 200);

            settings.ColorPanelSet = Color.White;
            settings.ColorFontBtnSet = Color.Gainsboro;
            settings.ColorFontLblSet = Color.Black;

            ////////////////////////

            settings.SizeFontSet = 10;
            settings.SizeWinBorder = 1;
            settings.RadiusWinBorder = 1;

            settings.IsMoving = false;

            settings.Save();


            Logger logger = new Logger();
            logger.Log("Сброс настроек", "Options.cs", "btnDropOptions", "398");
        }

        private void trackBarFontSize_Scroll(object sender, EventArgs e)
        {
            counterTextSize++;
            Properties.Settings.Default.SizeFontSet = trackBarFontSize.Value;
            Properties.Settings.Default.CounterTextSize = counterTextSize;

            label1.Font = new Font(font, trackBarFontSize.Value);
            label2.Font = new Font(font, trackBarFontSize.Value);
            label3.Font = new Font(font, trackBarFontSize.Value);
            label4.Font = new Font(font, trackBarFontSize.Value);
            label5.Font = new Font(font, trackBarFontSize.Value);
            label6.Font = new Font(font, trackBarFontSize.Value);
            label7.Font = new Font(font, trackBarFontSize.Value);
            label8.Font = new Font(font, trackBarFontSize.Value);
            label9.Font = new Font(font, trackBarFontSize.Value);
            label10.Font = new Font(font, trackBarFontSize.Value);

            Properties.Settings.Default.Save();

            Logger logger = new Logger();
            logger.Log("Изменение размера текста", "Options.cs", "trackBarFontSize", "430");
        }

        private void trackBarSizeWinBorder_Scroll(object sender, EventArgs e)
        {
            counterBorderSize++;
            Properties.Settings.Default.CounterBorderSize = counterBorderSize;
            Properties.Settings.Default.SizeWinBorder = trackBarSizeWinBorder.Value;
            Properties.Settings.Default.Save();

            Logger logger = new Logger();
            logger.Log("Изменение размера границ окна", "Options.cs", "trackBarSizeWinBorder", "453");
        }

        private void trackBarRadWinBorder_Scroll(object sender, EventArgs e)
        {
            counterBorderRadius++;
            Properties.Settings.Default.CounterBorderRadius = counterBorderRadius;
            Properties.Settings.Default.RadiusWinBorder = trackBarRadWinBorder.Value;
            Properties.Settings.Default.Save();

            Logger logger = new Logger();
            logger.Log("Изменение радиуса границ окна", "Options.cs", "trackBarRadWinBorder", "464");
        }

        private void toggleBtnMoving_CheckedChanged(object sender, EventArgs e)
        {
            Logger logger = new Logger();
            counterToggleMoving++;

            var settings = Properties.Settings.Default;

            settings.CounterToggleBtnMoving = counterToggleMoving;

            if (toggleBtnMoving.Checked == true)
            {
                settings.IsMoving = true;
                settings.Save();

                logger.Log("Окно можно перетаскивать", "Options.cs", "toggleBtnMoving", "484");
            }
            else
            {
                settings.IsMoving = false;
                settings.Save();

                logger.Log("Окно нельзя перетаскивать", "Options.cs", "toggleBtnMoving", "475");
            }
        }
        #endregion

        #region Default Color
        private void btnDefBtnColor_Click(object sender, EventArgs e)
        {
            counter++; counterDefaultClick++;

            var settings = Properties.Settings.Default;

            settings.CountBtnClick = counter;
            settings.CounterDefaultClick = counterDefaultClick;
            //знаю что можно было сделать ColorButSet = Color.FromArgb(30, 100, 200), но
            //там ведь "Стиль" - значит определенный цвет, шрифт, размер,
            //А тут конкретно по умолчанию к кнопке, которая не меняет цвет, креме того
            //как меняется стиль...И я немного заебался с этими цветами)))

            settings.ColorButSet = btnDefBtnColor.BackColor;
            settings.Save();
            btnButtonColor.BackColor = settings.ColorButSet;
            btnDropOptions.BackColor = settings.ColorButSet;
            btnAboutA.BackColor = settings.ColorButSet;
            btnColorWinBorder.BackColor = settings.ColorButSet;
            btnColorWinFont.BackColor = settings.ColorButSet;

            Logger logger = new Logger();
            logger.Log("Цвет кнопок по умолчанию установлен", "Options.cs", "btnDefBtnColor", "502");
        }

        private void btnDefFontColor_Click(object sender, EventArgs e)
        {
            counter++; counterDefaultClick++;

            var settings = Properties.Settings.Default;

            settings.CountBtnClick = counter;
            settings.CounterDefaultClick = counterDefaultClick;

            settings.ColorFontBtnSet = btnDefFontColor.TextColor;
            settings.Save();
            btnButtonColor.TextColor = settings.ColorFontBtnSet;
            btnDropOptions.TextColor = settings.ColorFontBtnSet;
            btnAboutA.TextColor = settings.ColorFontBtnSet;
            btnColorWinBorder.TextColor = settings.ColorFontBtnSet;
            btnColorWinFont.TextColor = settings.ColorFontBtnSet;
            btnColorAllFontColor.TextColor = settings.ColorFontBtnSet;

            Logger logger = new Logger();
            logger.Log("Цвет текста по умолчанию установлен", "Options.cs", "btnDefFontColor", "527");
        }

        private void btnDefAllFontColor_Click(object sender, EventArgs e)
        {
            counter++; counterDefaultClick++;

            var settings = Properties.Settings.Default;

            settings.CountBtnClick = counter;
            settings.CounterDefaultClick = counterDefaultClick;

            settings.ColorFontLblSet = Color.Black;
            settings.Save();

            //for (int i = 1; i < 10; i++)
            //{
            //    (Controls["label" + (i + 1).ToString()] as Label).ForeColor = settings.ColorFontLblSet;
            //}

            label1.ForeColor = settings.ColorFontLblSet;
            label2.ForeColor = settings.ColorFontLblSet;
            label3.ForeColor = settings.ColorFontLblSet;
            label4.ForeColor = settings.ColorFontLblSet;
            label5.ForeColor = settings.ColorFontLblSet;
            label6.ForeColor = settings.ColorFontLblSet;
            label7.ForeColor = settings.ColorFontLblSet;
            label8.ForeColor = settings.ColorFontLblSet;
            label9.ForeColor = settings.ColorFontLblSet;
            label10.ForeColor = settings.ColorFontLblSet;

            Logger logger = new Logger();
            logger.Log("Цвет текста по умолчанию установлен на форме", "Options.cs", "btnDefAllFontColor", "549");
        }

        private void btnDefTextBoxColor_Click(object sender, EventArgs e)
        {
            counter++; counterDefaultClick++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterDefaultClick = counterDefaultClick;

            Properties.Settings.Default.ColorTextBoxSet = btnDefTextBoxColor.BackColor;
            Properties.Settings.Default.Save();

            Logger logger = new Logger();
            logger.Log("Цвет полей ввода по умолчанию установлен", "Options.cs", "btnDefTextBoxColor", "581");
        }

        private void btnDefWinBorderColor_Click(object sender, EventArgs e)
        {
            counter++; counterDefaultClick++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterDefaultClick = counterDefaultClick;

            Properties.Settings.Default.ColorBorderSet = btnDefWinBorderColor.BackColor;
            Properties.Settings.Default.Save();

            Logger logger = new Logger();
            logger.Log("Цвет границ окна по умолчанию установлен", "Options.cs", "btnDefWinBorderColor", "594");
        }

        #endregion


    }
}
