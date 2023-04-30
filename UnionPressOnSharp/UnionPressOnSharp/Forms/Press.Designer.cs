namespace UnionPressOnSharp.Forms
{
    partial class Press
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Press));
            this.tabControlPress = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.txtPress = new OwnControls.Controls.Modern_TextBox();
            this.btnEditPress = new System.Windows.Forms.Button();
            this.btnSearchPress = new System.Windows.Forms.Button();
            this.gridPress = new System.Windows.Forms.DataGridView();
            this.btnAddPress = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelPress = new System.Windows.Forms.Button();
            this.btnLoadPress = new System.Windows.Forms.Button();
            this.btnExportPress = new System.Windows.Forms.Button();
            this.ExportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.txtPeriodOutput = new OwnControls.Controls.Modern_TextBox();
            this.txtCaption = new OwnControls.Controls.Modern_TextBox();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblPeriodOutput = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControlPress.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPress)).BeginInit();
            this.ExportContextMenu.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPress
            // 
            this.tabControlPress.Controls.Add(this.pageMain);
            this.tabControlPress.Controls.Add(this.pageSettings);
            this.tabControlPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPress.Location = new System.Drawing.Point(0, 0);
            this.tabControlPress.Name = "tabControlPress";
            this.tabControlPress.SelectedIndex = 0;
            this.tabControlPress.Size = new System.Drawing.Size(769, 443);
            this.tabControlPress.TabIndex = 13;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.txtPress);
            this.pageMain.Controls.Add(this.btnEditPress);
            this.pageMain.Controls.Add(this.btnSearchPress);
            this.pageMain.Controls.Add(this.gridPress);
            this.pageMain.Controls.Add(this.btnAddPress);
            this.pageMain.Controls.Add(this.lblTitle);
            this.pageMain.Controls.Add(this.btnDelPress);
            this.pageMain.Controls.Add(this.btnLoadPress);
            this.pageMain.Controls.Add(this.btnExportPress);
            this.pageMain.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageMain.Location = new System.Drawing.Point(4, 22);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(761, 417);
            this.pageMain.TabIndex = 0;
            this.pageMain.Text = "Главная";
            this.pageMain.UseVisualStyleBackColor = true;
            // 
            // txtPress
            // 
            this.txtPress.BackColor = System.Drawing.SystemColors.Window;
            this.txtPress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtPress.BorderFocusColor = System.Drawing.Color.Red;
            this.txtPress.BorderRadius = 0;
            this.txtPress.BorderSize = 1;
            this.txtPress.ForeColor = System.Drawing.Color.DimGray;
            this.txtPress.Location = new System.Drawing.Point(6, 35);
            this.txtPress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPress.MultiLine = false;
            this.txtPress.Name = "txtPress";
            this.txtPress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPress.PasswordStyle = false;
            this.txtPress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPress.PlaceholderText = "";
            this.txtPress.Size = new System.Drawing.Size(543, 27);
            this.txtPress.TabIndex = 15;
            this.txtPress.Texts = "";
            this.txtPress.UnderLineStyle = true;
            // 
            // btnEditPress
            // 
            this.btnEditPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEditPress.FlatAppearance.BorderSize = 0;
            this.btnEditPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPress.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditPress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPress.Location = new System.Drawing.Point(570, 216);
            this.btnEditPress.Name = "btnEditPress";
            this.btnEditPress.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditPress.Size = new System.Drawing.Size(180, 55);
            this.btnEditPress.TabIndex = 10;
            this.btnEditPress.Text = "Изменить";
            this.btnEditPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPress.UseVisualStyleBackColor = false;
            // 
            // btnSearchPress
            // 
            this.btnSearchPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSearchPress.FlatAppearance.BorderSize = 0;
            this.btnSearchPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPress.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchPress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPress.Location = new System.Drawing.Point(570, 33);
            this.btnSearchPress.Name = "btnSearchPress";
            this.btnSearchPress.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchPress.Size = new System.Drawing.Size(180, 55);
            this.btnSearchPress.TabIndex = 9;
            this.btnSearchPress.Text = "Поиск";
            this.btnSearchPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPress.UseVisualStyleBackColor = false;
            // 
            // gridPress
            // 
            this.gridPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPress.Location = new System.Drawing.Point(6, 66);
            this.gridPress.Name = "gridPress";
            this.gridPress.Size = new System.Drawing.Size(546, 335);
            this.gridPress.TabIndex = 0;
            // 
            // btnAddPress
            // 
            this.btnAddPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddPress.FlatAppearance.BorderSize = 0;
            this.btnAddPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPress.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPress.Location = new System.Drawing.Point(570, 155);
            this.btnAddPress.Name = "btnAddPress";
            this.btnAddPress.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddPress.Size = new System.Drawing.Size(180, 55);
            this.btnAddPress.TabIndex = 2;
            this.btnAddPress.Text = "Добавить";
            this.btnAddPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPress.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Archive", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "поиск печати:";
            // 
            // btnDelPress
            // 
            this.btnDelPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDelPress.FlatAppearance.BorderSize = 0;
            this.btnDelPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPress.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelPress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPress.Location = new System.Drawing.Point(570, 277);
            this.btnDelPress.Name = "btnDelPress";
            this.btnDelPress.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelPress.Size = new System.Drawing.Size(180, 55);
            this.btnDelPress.TabIndex = 4;
            this.btnDelPress.Text = "Удалить";
            this.btnDelPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelPress.UseVisualStyleBackColor = false;
            // 
            // btnLoadPress
            // 
            this.btnLoadPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLoadPress.FlatAppearance.BorderSize = 0;
            this.btnLoadPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPress.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadPress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPress.Location = new System.Drawing.Point(570, 94);
            this.btnLoadPress.Name = "btnLoadPress";
            this.btnLoadPress.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLoadPress.Size = new System.Drawing.Size(180, 55);
            this.btnLoadPress.TabIndex = 6;
            this.btnLoadPress.Text = "Загрузить";
            this.btnLoadPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPress.UseVisualStyleBackColor = false;
            this.btnLoadPress.Click += new System.EventHandler(this.btnLoadPress_Click);
            // 
            // btnExportPress
            // 
            this.btnExportPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExportPress.ContextMenuStrip = this.ExportContextMenu;
            this.btnExportPress.FlatAppearance.BorderSize = 0;
            this.btnExportPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPress.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportPress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPress.Location = new System.Drawing.Point(570, 338);
            this.btnExportPress.Name = "btnExportPress";
            this.btnExportPress.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExportPress.Size = new System.Drawing.Size(180, 55);
            this.btnExportPress.TabIndex = 5;
            this.btnExportPress.Text = "Экспорт";
            this.btnExportPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportPress.UseVisualStyleBackColor = false;
            this.btnExportPress.Click += new System.EventHandler(this.btnExportPress_Click);
            // 
            // ExportContextMenu
            // 
            this.ExportContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.ExportContextMenu.Font = new System.Drawing.Font("Archive", 15F);
            this.ExportContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpMenuItemWord,
            this.ExpMenuItemExcel});
            this.ExportContextMenu.Name = "ExportContextMenu";
            this.ExportContextMenu.ShowImageMargin = false;
            this.ExportContextMenu.Size = new System.Drawing.Size(96, 48);
            // 
            // ExpMenuItemWord
            // 
            this.ExpMenuItemWord.Font = new System.Drawing.Font("Archive", 10F);
            this.ExpMenuItemWord.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExpMenuItemWord.Name = "ExpMenuItemWord";
            this.ExpMenuItemWord.Size = new System.Drawing.Size(95, 22);
            this.ExpMenuItemWord.Text = "Word";
            this.ExpMenuItemWord.Click += new System.EventHandler(this.ExpMenuItemWord_Click);
            // 
            // ExpMenuItemExcel
            // 
            this.ExpMenuItemExcel.Font = new System.Drawing.Font("Archive", 10F);
            this.ExpMenuItemExcel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExpMenuItemExcel.Name = "ExpMenuItemExcel";
            this.ExpMenuItemExcel.Size = new System.Drawing.Size(95, 22);
            this.ExpMenuItemExcel.Text = "Excel";
            this.ExpMenuItemExcel.Click += new System.EventHandler(this.ExpMenuItemExcel_Click);
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.txtPeriodOutput);
            this.pageSettings.Controls.Add(this.txtCaption);
            this.pageSettings.Controls.Add(this.btnCancelSettings);
            this.pageSettings.Controls.Add(this.btnSaveSettings);
            this.pageSettings.Controls.Add(this.lblPeriodOutput);
            this.pageSettings.Controls.Add(this.lblCaption);
            this.pageSettings.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(761, 417);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Настройки";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // txtPeriodOutput
            // 
            this.txtPeriodOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtPeriodOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtPeriodOutput.BorderFocusColor = System.Drawing.Color.Red;
            this.txtPeriodOutput.BorderRadius = 0;
            this.txtPeriodOutput.BorderSize = 1;
            this.txtPeriodOutput.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeriodOutput.Location = new System.Drawing.Point(315, 171);
            this.txtPeriodOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodOutput.MultiLine = false;
            this.txtPeriodOutput.Name = "txtPeriodOutput";
            this.txtPeriodOutput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeriodOutput.PasswordStyle = false;
            this.txtPeriodOutput.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeriodOutput.PlaceholderText = "";
            this.txtPeriodOutput.Size = new System.Drawing.Size(167, 27);
            this.txtPeriodOutput.TabIndex = 1;
            this.txtPeriodOutput.Texts = "";
            this.txtPeriodOutput.UnderLineStyle = true;
            // 
            // txtCaption
            // 
            this.txtCaption.BackColor = System.Drawing.SystemColors.Window;
            this.txtCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtCaption.BorderFocusColor = System.Drawing.Color.Red;
            this.txtCaption.BorderRadius = 0;
            this.txtCaption.BorderSize = 1;
            this.txtCaption.ForeColor = System.Drawing.Color.DimGray;
            this.txtCaption.Location = new System.Drawing.Point(315, 75);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaption.MultiLine = false;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCaption.PasswordStyle = false;
            this.txtCaption.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCaption.PlaceholderText = "";
            this.txtCaption.Size = new System.Drawing.Size(167, 27);
            this.txtCaption.TabIndex = 0;
            this.txtCaption.Texts = "";
            this.txtCaption.UnderLineStyle = true;
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnCancelSettings.FlatAppearance.BorderSize = 0;
            this.btnCancelSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSettings.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelSettings.Location = new System.Drawing.Point(422, 263);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCancelSettings.Size = new System.Drawing.Size(180, 70);
            this.btnCancelSettings.TabIndex = 3;
            this.btnCancelSettings.Text = "Назад";
            this.btnCancelSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelSettings.UseVisualStyleBackColor = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSettings.Location = new System.Drawing.Point(219, 263);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSaveSettings.Size = new System.Drawing.Size(180, 70);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // lblPeriodOutput
            // 
            this.lblPeriodOutput.AutoSize = true;
            this.lblPeriodOutput.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPeriodOutput.Location = new System.Drawing.Point(329, 119);
            this.lblPeriodOutput.Name = "lblPeriodOutput";
            this.lblPeriodOutput.Size = new System.Drawing.Size(141, 18);
            this.lblPeriodOutput.TabIndex = 2;
            this.lblPeriodOutput.Text = "период выхода";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.Location = new System.Drawing.Point(334, 38);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(136, 18);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "наименование";
            // 
            // Press
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 443);
            this.Controls.Add(this.tabControlPress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Press";
            this.Text = "Издания";
            this.Load += new System.EventHandler(this.Press_Load);
            this.tabControlPress.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPress)).EndInit();
            this.ExportContextMenu.ResumeLayout(false);
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPress;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.Button btnEditPress;
        private System.Windows.Forms.Button btnSearchPress;
        public System.Windows.Forms.DataGridView gridPress;
        private System.Windows.Forms.Button btnAddPress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelPress;
        private System.Windows.Forms.Button btnLoadPress;
        private System.Windows.Forms.Button btnExportPress;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblPeriodOutput;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ContextMenuStrip ExportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private OwnControls.Controls.Modern_TextBox txtPress;
        private OwnControls.Controls.Modern_TextBox txtPeriodOutput;
        private OwnControls.Controls.Modern_TextBox txtCaption;
    }
}