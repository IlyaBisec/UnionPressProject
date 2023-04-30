namespace UnionPressOnSharp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblMainName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btnConnect = new OwnControls.Controls.Modern_Button();
            this.btnExit = new OwnControls.Controls.Modern_Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImage.BackgroundImage")));
            this.pnlImage.Location = new System.Drawing.Point(3, 2);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(23, 22);
            this.pnlImage.TabIndex = 0;
            // 
            // lblMainName
            // 
            this.lblMainName.AutoSize = true;
            this.lblMainName.BackColor = System.Drawing.Color.Transparent;
            this.lblMainName.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainName.ForeColor = System.Drawing.Color.White;
            this.lblMainName.Location = new System.Drawing.Point(32, 5);
            this.lblMainName.Name = "lblMainName";
            this.lblMainName.Size = new System.Drawing.Size(132, 18);
            this.lblMainName.TabIndex = 1;
            this.lblMainName.Text = "Главное меню";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(277, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRun
            // 
            this.btRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRun.BackgroundImage")));
            this.btRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRun.Location = new System.Drawing.Point(238, 346);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(61, 17);
            this.btRun.TabIndex = 3;
            this.btRun.Text = "Таблицы";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Visible = false;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btAbout
            // 
            this.btAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAbout.BackgroundImage")));
            this.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbout.Location = new System.Drawing.Point(238, 323);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(61, 17);
            this.btAbout.TabIndex = 4;
            this.btAbout.Text = "Об авторе";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Visible = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btExit
            // 
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Location = new System.Drawing.Point(238, 303);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(61, 14);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Visible = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConnect.BorderRadius = 7;
            this.btnConnect.BorderSize = 0;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Archive", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(87, 155);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 40);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Войти";
            this.btnConnect.TextColor = System.Drawing.Color.White;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 7;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Archive", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(87, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выйти";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(257, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "____";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMainName);
            this.Controls.Add(this.pnlImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Союз печати";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblMainName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btExit;
        private OwnControls.Controls.Modern_Button btnConnect;
        private OwnControls.Controls.Modern_Button btnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

