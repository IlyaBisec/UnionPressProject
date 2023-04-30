namespace UnionPressOnSharp.Forms
{
    partial class TypePress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypePress));
            this.tabControlType = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.txtType = new OwnControls.Controls.Modern_TextBox();
            this.btnEditType = new System.Windows.Forms.Button();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.gridType = new System.Windows.Forms.DataGridView();
            this.btnAddType = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelType = new System.Windows.Forms.Button();
            this.btnLoadType = new System.Windows.Forms.Button();
            this.btnExportType = new System.Windows.Forms.Button();
            this.ExportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.txtSettingsType = new OwnControls.Controls.Modern_TextBox();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControlType.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).BeginInit();
            this.ExportContextMenu.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlType
            // 
            this.tabControlType.Controls.Add(this.pageMain);
            this.tabControlType.Controls.Add(this.pageSettings);
            this.tabControlType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlType.Location = new System.Drawing.Point(0, 0);
            this.tabControlType.Name = "tabControlType";
            this.tabControlType.SelectedIndex = 0;
            this.tabControlType.Size = new System.Drawing.Size(769, 443);
            this.tabControlType.TabIndex = 12;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.txtType);
            this.pageMain.Controls.Add(this.btnEditType);
            this.pageMain.Controls.Add(this.btnSearchType);
            this.pageMain.Controls.Add(this.gridType);
            this.pageMain.Controls.Add(this.btnAddType);
            this.pageMain.Controls.Add(this.lblTitle);
            this.pageMain.Controls.Add(this.btnDelType);
            this.pageMain.Controls.Add(this.btnLoadType);
            this.pageMain.Controls.Add(this.btnExportType);
            this.pageMain.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageMain.Location = new System.Drawing.Point(4, 22);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(761, 417);
            this.pageMain.TabIndex = 0;
            this.pageMain.Text = "Главная";
            this.pageMain.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.Window;
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtType.BorderFocusColor = System.Drawing.Color.Red;
            this.txtType.BorderRadius = 0;
            this.txtType.BorderSize = 1;
            this.txtType.ForeColor = System.Drawing.Color.DimGray;
            this.txtType.Location = new System.Drawing.Point(9, 35);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.MultiLine = false;
            this.txtType.Name = "txtType";
            this.txtType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtType.PasswordStyle = false;
            this.txtType.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtType.PlaceholderText = "";
            this.txtType.Size = new System.Drawing.Size(543, 27);
            this.txtType.TabIndex = 12;
            this.txtType.Texts = "";
            this.txtType.UnderLineStyle = true;
            // 
            // btnEditType
            // 
            this.btnEditType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEditType.FlatAppearance.BorderSize = 0;
            this.btnEditType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditType.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditType.Location = new System.Drawing.Point(570, 216);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditType.Size = new System.Drawing.Size(180, 55);
            this.btnEditType.TabIndex = 10;
            this.btnEditType.Text = "Изменить";
            this.btnEditType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditType.UseVisualStyleBackColor = false;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSearchType.FlatAppearance.BorderSize = 0;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchType.Location = new System.Drawing.Point(570, 33);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchType.Size = new System.Drawing.Size(180, 55);
            this.btnSearchType.TabIndex = 9;
            this.btnSearchType.Text = "Поиск";
            this.btnSearchType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchType.UseVisualStyleBackColor = false;
            // 
            // gridType
            // 
            this.gridType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridType.Location = new System.Drawing.Point(6, 66);
            this.gridType.Name = "gridType";
            this.gridType.Size = new System.Drawing.Size(546, 335);
            this.gridType.TabIndex = 0;
            // 
            // btnAddType
            // 
            this.btnAddType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddType.Location = new System.Drawing.Point(570, 155);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddType.Size = new System.Drawing.Size(180, 55);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.Text = "Добавить";
            this.btnAddType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddType.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Archive", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "поиск тип издания:";
            // 
            // btnDelType
            // 
            this.btnDelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDelType.FlatAppearance.BorderSize = 0;
            this.btnDelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelType.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelType.Location = new System.Drawing.Point(570, 277);
            this.btnDelType.Name = "btnDelType";
            this.btnDelType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelType.Size = new System.Drawing.Size(180, 55);
            this.btnDelType.TabIndex = 4;
            this.btnDelType.Text = "Удалить";
            this.btnDelType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelType.UseVisualStyleBackColor = false;
            // 
            // btnLoadType
            // 
            this.btnLoadType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLoadType.FlatAppearance.BorderSize = 0;
            this.btnLoadType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadType.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadType.Location = new System.Drawing.Point(570, 94);
            this.btnLoadType.Name = "btnLoadType";
            this.btnLoadType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLoadType.Size = new System.Drawing.Size(180, 55);
            this.btnLoadType.TabIndex = 6;
            this.btnLoadType.Text = "Загрузить";
            this.btnLoadType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadType.UseVisualStyleBackColor = false;
            this.btnLoadType.Click += new System.EventHandler(this.btnLoadType_Click);
            // 
            // btnExportType
            // 
            this.btnExportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExportType.ContextMenuStrip = this.ExportContextMenu;
            this.btnExportType.FlatAppearance.BorderSize = 0;
            this.btnExportType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportType.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportType.Location = new System.Drawing.Point(570, 338);
            this.btnExportType.Name = "btnExportType";
            this.btnExportType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExportType.Size = new System.Drawing.Size(180, 55);
            this.btnExportType.TabIndex = 5;
            this.btnExportType.Text = "Экспорт";
            this.btnExportType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportType.UseVisualStyleBackColor = false;
            this.btnExportType.Click += new System.EventHandler(this.btnExportType_Click);
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
            this.pageSettings.Controls.Add(this.txtSettingsType);
            this.pageSettings.Controls.Add(this.btnCancelSettings);
            this.pageSettings.Controls.Add(this.btnSaveSettings);
            this.pageSettings.Controls.Add(this.lblType);
            this.pageSettings.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(761, 417);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Настройки";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // txtSettingsType
            // 
            this.txtSettingsType.BackColor = System.Drawing.SystemColors.Window;
            this.txtSettingsType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtSettingsType.BorderFocusColor = System.Drawing.Color.Red;
            this.txtSettingsType.BorderRadius = 0;
            this.txtSettingsType.BorderSize = 1;
            this.txtSettingsType.ForeColor = System.Drawing.Color.DimGray;
            this.txtSettingsType.Location = new System.Drawing.Point(290, 134);
            this.txtSettingsType.Margin = new System.Windows.Forms.Padding(4);
            this.txtSettingsType.MultiLine = false;
            this.txtSettingsType.Name = "txtSettingsType";
            this.txtSettingsType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSettingsType.PasswordStyle = false;
            this.txtSettingsType.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSettingsType.PlaceholderText = "";
            this.txtSettingsType.Size = new System.Drawing.Size(167, 27);
            this.txtSettingsType.TabIndex = 0;
            this.txtSettingsType.Texts = "";
            this.txtSettingsType.UnderLineStyle = true;
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
            this.btnCancelSettings.TabIndex = 2;
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
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(360, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 18);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "тип";
            // 
            // TypePress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 443);
            this.Controls.Add(this.tabControlType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypePress";
            this.Text = "Тип издания";
            this.Load += new System.EventHandler(this.TypePress_Load);
            this.tabControlType.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).EndInit();
            this.ExportContextMenu.ResumeLayout(false);
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlType;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.DataGridView gridType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelType;
        private System.Windows.Forms.Button btnLoadType;
        private System.Windows.Forms.Button btnExportType;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ContextMenuStrip ExportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private OwnControls.Controls.Modern_TextBox txtType;
        private OwnControls.Controls.Modern_TextBox txtSettingsType;
    }
}