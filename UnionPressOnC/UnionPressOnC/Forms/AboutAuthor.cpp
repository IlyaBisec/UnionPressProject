#include "AboutAuthor.h"
#include "Classes/Logger.h"
using namespace System;
using namespace System::Windows::Forms;
using namespace UnionPressOnC;
using namespace System::Configuration;

Void AboutAuthor::btnUnderstand_Click(System::Object^ sender, System::EventArgs^ e)
{
	Close();
}

Void AboutAuthor::AboutAuthor_Load(System::Object^ sender, System::EventArgs^ e)
{
	Logger logger;
	logger.Log("Инфо об авторе(мне)", "AboutAuthor.cs", "AboutAuthor", "29");
}