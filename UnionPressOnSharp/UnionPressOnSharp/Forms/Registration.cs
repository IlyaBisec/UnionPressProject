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

namespace UnionPressOnSharp.Forms
{
    public partial class Registration : Form
    {
        private int counter = 0;
        public Registration()
        {
            InitializeComponent();
        }

        private void modern_TextBox2_textChanged(object sender, EventArgs e)
        {

        }

        private void btnAuthorisation_Click(object sender, EventArgs e)
        {
            counter++;
            Properties.Settings.Default.CountBtnClick = counter;
            Authorisation authorisation = new Authorisation();
            authorisation.Show();

            this.Hide();
        }

  

        private void Registration_Load(object sender, EventArgs e)
        {
            ColorSet();
            FunctionsDB functionsDB = new FunctionsDB();
            functionsDB.ConnectToDB();
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            string font = "Archive";

            btnAuthorisation.BackColor = settings.ColorButSet;
            btnRegistration.BackColor = settings.ColorButSet;

            txtAge.ForeColor = settings.ColorFontLblSet;
            txtSurname.ForeColor = settings.ColorFontLblSet;
            txtLogin.ForeColor = settings.ColorFontLblSet;
            txtName.ForeColor = settings.ColorFontLblSet;
            txtPassword.ForeColor = settings.ColorFontLblSet;
            txtSex.ForeColor = settings.ColorFontLblSet;

            txtAge.BackColor = settings.ColorPanelSet;
            txtSurname.BackColor = settings.ColorPanelSet;
            txtLogin.BackColor = settings.ColorPanelSet;
            txtName.BackColor = settings.ColorPanelSet;
            txtPassword.BackColor = settings.ColorPanelSet;
            txtSex.BackColor = settings.ColorPanelSet;

            txtAge.BorderColor = settings.ColorTextBoxSet;
            txtSurname.BorderColor = settings.ColorTextBoxSet;
            txtLogin.BorderColor = settings.ColorTextBoxSet;
            txtName.BorderColor = settings.ColorTextBoxSet;
            txtPassword.BorderColor = settings.ColorTextBoxSet;
            txtSex.BorderColor = settings.ColorTextBoxSet;


            txtAge.BorderFocusColor = settings.ColorTxtFocus;
            txtSurname.BorderFocusColor = settings.ColorTxtFocus;
            txtLogin.BorderFocusColor = settings.ColorTxtFocus;
            txtName.BorderFocusColor = settings.ColorTxtFocus;
            txtPassword.BorderFocusColor = settings.ColorTxtFocus;
            txtSex.BorderFocusColor = settings.ColorTxtFocus;


            lblName.Font = new Font(font, settings.SizeFontSet);
            lblSurname.Font = new Font(font, settings.SizeFontSet);
            lblAge.Font = new Font(font, settings.SizeFontSet);
            lblLogin.Font = new Font(font, settings.SizeFontSet);
            lblSex.Font = new Font(font, settings.SizeFontSet);
            lblPassword.Font = new Font(font, settings.SizeFontSet);

            lblName.ForeColor = settings.ColorFontLblSet;
            lblSurname.ForeColor = settings.ColorFontLblSet;
            lblAge.ForeColor = settings.ColorFontLblSet;
            lblLogin.ForeColor = settings.ColorFontLblSet;
            lblSex.ForeColor = settings.ColorFontLblSet;
            lblPassword.ForeColor = settings.ColorFontLblSet;
    

            BackColor = settings.ColorPanelSet;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            counter++;
            Properties.Settings.Default.CountBtnClick = counter;

            var settings = Properties.Settings.Default;
         //   this.Close();

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;

            LoginPass loginPass = new LoginPass();
            //bool logPas = loginPass.RegistrationAccount(txtLogin.Texts, txtPassword.Texts, txtName.Texts, txtSurname.Texts, txtAge.Texts, txtSex.Texts);
            loginPass.RegistrationAccount(txtLogin.Texts, txtPassword.Texts, txtName.Texts, txtSurname.Texts, txtAge.Texts, txtSex.Texts, sqlConnectionString);


            Logger logger = new Logger();
            logger.Log("Регистрация", "Registration.cs", "btnRegistration", "103");
                //после регистрации->авторизация
                Authorisation authorisation = new Authorisation();
               authorisation.Show();
            
      
        }
    }
}
