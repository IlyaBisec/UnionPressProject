using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Classes;

namespace UnionPressOnSharp.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
          //  DownLoadFile();
            timer1 = new Timer();
            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        int i = 0;
        private int counter = 0;

        private void MainPage_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            btnSlideShow.BackColor = settings.ColorButSet;
            BackColor = settings.ColorPanelSet;

            Logger logger = new Logger();
            logger.Log("Открытие главной страницы", "MainPage.cs", "MainPageLoad", "30");
        }

        private void btnSlideShow_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger();
            counter++;
            Properties.Settings.Default.CountBtnClick = counter;
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnSlideShow.Text = "Запустить показ";
                logger.Log("Запуск показа", "MainPage.cs", "btnSlideShow", "41");
            }
            else
            {
                timer1.Enabled = true;
                btnSlideShow.Text = "Остановить показ";
                logger.Log("Стоп показ", "MainPage.cs", "btnSlideShow", "52");
            }

        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //742x406
            string path1 = @"D:\Games\ILYA'S GAMES\Для Баргу\Для Баргу Зачем\курсач\Курсовая работа 4 семестр(2 курс)\Союз Печати\UnionPressOnSharp\UnionPressOnSharp\Interface\MainPage\1.png";
            string path2 = @"D:\Games\ILYA'S GAMES\Для Баргу\Для Баргу Зачем\курсач\Курсовая работа 4 семестр(2 курс)\Союз Печати\UnionPressOnSharp\UnionPressOnSharp\Interface\MainPage\2.png";
            string path3 = @"D:\Games\ILYA'S GAMES\Для Баргу\Для Баргу Зачем\курсач\Курсовая работа 4 семестр(2 курс)\Союз Печати\UnionPressOnSharp\UnionPressOnSharp\Interface\MainPage\3.png";
            string path4 = @"D:\Games\ILYA'S GAMES\Для Баргу\Для Баргу Зачем\курсач\Курсовая работа 4 семестр(2 курс)\Союз Печати\UnionPressOnSharp\UnionPressOnSharp\Interface\MainPage\4.png";
            string path5 = @"D:\Games\ILYA'S GAMES\Для Баргу\Для Баргу Зачем\курсач\Курсовая работа 4 семестр(2 курс)\Союз Печати\UnionPressOnSharp\UnionPressOnSharp\Interface\MainPage\5.png";
            string path6 = @"D:\Games\ILYA'S GAMES\Для Баргу\Для Баргу Зачем\курсач\Курсовая работа 4 семестр(2 курс)\Союз Печати\UnionPressOnSharp\UnionPressOnSharp\Interface\MainPage\6.png";

            string[] pathStore = { path1, path2, path3, path4, path5, path6 };
            i++;
            
            if (this.picBoxSlide.Image != null)
                this.picBoxSlide.Image.Dispose();
            try
            {

                if(i > 1) { 
                            i = 2;
                            i = 3;
                            i = 4;
                            i = 5;
                            i = 6;
                            i = 0; }
                    var request = WebRequest.Create(pathStore[i]);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {

                        this.picBoxSlide.Image = Image.FromStream(stream);
                    }
                
                
                picBoxSlide.Refresh();
            }
            catch
            {this.picBoxSlide.Image = null;// MessageBox.Show("Не удалось подключиться к хранилищу, проверьте подключение","Ошибка", MessageBoxButtons.OK); 
            }
        }

        private static async Task DownLoadFile()
        {
            using (var httpClient = new HttpClient())
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("https://drive.google.com/drive/folders/1zuhQzzy0cJJZRlYRNAVYudXM8mc11Pb6?usp=sharing");
                client.DownloadFileAsync(uri, "*.png");

                File.WriteAllBytes(Environment.CurrentDirectory + @"\DownloadingImageFromDisk\" + uri.Segments[2],
                    await httpClient.GetByteArrayAsync(uri));
            }
        }

    }
}
