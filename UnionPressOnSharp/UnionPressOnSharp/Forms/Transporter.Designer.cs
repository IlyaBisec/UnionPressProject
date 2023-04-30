namespace UnionPressOnSharp.Forms
{
    partial class Transporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transporter));
            this.tabControlTransporter = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.txtSearchTransporter = new OwnControls.Controls.Modern_TextBox();
            this.btnEditTransporter = new System.Windows.Forms.Button();
            this.btnSearchTransporter = new System.Windows.Forms.Button();
            this.gridTransporter = new System.Windows.Forms.DataGridView();
            this.btnAddTransporter = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelTransporter = new System.Windows.Forms.Button();
            this.btnLoadTransporter = new System.Windows.Forms.Button();
            this.btnExportTransporter = new System.Windows.Forms.Button();
            this.ExportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.txtEndDate = new OwnControls.Controls.Modern_TextBox();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblBeginDate = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtBeginDate = new OwnControls.Controls.Modern_TextBox();
            this.tabControlTransporter.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransporter)).BeginInit();
            this.ExportContextMenu.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTransporter
            // 
            this.tabControlTransporter.Controls.Add(this.pageMain);
            this.tabControlTransporter.Controls.Add(this.pageSettings);
            this.tabControlTransporter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTransporter.Location = new System.Drawing.Point(0, 0);
            this.tabControlTransporter.Name = "tabControlTransporter";
            this.tabControlTransporter.SelectedIndex = 0;
            this.tabControlTransporter.Size = new System.Drawing.Size(769, 443);
            this.tabControlTransporter.TabIndex = 13;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.txtSearchTransporter);
            this.pageMain.Controls.Add(this.btnEditTransporter);
            this.pageMain.Controls.Add(this.btnSearchTransporter);
            this.pageMain.Controls.Add(this.gridTransporter);
            this.pageMain.Controls.Add(this.btnAddTransporter);
            this.pageMain.Controls.Add(this.lblTitle);
            this.pageMain.Controls.Add(this.btnDelTransporter);
            this.pageMain.Controls.Add(this.btnLoadTransporter);
            this.pageMain.Controls.Add(this.btnExportTransporter);
            this.pageMain.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageMain.Location = new System.Drawing.Point(4, 22);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(761, 417);
            this.pageMain.TabIndex = 0;
            this.pageMain.Text = "Главная";
            this.pageMain.UseVisualStyleBackColor = true;
            // 
            // txtSearchTransporter
            // 
            this.txtSearchTransporter.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchTransporter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtSearchTransporter.BorderFocusColor = System.Drawing.Color.Red;
            this.txtSearchTransporter.BorderRadius = 0;
            this.txtSearchTransporter.BorderSize = 1;
            this.txtSearchTransporter.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchTransporter.Location = new System.Drawing.Point(9, 35);
            this.txtSearchTransporter.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchTransporter.MultiLine = false;
            this.txtSearchTransporter.Name = "txtSearchTransporter";
            this.txtSearchTransporter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchTransporter.PasswordStyle = false;
            this.txtSearchTransporter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchTransporter.PlaceholderText = "";
            this.txtSearchTransporter.Size = new System.Drawing.Size(543, 27);
            this.txtSearchTransporter.TabIndex = 14;
            this.txtSearchTransporter.Texts = "";
            this.txtSearchTransporter.UnderLineStyle = true;
            // 
            // btnEditTransporter
            // 
            this.btnEditTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTransporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEditTransporter.FlatAppearance.BorderSize = 0;
            this.btnEditTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTransporter.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTransporter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditTransporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTransporter.Location = new System.Drawing.Point(570, 216);
            this.btnEditTransporter.Name = "btnEditTransporter";
            this.btnEditTransporter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditTransporter.Size = new System.Drawing.Size(180, 55);
            this.btnEditTransporter.TabIndex = 10;
            this.btnEditTransporter.Text = "Изменить";
            this.btnEditTransporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTransporter.UseVisualStyleBackColor = false;
            // 
            // btnSearchTransporter
            // 
            this.btnSearchTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTransporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSearchTransporter.FlatAppearance.BorderSize = 0;
            this.btnSearchTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTransporter.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTransporter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchTransporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTransporter.Location = new System.Drawing.Point(570, 33);
            this.btnSearchTransporter.Name = "btnSearchTransporter";
            this.btnSearchTransporter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchTransporter.Size = new System.Drawing.Size(180, 55);
            this.btnSearchTransporter.TabIndex = 9;
            this.btnSearchTransporter.Text = "Поиск";
            this.btnSearchTransporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchTransporter.UseVisualStyleBackColor = false;
            // 
            // gridTransporter
            // 
            this.gridTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridTransporter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransporter.Location = new System.Drawing.Point(6, 66);
            this.gridTransporter.Name = "gridTransporter";
            this.gridTransporter.Size = new System.Drawing.Size(546, 335);
            this.gridTransporter.TabIndex = 0;
            // 
            // btnAddTransporter
            // 
            this.btnAddTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddTransporter.FlatAppearance.BorderSize = 0;
            this.btnAddTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransporter.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransporter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddTransporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTransporter.Location = new System.Drawing.Point(570, 155);
            this.btnAddTransporter.Name = "btnAddTransporter";
            this.btnAddTransporter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddTransporter.Size = new System.Drawing.Size(180, 55);
            this.btnAddTransporter.TabIndex = 2;
            this.btnAddTransporter.Text = "Добавить";
            this.btnAddTransporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTransporter.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Archive", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "поиск доставки:";
            // 
            // btnDelTransporter
            // 
            this.btnDelTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTransporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDelTransporter.FlatAppearance.BorderSize = 0;
            this.btnDelTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTransporter.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTransporter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelTransporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelTransporter.Location = new System.Drawing.Point(570, 277);
            this.btnDelTransporter.Name = "btnDelTransporter";
            this.btnDelTransporter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelTransporter.Size = new System.Drawing.Size(180, 55);
            this.btnDelTransporter.TabIndex = 4;
            this.btnDelTransporter.Text = "Удалить";
            this.btnDelTransporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelTransporter.UseVisualStyleBackColor = false;
            // 
            // btnLoadTransporter
            // 
            this.btnLoadTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTransporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLoadTransporter.FlatAppearance.BorderSize = 0;
            this.btnLoadTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTransporter.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTransporter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadTransporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadTransporter.Location = new System.Drawing.Point(570, 94);
            this.btnLoadTransporter.Name = "btnLoadTransporter";
            this.btnLoadTransporter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLoadTransporter.Size = new System.Drawing.Size(180, 55);
            this.btnLoadTransporter.TabIndex = 6;
            this.btnLoadTransporter.Text = "Загрузить";
            this.btnLoadTransporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadTransporter.UseVisualStyleBackColor = false;
            this.btnLoadTransporter.Click += new System.EventHandler(this.btnLoadTransporter_Click);
            // 
            // btnExportTransporter
            // 
            this.btnExportTransporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTransporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExportTransporter.ContextMenuStrip = this.ExportContextMenu;
            this.btnExportTransporter.FlatAppearance.BorderSize = 0;
            this.btnExportTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTransporter.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportTransporter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportTransporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportTransporter.Location = new System.Drawing.Point(570, 338);
            this.btnExportTransporter.Name = "btnExportTransporter";
            this.btnExportTransporter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExportTransporter.Size = new System.Drawing.Size(180, 55);
            this.btnExportTransporter.TabIndex = 5;
            this.btnExportTransporter.Text = "Экспорт";
            this.btnExportTransporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportTransporter.UseVisualStyleBackColor = false;
            this.btnExportTransporter.Click += new System.EventHandler(this.btnExportTransporter_Click);
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
            this.pageSettings.Controls.Add(this.txtBeginDate);
            this.pageSettings.Controls.Add(this.txtEndDate);
            this.pageSettings.Controls.Add(this.btnCancelSettings);
            this.pageSettings.Controls.Add(this.btnSaveSettings);
            this.pageSettings.Controls.Add(this.lblEndDate);
            this.pageSettings.Controls.Add(this.lblBeginDate);
            this.pageSettings.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(761, 417);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Настройки";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtEndDate.BorderFocusColor = System.Drawing.Color.Red;
            this.txtEndDate.BorderRadius = 0;
            this.txtEndDate.BorderSize = 1;
            this.txtEndDate.ForeColor = System.Drawing.Color.DimGray;
            this.txtEndDate.Location = new System.Drawing.Point(422, 124);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.MultiLine = false;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEndDate.PasswordStyle = false;
            this.txtEndDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEndDate.PlaceholderText = "";
            this.txtEndDate.Size = new System.Drawing.Size(169, 27);
            this.txtEndDate.TabIndex = 1;
            this.txtEndDate.Texts = "";
            this.txtEndDate.UnderLineStyle = true;
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
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.Location = new System.Drawing.Point(419, 89);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(147, 18);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "дата окончания";
            // 
            // lblBeginDate
            // 
            this.lblBeginDate.AutoSize = true;
            this.lblBeginDate.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBeginDate.Location = new System.Drawing.Point(227, 89);
            this.lblBeginDate.Name = "lblBeginDate";
            this.lblBeginDate.Size = new System.Drawing.Size(115, 18);
            this.lblBeginDate.TabIndex = 0;
            this.lblBeginDate.Text = "дата начала";
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBeginDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtBeginDate.BorderFocusColor = System.Drawing.Color.Red;
            this.txtBeginDate.BorderRadius = 0;
            this.txtBeginDate.BorderSize = 1;
            this.txtBeginDate.ForeColor = System.Drawing.Color.DimGray;
            this.txtBeginDate.Location = new System.Drawing.Point(219, 124);
            this.txtBeginDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeginDate.MultiLine = false;
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBeginDate.PasswordStyle = false;
            this.txtBeginDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBeginDate.PlaceholderText = "";
            this.txtBeginDate.Size = new System.Drawing.Size(169, 27);
            this.txtBeginDate.TabIndex = 0;
            this.txtBeginDate.Texts = "";
            this.txtBeginDate.UnderLineStyle = true;
            // 
            // Transporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 443);
            this.Controls.Add(this.tabControlTransporter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transporter";
            this.Text = "Доставка";
            this.Load += new System.EventHandler(this.Transporter_Load);
            this.tabControlTransporter.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransporter)).EndInit();
            this.ExportContextMenu.ResumeLayout(false);
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTransporter;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.Button btnEditTransporter;
        private System.Windows.Forms.Button btnSearchTransporter;
        private System.Windows.Forms.DataGridView gridTransporter;
        private System.Windows.Forms.Button btnAddTransporter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelTransporter;
        private System.Windows.Forms.Button btnLoadTransporter;
        private System.Windows.Forms.Button btnExportTransporter;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblBeginDate;
        private System.Windows.Forms.ContextMenuStrip ExportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private OwnControls.Controls.Modern_TextBox txtSearchTransporter;
        private OwnControls.Controls.Modern_TextBox txtEndDate;
        private OwnControls.Controls.Modern_TextBox txtBeginDate;
    }
}