using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Classes;
namespace UnionPressOnSharp
{
    public partial class TabelsAndPanels : Form
    {
        private Button currentButton;
        private Form activeForm;
        private int borderRadius = Properties.Settings.Default.RadiusWinBorder;
        private int borderSize = Properties.Settings.Default.SizeWinBorder;
        private Color borderColor = Properties.Settings.Default.ColorBorderSet;

        //statistics
        private int counterWorkers = 0,     counterPress = 0,
                    counterTypePress = 0,   counterPeriodPress = 0,
                    counterGraphic = 0,     counterOptions = 0,
                    counterStatistics = 0,  counterLogoMainPage = 0,
                    counterExit = 0,        counterDostavka = 0;

        private int counter = 0;

        FunctionsDB FunctionsDB = new FunctionsDB();
        // private int btnIndex;

        public TabelsAndPanels()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.panelTitle.BackColor = borderColor;

            //this.panelDesktop.BackColor = Properties.Settings.Default.ColorPanelSet;
        }

        #region Dragging
        //Dragging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.IsMoving == true)
                ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            Logger logger = new Logger();
            logger.Log("Перетаскивание формы", "TablesAndPanels.cs", "patelTittle", "45");
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.IsMoving == true)
                ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            Logger logger = new Logger();
            logger.Log("Перетаскивание формы", "TablesAndPanels.cs", "lblTittle", "55");

        }
        private void TabelsAndPanels_MouseDown(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.IsMoving == true)
                ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            Logger logger = new Logger();
            logger.Log("Перетаскивание формы", "TablesAndPanels.cs", "TabelsAndPanel", "65");
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
           // float radius = Properties.Settings.Default.RadiusWinBorder;
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        private void TabelsAndPanels_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
           // ControlRegionAndBorder(panelDesktop, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void TabelsAndPanels_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void TabelsAndPanels_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void TabelsAndPanels_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion
        private void TabelsAndPanels_Load(object sender, EventArgs e)
        {
            FunctionsDB.ConnectToDB();
            MessageBox.Show("Подключение установлено!\nБаза данных загружена");
            ColorSet();

            Logger logger = new Logger();
            logger.Log("Связь с бд установлена, приложение запускается", "TablesAndPanels.cs", "TablesAndPanelsLoad", "223");
        }

        private void ColorSet() //устанавливаем цвет-размер из настроек
        {
            var settings = Properties.Settings.Default;

            panelDesktop.BackColor = settings.ColorPanelSet;
        }

        private Color SelectThemeColor()
        {
            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Archive", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForms(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.Show();
            lblTitle.Text = childForm.Text;
            this.Text = childForm.Text;
            this.BackColor = childForm.BackColor;

            Logger logger = new Logger();
            logger.Log("Открытие дочерней формы", "TablesAndPanels.cs", "OpenChildForms", "279");
        }

        private void OpenMainPage(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.Show();
            lblTitle.Text = childForm.Text;
            this.Text = childForm.Text;
            this.BackColor = childForm.BackColor;

            Logger logger = new Logger();
            logger.Log("Открытие дочерней формы", "TablesAndPanels.cs", "OpenChildForms", "301");
        }


        private void btnWorkers_Click(object sender, EventArgs e)
        {
            counter++;
            counterWorkers++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterWorkers = counterWorkers;
            OpenChildForms(new Forms.Workers(), sender);

            Logger logger = new Logger();
            logger.Log("дочерняя форма с работниками", "TablesAndPanels.cs", "btnWorkers", "323");
        }

        private void btnTransporter_Click(object sender, EventArgs e)
        {
            counter++; counterDostavka++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterDostavka = counterDostavka;
            OpenChildForms(new Forms.Transporter(), sender);

            Logger logger = new Logger();
            logger.Log("дочерняя форма с доставкой", "TablesAndPanels.cs", "btnTransporter", "335");
        }

        private void btnPresss_Click(object sender, EventArgs e)
        {
            counter++; counterPress++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterPress = counterPress;
            OpenChildForms(new Forms.Press(), sender);

            Logger logger = new Logger();
            logger.Log("дочерняя форма с изданиями", "TablesAndPanels.cs", "btnPress", "346");
        }

        private void btnTypePress_Click(object sender, EventArgs e)
        {
            counter++; counterTypePress++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterTypePress = counterTypePress;
            OpenChildForms(new Forms.TypePress(), sender);

            Logger logger = new Logger();
            logger.Log("дочерняя форма с типом изданий", "TablesAndPanels.cs", "btnTypePress", "357");
        }

        private void btnPeriodPress_Click(object sender, EventArgs e)
        {
            counter++; counterPeriodPress++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterPeriodPress = counterPeriodPress;
            OpenChildForms(new Forms.PeriodPress(), sender);

            Logger logger = new Logger();
            logger.Log("дочерняя форма с периодом изданий", "TablesAndPanels.cs", "btnPeriodPress", "368");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            counterExit++;
            Properties.Settings.Default.CounterExit = counterExit;
            ActiveButton(sender);
            this.Text = "Выход...";
            this.Close();

            Logger logger = new Logger();
            logger.Log("Закрытие формы, отключение связи с бд", "TablesAndPanels.cs", "btnExit", "379");
        }

      

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo1_Click(object sender, EventArgs e)
        {
            counter++; counterLogoMainPage++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterLogoMP = counterLogoMainPage;
            OpenMainPage(new Forms.MainPage(), sender);

            Logger logger = new Logger();
            logger.Log("Клик по лого(главная страница)", "TablesAndPanels.cs", "lblLogo", "403");
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            counter++; counterGraphic++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterGraphic = counterGraphic;
            OpenChildForms(new Forms.GraphicForm(), sender);

            Logger logger = new Logger();
            logger.Log("Клик по кнопке график", "TablesAndPanels.cs", "btnGraphic", "414");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            counter++; counterStatistics++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterStatistics = counterStatistics;
            OpenChildForms(new Forms.Statistics(), sender);

            Logger logger = new Logger();
            logger.Log("Клик по кнопке статистика", "TablesAndPanels.cs", "btnStatistics", "425");
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            counter++; counterOptions++;
            Properties.Settings.Default.CountBtnClick = counter;
            Properties.Settings.Default.CounterOptions = counterOptions;
            OpenChildForms(new Forms.Options(), sender);

            Logger logger = new Logger();
            logger.Log("Клик по кнопке настройки", "TablesAndPanels.cs", "btnOptions", "436");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            Logger logger = new Logger();
            logger.Log("Свернуть окно", "TablesAndPanels.cs", "btnHide", "447");
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            Logger logger = new Logger();
            logger.Log("Разврнуть окно", "TablesAndPanels.cs", "btnExpand", "455");
        }

       
    }
}
