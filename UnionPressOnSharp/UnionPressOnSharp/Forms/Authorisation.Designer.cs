namespace UnionPressOnSharp.Forms
{
    partial class Authorisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorisation));
            this.btnAuthorisation = new OwnControls.Controls.Modern_Button();
            this.txtLogin = new OwnControls.Controls.Modern_TextBox();
            this.txtPassword = new OwnControls.Controls.Modern_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modern_PictureBox1 = new OwnControls.Controls.Modern_PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modern_PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAuthorisation.Location = new System.Drawing.Point(126, 208);
            this.btnAuthorisation.Name = "btnAuthorisation";
            this.btnAuthorisation.Size = new System.Drawing.Size(198, 61);
            this.btnAuthorisation.TabIndex = 0;
            this.btnAuthorisation.Text = "Авторизоваться";
            this.btnAuthorisation.TextColor = System.Drawing.Color.White;
            this.btnAuthorisation.UseVisualStyleBackColor = false;
            this.btnAuthorisation.Click += new System.EventHandler(this.btnAuthorisation_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLogin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLogin.BorderRadius = 0;
            this.txtLogin.BorderSize = 2;
            this.txtLogin.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(194, 32);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MultiLine = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogin.PasswordStyle = false;
            this.txtLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.Size = new System.Drawing.Size(212, 27);
            this.txtLogin.TabIndex = 2;
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
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(194, 126);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordStyle = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(212, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderLineStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Archive", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(191, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Archive", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(191, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
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
            this.modern_PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.modern_PictureBox1.Name = "modern_PictureBox1";
            this.modern_PictureBox1.Size = new System.Drawing.Size(142, 142);
            this.modern_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modern_PictureBox1.TabIndex = 1;
            this.modern_PictureBox1.TabStop = false;
            // 
            // Authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.modern_PictureBox1);
            this.Controls.Add(this.btnAuthorisation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorisation";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modern_PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OwnControls.Controls.Modern_Button btnAuthorisation;
        private OwnControls.Controls.Modern_PictureBox modern_PictureBox1;
        private OwnControls.Controls.Modern_TextBox txtLogin;
        private OwnControls.Controls.Modern_TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}