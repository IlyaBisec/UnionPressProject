namespace UnionPressOnSharp.Forms
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAge = new OwnControls.Controls.Modern_TextBox();
            this.txtName = new OwnControls.Controls.Modern_TextBox();
            this.txtLogin = new OwnControls.Controls.Modern_TextBox();
            this.txtPassword = new OwnControls.Controls.Modern_TextBox();
            this.txtSex = new OwnControls.Controls.Modern_TextBox();
            this.txtSurname = new OwnControls.Controls.Modern_TextBox();
            this.btnAuthorisation = new OwnControls.Controls.Modern_Button();
            this.btnRegistration = new OwnControls.Controls.Modern_Button();
            this.modern_PictureBox1 = new OwnControls.Controls.Modern_PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modern_PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Archive", 9.5F);
            this.lblName.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblName.Location = new System.Drawing.Point(198, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 14);
            this.lblName.TabIndex = 100;
            this.lblName.Text = "Имя";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Archive", 9.5F);
            this.lblLogin.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblLogin.Location = new System.Drawing.Point(198, 144);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 14);
            this.lblLogin.TabIndex = 104;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Archive", 9.5F);
            this.lblPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblPassword.Location = new System.Drawing.Point(329, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 14);
            this.lblPassword.TabIndex = 105;
            this.lblPassword.Text = "пароль";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Archive", 9.5F);
            this.lblSurname.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblSurname.Location = new System.Drawing.Point(329, 22);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 14);
            this.lblSurname.TabIndex = 101;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Archive", 9.5F);
            this.lblSex.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblSex.Location = new System.Drawing.Point(328, 83);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(33, 14);
            this.lblSex.TabIndex = 103;
            this.lblSex.Text = "пол";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Archive", 9.5F);
            this.lblAge.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblAge.Location = new System.Drawing.Point(197, 83);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(63, 14);
            this.lblAge.TabIndex = 102;
            this.lblAge.Text = "возраст";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Control;
            this.txtAge.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAge.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAge.BorderRadius = 0;
            this.txtAge.BorderSize = 2;
            this.txtAge.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAge.ForeColor = System.Drawing.Color.DimGray;
            this.txtAge.Location = new System.Drawing.Point(203, 101);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.MultiLine = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordStyle = false;
            this.txtAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAge.PlaceholderText = "";
            this.txtAge.Size = new System.Drawing.Size(120, 27);
            this.txtAge.TabIndex = 3;
            this.txtAge.Texts = "";
            this.txtAge.UnderLineStyle = true;
            this.txtAge.textChanged += new System.EventHandler(this.modern_TextBox2_textChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(203, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordStyle = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(120, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "";
            this.txtName.UnderLineStyle = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLogin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLogin.BorderRadius = 0;
            this.txtLogin.BorderSize = 2;
            this.txtLogin.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txtLogin.Location = new System.Drawing.Point(204, 162);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MultiLine = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogin.PasswordStyle = false;
            this.txtLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.Size = new System.Drawing.Size(119, 27);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.Texts = "";
            this.txtLogin.UnderLineStyle = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(332, 162);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordStyle = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(119, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderLineStyle = true;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Control;
            this.txtSex.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSex.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSex.BorderRadius = 0;
            this.txtSex.BorderSize = 2;
            this.txtSex.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSex.ForeColor = System.Drawing.Color.DimGray;
            this.txtSex.Location = new System.Drawing.Point(331, 101);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4);
            this.txtSex.MultiLine = false;
            this.txtSex.Name = "txtSex";
            this.txtSex.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSex.PasswordStyle = false;
            this.txtSex.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSex.PlaceholderText = "";
            this.txtSex.Size = new System.Drawing.Size(120, 27);
            this.txtSex.TabIndex = 4;
            this.txtSex.Texts = "";
            this.txtSex.UnderLineStyle = true;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Control;
            this.txtSurname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSurname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSurname.BorderRadius = 0;
            this.txtSurname.BorderSize = 2;
            this.txtSurname.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.ForeColor = System.Drawing.Color.DimGray;
            this.txtSurname.Location = new System.Drawing.Point(331, 38);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.MultiLine = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSurname.PasswordStyle = false;
            this.txtSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSurname.PlaceholderText = "";
            this.txtSurname.Size = new System.Drawing.Size(120, 27);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Texts = "";
            this.txtSurname.UnderLineStyle = true;
            // 
            // btnAuthorisation
            // 
            this.btnAuthorisation.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAuthorisation.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btnAuthorisation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAuthorisation.BorderRadius = 20;
            this.btnAuthorisation.BorderSize = 0;
            this.btnAuthorisation.FlatAppearance.BorderSize = 0;
            this.btnAuthorisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorisation.Font = new System.Drawing.Font("Archive", 9.5F);
            this.btnAuthorisation.ForeColor = System.Drawing.Color.White;
            this.btnAuthorisation.Location = new System.Drawing.Point(262, 250);
            this.btnAuthorisation.Name = "btnAuthorisation";
            this.btnAuthorisation.Size = new System.Drawing.Size(198, 61);
            this.btnAuthorisation.TabIndex = 8;
            this.btnAuthorisation.Text = "Авторизоваться";
            this.btnAuthorisation.TextColor = System.Drawing.Color.White;
            this.btnAuthorisation.UseVisualStyleBackColor = false;
            this.btnAuthorisation.Click += new System.EventHandler(this.btnAuthorisation_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRegistration.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btnRegistration.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistration.BorderRadius = 20;
            this.btnRegistration.BorderSize = 0;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Archive", 9.5F);
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Location = new System.Drawing.Point(27, 250);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(198, 61);
            this.btnRegistration.TabIndex = 7;
            this.btnRegistration.Text = "Зарегистрироваться";
            this.btnRegistration.TextColor = System.Drawing.Color.White;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // modern_PictureBox1
            // 
            this.modern_PictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.modern_PictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.modern_PictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.modern_PictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.modern_PictureBox1.BorderSize = 2;
            this.modern_PictureBox1.GradientAngle = 50F;
            this.modern_PictureBox1.Image = global::UnionPressOnSharp.Properties.Resources.avatar;
            this.modern_PictureBox1.Location = new System.Drawing.Point(12, 22);
            this.modern_PictureBox1.Name = "modern_PictureBox1";
            this.modern_PictureBox1.Size = new System.Drawing.Size(142, 142);
            this.modern_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modern_PictureBox1.TabIndex = 22;
            this.modern_PictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 335);
            this.Controls.Add(this.modern_PictureBox1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnAuthorisation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modern_PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ImageList imageList1;
        private OwnControls.Controls.Modern_TextBox txtAge;
        private OwnControls.Controls.Modern_TextBox txtName;
        private OwnControls.Controls.Modern_TextBox txtLogin;
        private OwnControls.Controls.Modern_TextBox txtPassword;
        private OwnControls.Controls.Modern_TextBox txtSex;
        private OwnControls.Controls.Modern_TextBox txtSurname;
        private OwnControls.Controls.Modern_Button btnAuthorisation;
        private OwnControls.Controls.Modern_Button btnRegistration;
        private OwnControls.Controls.Modern_PictureBox modern_PictureBox1;
    }
}