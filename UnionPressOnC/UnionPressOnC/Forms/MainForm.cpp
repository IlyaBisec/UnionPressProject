#include "MainForm.h"
#include "Registration.h"
#include "Classes/Logger.h"

using namespace System;
using namespace System::Windows::Forms;
using namespace UnionPressOnC;

int main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	UnionPressOnC::MainForm mainform;
	Application::Run(% mainform);
}


Void MainForm::btnConnect_Click(System::Object^ sender, System::EventArgs^ e)
{
	counter++; counterConnect++;
	
	Logger logger;
	logger.Log("Выполнение входа", "MainForm.cs", "btnConnect", "60");

	Registration^ registration = gcnew Registration();
	registration->ShowDialog();

	WindowState = FormWindowState::Minimized;
}

Void MainForm::btnExit_Click(System::Object^ sender, System::EventArgs^ e)
{
	counter++; counterExit++;

	Application::Exit();
}

Void MainForm::btnMainHide_Click(System::Object^ sender, System::EventArgs^ e)
{
	WindowState = FormWindowState::Minimized;

	Logger logger;
	logger.Log("Окно свернулось", "MainForm.cs", "btnMinimize", "87");
}

Void MainForm::btnMainClose_Click(System::Object^ sender, System::EventArgs^ e)
{
	Logger logger;
	logger.Log("Выход с приложения", "MainForm.cs", "btnExit", "53");
	Application::Exit();
}

Void MainForm::MainForm_Load(System::Object^ sender, System::EventArgs^ e)
{

	Logger logger;
	logger.Log("Запуск приложения", "MainForm.cs", "Form1Load", "38");
}

Void MainForm::MainForm_MouseDown(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e)
{
	/*if (Properties.Settings.Default.IsMoving == true)
		ReleaseCapture();
	SendMessage(this.Handle, 0x112, 0xf012, 0);*/

	Logger logger;
	logger.Log("Окно перетаскивается", "MainForm.cs", "MainForm_MouseDown", "95");
}