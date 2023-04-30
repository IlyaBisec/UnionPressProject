namespace UnionPressOnSharp.Forms
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnSlideShow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.picBoxSlide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSlideShow
            // 
            this.btnSlideShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSlideShow.FlatAppearance.BorderSize = 0;
            this.btnSlideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideShow.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlideShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSlideShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSlideShow.Location = new System.Drawing.Point(235, 446);
            this.btnSlideShow.Name = "btnSlideShow";
            this.btnSlideShow.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSlideShow.Size = new System.Drawing.Size(290, 55);
            this.btnSlideShow.TabIndex = 10;
            this.btnSlideShow.Text = "Запустить показ";
            this.btnSlideShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSlideShow.UseVisualStyleBackColor = false;
            this.btnSlideShow.Click += new System.EventHandler(this.btnSlideShow_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.png");
            this.imageList.Images.SetKeyName(1, "2.png");
            // 
            // picBoxSlide
            // 
            this.picBoxSlide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxSlide.ErrorImage = null;
            this.picBoxSlide.ImageLocation = "";
            this.picBoxSlide.InitialImage = null;
            this.picBoxSlide.Location = new System.Drawing.Point(12, 12);
            this.picBoxSlide.Name = "picBoxSlide";
            this.picBoxSlide.Size = new System.Drawing.Size(742, 406);
            this.picBoxSlide.TabIndex = 0;
            this.picBoxSlide.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 513);
            this.Controls.Add(this.btnSlideShow);
            this.Controls.Add(this.picBoxSlide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSlide;
        private System.Windows.Forms.Button btnSlideShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ImageList imageList;
    }
}