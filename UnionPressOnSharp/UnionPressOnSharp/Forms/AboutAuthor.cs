using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Classes;

namespace UnionPressOnSharp.Forms
{
    public partial class AboutAuthor : Form
    {
        public AboutAuthor()
        {
            InitializeComponent();
        }
        private int counter = 0;
        private void btnUnderstand_Click(object sender, EventArgs e)
        {
            counter++;
            Properties.Settings.Default.CountBtnClick = counter;
            Close();
        }

        private void AboutAuthor_Load(object sender, EventArgs e)
        {
            ColorSet();

            Logger logger = new Logger();
            logger.Log("Инфо об авторе(мне)", "AboutAuthor.cs", "AboutAuthor", "29");
            //string path1 = "https://2.downloader.disk.yandex.ru/preview/d1122163fc90929590ce35b4ace6b08ebdf2b41dbcb3f42250814b339f566dc2/inf/47HRzTSP8ncPK3V33SnHmYA4c5mUJKVbSQPqUhV3lsdFonCV5aFCBStz6uhhznRdW8kJQXaE_M0c_VAJ3Fp2sg%3D%3D?uid=795611254&filename=I.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=795611254&tknv=v2&size=892x950";


            //if (this.picBoxAuthorAvatar.Image != null)
            //    this.picBoxAuthorAvatar.Image.Dispose();
            //try
            //{
            //    var request = WebRequest.Create(path1);
            //    using (var response = request.GetResponse())
            //    using (var stream = response.GetResponseStream())
            //    {

            //        this.picBoxAuthorAvatar.Image = Image.FromStream(stream);
            //    }
            //}
            //catch
            //{
            //    this.picBoxAuthorAvatar.Image = null; 
            //    MessageBox.Show("Не удалось подключиться к хранилищу диска, проверьте подключение","Ошибка", MessageBoxButtons.OK); 
            //}
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            btnUnderstand.BackColor = settings.ColorButSet;

            lblApplication.ForeColor = settings.ColorFontLblSet;
            lblApplicationName.ForeColor = settings.ColorFontLblSet;
            lblAuthor.ForeColor = settings.ColorFontLblSet;
            lblAuthorName.ForeColor = settings.ColorFontLblSet;
            lblGroup.ForeColor = settings.ColorFontLblSet;
            lblGroupName.ForeColor = settings.ColorFontLblSet;
            lblSpecial.ForeColor = settings.ColorFontLblSet;
            lblSpecialName.ForeColor = settings.ColorFontLblSet;
            lblVersion.ForeColor = settings.ColorFontLblSet;
            lblVersionName.ForeColor = settings.ColorFontLblSet;

            BackColor = settings.ColorPanelSet;

        }
    }
}
