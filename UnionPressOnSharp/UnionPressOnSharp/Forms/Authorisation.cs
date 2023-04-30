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
using System.Configuration;

namespace UnionPressOnSharp.Forms
{
    public partial class Authorisation : Form
    {
        private int counter = 0;
        public Authorisation()
        {
            InitializeComponent();
        }

        private void btnAuthorisation_Click(object sender, EventArgs e)
        {
            counter++;
            Properties.Settings.Default.CountBtnClick = counter;

            Logger logger = new Logger();
            logger.Log("Авторизация", "Authorisation.cs", "btnAuthorisation", "23");

            var settings = Properties.Settings.Default;

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;

            LoginPass loginPass = new LoginPass();

            loginPass.AuthorisationAccount(txtLogin.Texts, txtPassword.Texts, sqlConnectionString);

           
                TabelsAndPanels tabelsAndPanels = new TabelsAndPanels();
                tabelsAndPanels.Show();

                this.Close();
       
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {
            ColorSet();
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;

            btnAuthorisation.BackColor = settings.ColorButSet;
            string font = "Archive";

            label1.Font = new Font(font, settings.SizeFontSet);
            label2.Font = new Font(font, settings.SizeFontSet);

            label1.ForeColor = settings.ColorFontLblSet;
            label2.ForeColor = settings.ColorFontLblSet;

            txtLogin.BorderColor = settings.ColorTextBoxSet;
            txtLogin.BorderFocusColor = settings.ColorTxtFocus;
            txtLogin.ForeColor = settings.ColorFontLblSet;
            txtLogin.BackColor = settings.ColorPanelSet;

            txtPassword.BorderColor = settings.ColorTextBoxSet;
            txtPassword.BorderFocusColor = settings.ColorTxtFocus;
            txtPassword.ForeColor = settings.ColorFontLblSet;
            txtPassword.BackColor = settings.ColorPanelSet;

            BackColor = settings.ColorPanelSet;

        }
    }
}
