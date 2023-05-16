#include "Registration.h"
#include "Authorisation.h"
#include "Classes/FunctionsDB.h"
#include <string>
#include "Classes/LoginPass.h"
#include "Classes/Logger.h"

using namespace System;
using namespace System::Windows::Forms;
using namespace UnionPressOnC;

Void Registration::btnRegistration_Click(System::Object^ sender, System::EventArgs^ e)
{
    counter++;
    //Properties.Settings.Default.CountBtnClick = counter;

    //var settings = Properties.Settings.Default;
    //   this.Close();

    String^ sqlConnectionString = ConfigurationManager::ConnectionStrings["UnionPressDB"]->ConnectionString;

    LoginPass loginPass;
    //bool logPas = loginPass.RegistrationAccount(txtLogin.Texts, txtPassword.Texts, txtName.Texts, txtSurname.Texts, txtAge.Texts, txtSex.Texts);
    loginPass.registrationAccount(txtLogin.Texts, txtPassword.Texts, txtName.Texts, txtSurname.Texts, txtAge.Texts, txtSex.Texts, sqlConnectionString);


    Logger logger;
    logger.Log("–егистраци€", "Registration.cs", "btnRegistration", "103");
    //после регистрации->авторизаци€
    Authorisation^ authorisation = gcnew Authorisation();
    authorisation->Show();
}

Void Registration::btnAuthorisation_Click(System::Object^ sender, System::EventArgs^ e)
{
    counter++;
    //Properties.Settings.Default.CountBtnClick = counter;
    Authorisation^ authorisation = gcnew Authorisation();
    authorisation->Show();

    this->Hide();
}

Void Registration::Registration_Load(System::Object^ sender, System::EventArgs^ e)
{
    //ColorSet();
    FunctionsDB functionsDB;
    functionsDB.connectToDB();
}

