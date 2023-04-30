namespace UnionPressOnSharp.Forms
{
    partial class Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.gridW = new System.Windows.Forms.DataGridView();
            this.btnAddW = new System.Windows.Forms.Button();
            this.btnDelW = new System.Windows.Forms.Button();
            this.btnExportW = new System.Windows.Forms.Button();
            this.ExportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadW = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControlW = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.txtW = new OwnControls.Controls.Modern_TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.txtName = new OwnControls.Controls.Modern_TextBox();
            this.txtNumber = new OwnControls.Controls.Modern_TextBox();
            this.txtFatherName = new OwnControls.Controls.Modern_TextBox();
            this.txtSpecial = new OwnControls.Controls.Modern_TextBox();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtSurname = new OwnControls.Controls.Modern_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridW)).BeginInit();
            this.ExportContextMenu.SuspendLayout();
            this.tabControlW.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridW
            // 
            this.gridW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridW.Location = new System.Drawing.Point(6, 66);
            this.gridW.Name = "gridW";
            this.gridW.Size = new System.Drawing.Size(546, 336);
            this.gridW.TabIndex = 0;
            // 
            // btnAddW
            // 
            this.btnAddW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddW.FlatAppearance.BorderSize = 0;
            this.btnAddW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddW.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddW.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddW.Location = new System.Drawing.Point(570, 155);
            this.btnAddW.Name = "btnAddW";
            this.btnAddW.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddW.Size = new System.Drawing.Size(180, 55);
            this.btnAddW.TabIndex = 2;
            this.btnAddW.Text = "Добавить";
            this.btnAddW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddW.UseVisualStyleBackColor = false;
            this.btnAddW.Click += new System.EventHandler(this.btnAddW_Click);
            // 
            // btnDelW
            // 
            this.btnDelW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDelW.FlatAppearance.BorderSize = 0;
            this.btnDelW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelW.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelW.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelW.Location = new System.Drawing.Point(570, 277);
            this.btnDelW.Name = "btnDelW";
            this.btnDelW.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelW.Size = new System.Drawing.Size(180, 55);
            this.btnDelW.TabIndex = 4;
            this.btnDelW.Text = "Удалить";
            this.btnDelW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelW.UseVisualStyleBackColor = false;
            this.btnDelW.Click += new System.EventHandler(this.btnDelW_Click);
            // 
            // btnExportW
            // 
            this.btnExportW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExportW.ContextMenuStrip = this.ExportContextMenu;
            this.btnExportW.FlatAppearance.BorderSize = 0;
            this.btnExportW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportW.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportW.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportW.Location = new System.Drawing.Point(570, 338);
            this.btnExportW.Name = "btnExportW";
            this.btnExportW.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExportW.Size = new System.Drawing.Size(180, 55);
            this.btnExportW.TabIndex = 5;
            this.btnExportW.Text = "Экспорт";
            this.btnExportW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportW.UseVisualStyleBackColor = false;
            this.btnExportW.Click += new System.EventHandler(this.btnExportW_Click);
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
            // btnLoadW
            // 
            this.btnLoadW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLoadW.FlatAppearance.BorderSize = 0;
            this.btnLoadW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadW.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadW.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadW.Location = new System.Drawing.Point(570, 94);
            this.btnLoadW.Name = "btnLoadW";
            this.btnLoadW.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLoadW.Size = new System.Drawing.Size(180, 55);
            this.btnLoadW.TabIndex = 6;
            this.btnLoadW.Text = "Загрузить";
            this.btnLoadW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadW.UseVisualStyleBackColor = false;
            this.btnLoadW.Click += new System.EventHandler(this.btnLoadW_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Archive", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "поиск работника:";
            // 
            // tabControlW
            // 
            this.tabControlW.Controls.Add(this.pageMain);
            this.tabControlW.Controls.Add(this.pageSettings);
            this.tabControlW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlW.Location = new System.Drawing.Point(0, 0);
            this.tabControlW.Name = "tabControlW";
            this.tabControlW.SelectedIndex = 0;
            this.tabControlW.Size = new System.Drawing.Size(769, 444);
            this.tabControlW.TabIndex = 11;
            // 
            // pageMain
            // 
            this.pageMain.BackColor = System.Drawing.Color.Transparent;
            this.pageMain.Controls.Add(this.txtW);
            this.pageMain.Controls.Add(this.btnEdit);
            this.pageMain.Controls.Add(this.btnSearch);
            this.pageMain.Controls.Add(this.gridW);
            this.pageMain.Controls.Add(this.btnAddW);
            this.pageMain.Controls.Add(this.lblTitle);
            this.pageMain.Controls.Add(this.btnDelW);
            this.pageMain.Controls.Add(this.btnLoadW);
            this.pageMain.Controls.Add(this.btnExportW);
            this.pageMain.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageMain.Location = new System.Drawing.Point(4, 22);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(761, 418);
            this.pageMain.TabIndex = 0;
            this.pageMain.Text = "Главная";
            // 
            // txtW
            // 
            this.txtW.BackColor = System.Drawing.SystemColors.Window;
            this.txtW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtW.BorderFocusColor = System.Drawing.Color.Red;
            this.txtW.BorderRadius = 0;
            this.txtW.BorderSize = 1;
            this.txtW.ForeColor = System.Drawing.Color.DimGray;
            this.txtW.Location = new System.Drawing.Point(9, 32);
            this.txtW.Margin = new System.Windows.Forms.Padding(4);
            this.txtW.MultiLine = false;
            this.txtW.Name = "txtW";
            this.txtW.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtW.PasswordStyle = false;
            this.txtW.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtW.PlaceholderText = "";
            this.txtW.Size = new System.Drawing.Size(543, 27);
            this.txtW.TabIndex = 11;
            this.txtW.Texts = "";
            this.txtW.UnderLineStyle = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(570, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(180, 55);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(570, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(180, 55);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.txtSurname);
            this.pageSettings.Controls.Add(this.txtName);
            this.pageSettings.Controls.Add(this.txtNumber);
            this.pageSettings.Controls.Add(this.txtFatherName);
            this.pageSettings.Controls.Add(this.txtSpecial);
            this.pageSettings.Controls.Add(this.btnCancelSettings);
            this.pageSettings.Controls.Add(this.btnSaveSettings);
            this.pageSettings.Controls.Add(this.lblNumber);
            this.pageSettings.Controls.Add(this.lblSpecial);
            this.pageSettings.Controls.Add(this.lblFatherName);
            this.pageSettings.Controls.Add(this.lblName);
            this.pageSettings.Controls.Add(this.lblSurname);
            this.pageSettings.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(761, 418);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Настройки";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.Red;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 1;
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(421, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordStyle = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(167, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "";
            this.txtName.UnderLineStyle = true;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtNumber.BorderFocusColor = System.Drawing.Color.Red;
            this.txtNumber.BorderRadius = 0;
            this.txtNumber.BorderSize = 1;
            this.txtNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber.Location = new System.Drawing.Point(219, 189);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.MultiLine = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumber.PasswordStyle = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.Size = new System.Drawing.Size(167, 27);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.Texts = "";
            this.txtNumber.UnderLineStyle = true;
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFatherName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtFatherName.BorderFocusColor = System.Drawing.Color.Red;
            this.txtFatherName.BorderRadius = 0;
            this.txtFatherName.BorderSize = 1;
            this.txtFatherName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFatherName.Location = new System.Drawing.Point(219, 108);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFatherName.MultiLine = false;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFatherName.PasswordStyle = false;
            this.txtFatherName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFatherName.PlaceholderText = "";
            this.txtFatherName.Size = new System.Drawing.Size(167, 27);
            this.txtFatherName.TabIndex = 2;
            this.txtFatherName.Texts = "";
            this.txtFatherName.UnderLineStyle = true;
            // 
            // txtSpecial
            // 
            this.txtSpecial.BackColor = System.Drawing.SystemColors.Window;
            this.txtSpecial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtSpecial.BorderFocusColor = System.Drawing.Color.Red;
            this.txtSpecial.BorderRadius = 0;
            this.txtSpecial.BorderSize = 1;
            this.txtSpecial.ForeColor = System.Drawing.Color.DimGray;
            this.txtSpecial.Location = new System.Drawing.Point(421, 108);
            this.txtSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecial.MultiLine = false;
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSpecial.PasswordStyle = false;
            this.txtSpecial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSpecial.PlaceholderText = "";
            this.txtSpecial.Size = new System.Drawing.Size(167, 27);
            this.txtSpecial.TabIndex = 3;
            this.txtSpecial.Texts = "";
            this.txtSpecial.UnderLineStyle = true;
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
            this.btnCancelSettings.TabIndex = 6;
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
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(216, 153);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(82, 18);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Телефон";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpecial.Location = new System.Drawing.Point(418, 73);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(142, 18);
            this.lblSpecial.TabIndex = 6;
            this.lblSpecial.Text = "Специальность";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFatherName.Location = new System.Drawing.Point(216, 73);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(88, 18);
            this.lblFatherName.TabIndex = 4;
            this.lblFatherName.Text = "Отчество";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(419, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "имя";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(216, 6);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(87, 18);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Фамилия";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtSurname.BorderFocusColor = System.Drawing.Color.Red;
            this.txtSurname.BorderRadius = 0;
            this.txtSurname.BorderSize = 1;
            this.txtSurname.ForeColor = System.Drawing.Color.DimGray;
            this.txtSurname.Location = new System.Drawing.Point(219, 30);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.MultiLine = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSurname.PasswordStyle = false;
            this.txtSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSurname.PlaceholderText = "";
            this.txtSurname.Size = new System.Drawing.Size(167, 27);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.Texts = "";
            this.txtSurname.UnderLineStyle = true;
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 444);
            this.Controls.Add(this.tabControlW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workers";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridW)).EndInit();
            this.ExportContextMenu.ResumeLayout(false);
            this.tabControlW.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridW;
        public System.Windows.Forms.Button btnAddW;
        public System.Windows.Forms.Button btnDelW;
        public System.Windows.Forms.Button btnExportW;
        public System.Windows.Forms.Button btnLoadW;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControlW;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.TabPage pageSettings;
        public System.Windows.Forms.Button btnCancelSettings;
        public System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip ExportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.Button btnSearch;
        private OwnControls.Controls.Modern_TextBox txtW;
        private OwnControls.Controls.Modern_TextBox txtName;
        private OwnControls.Controls.Modern_TextBox txtNumber;
        private OwnControls.Controls.Modern_TextBox txtFatherName;
        private OwnControls.Controls.Modern_TextBox txtSpecial;
        private OwnControls.Controls.Modern_TextBox txtSurname;
    }
}