using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms;
using UnionPressOnSharp.Forms.Classes;

namespace UnionPressOnSharp
{
    public partial class MainForm : Form
    {
        private int counter = 0;
        private int counterConnect = 0;
        private int counterExit = 0;

        public int i = 0;

        public MainForm()
        {
            InitializeComponent();
       
        }

        private void доставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;

            

            i = 5400;
            settings.AppsTime = "0:00:00";
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

            Logger logger = new Logger();
            logger.Log("Запуск приложения", "MainForm.cs", "Form1Load", "38");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            counter++; counterExit++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterExit = counterExit;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger();
            logger.Log("Выход с приложения", "MainForm.cs", "btnExit", "53");
            Application.Exit();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            TablesForms tablesForms = new TablesForms();
            tablesForms.Show();

        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            counter++; counterConnect++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterConnect = counterConnect;

            Logger logger = new Logger();
            logger.Log("Выполнение входа", "MainForm.cs", "btnConnect", "60");

            Registration registration = new Registration();
            registration.ShowDialog();

            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            Logger logger = new Logger();
            logger.Log("Окно свернулось", "MainForm.cs", "btnMinimize", "87");
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.IsMoving == true)
                ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            Logger logger = new Logger();
            logger.Log("Окно перетаскивается", "MainForm.cs", "MainForm_MouseDown", "95");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            i += 1;
            string mm;
            string ss;
            string hh = (i / 3600).ToString();
            if ((i % 3600) / 60 > 9)
            {
                mm = ((i % 3600) / 60).ToString();
            }
            else
            {
                mm = "0" + ((i % 3600) / 60).ToString();
            }
            if ((i % 3600) % 60 > 9)
            {
                ss = ((i % 3600) % 60).ToString();
            }
            else
            {
                ss = "0" + ((i % 3600) % 60).ToString();
            }
            settings.AppsTime = hh + ":" + mm + ":" + ss;
            if (i < 0)
                timer1.Stop();
        }
    }
}
