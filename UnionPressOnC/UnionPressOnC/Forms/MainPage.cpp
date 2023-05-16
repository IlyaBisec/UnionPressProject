#include "MainPage.h"
#include <string>
#include "Classes/Logger.h"
using namespace System::Net::WebRequest;
using namespace UnionPressOnC;
using namespace std;

Void MainPage::MainPage_Load(System::Object^ sender, System::EventArgs^ e)
{
   /* var settings = Properties.Settings.Default;
    btnSlideShow.BackColor = settings.ColorButSet;
    BackColor = settings.ColorPanelSet;*/

    Logger logger;
    logger.Log("Открытие главной страницы", "MainPage.cs", "MainPageLoad", "30");
}

Void MainPage::btnSlideShow_Click(System::Object^ sender, System::EventArgs^ e)
{
    Logger logger;
   
    //Properties.Settings.Default.CountBtnClick = counter;
    if (timer1->Enabled == true)
    {
        timer1->Enabled = false;
        btnSlideShow->Text = "Запустить показ";
        logger.Log("Запуск показа", "MainPage.cs", "btnSlideShow", "41");
    }
    else
    {
        timer1->Enabled = true;
        btnSlideShow->Text = "Остановить показ";
        logger.Log("Стоп показ", "MainPage.cs", "btnSlideShow", "52");
    }
}

Void MainPage::timer1_Tick(System::Object^ sender, System::EventArgs^ e)
{
    int i;
    //742x406
    string path1 = @"..\1.png";
    string path2 = @"..\2.png";
    string path3 = @"..\3.png";
    string path4 = @"..\4.png";
    string path5 = @"..\5.png";
    string path6 = @"..\6.png";

    string pathStore[] = { path1, path2, path3, path4, path5, path6 };
    i++;

    if (this->picBoxSlide.Image != nullptr)
        this->picBoxSlide.Image.Dispose();
    try
    {

        if (i > 1) {
            i = 2;
            i = 3;
            i = 4;
            i = 5;
            i = 6;
            i = 0;
        }
        auto request = WebRequest.Create(pathStore[i]);
        using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
        {

            this.picBoxSlide.Image = Image.FromStream(stream);
        }


        picBoxSlide.Refresh();
    }
    catch
    {
        this->picBoxSlide.Image = null;// MessageBox.Show("Не удалось подключиться к хранилищу, проверьте подключение","Ошибка", MessageBoxButtons.OK); 
    }
}
