#include "Authorisation.h"
#include "Classes/Logger.h"
#include "TabelsAndPanels.h"
#include "Classes/LoginPass.h"

using namespace System;
using namespace System::Windows::Forms;
using namespace UnionPressOnC;
using namespace System::Configuration;

Void Authorisation::Authorisation_Load(System::Object^ sender, System::EventArgs^ e)
{
	ColorSet();
}

Void Authorisation::btnAuthorisation_Click(System::Object^ sender, System::EventArgs^ e)
{
	counter++;

	Logger logger;
	logger.Log("Авторизация", "Authorisation.cs", "btnAuthorisation", "23");

	String^ sqlConnectionString = ConfigurationManager::ConnectionStrings["UnionPressDB"]->ConnectionString;

	LoginPass loginPass;

	loginPass.authorisationAccount(txtLogin->Texts, txtPassword->Texts, sqlConnectionString);


	TabelsAndPanels^ tabelsAndPanels = gcnew TabelsAndPanels();
	tabelsAndPanels->Show();

	this->Close();
}
