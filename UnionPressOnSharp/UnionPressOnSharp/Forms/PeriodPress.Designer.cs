namespace UnionPressOnSharp.Forms
{
    partial class PeriodPress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodPress));
            this.tabControlPeriod = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.txtPeriod = new OwnControls.Controls.Modern_TextBox();
            this.btnEditPeriod = new System.Windows.Forms.Button();
            this.btnSearchPeriod = new System.Windows.Forms.Button();
            this.gridPeriod = new System.Windows.Forms.DataGridView();
            this.btnAddPeriod = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelPeriod = new System.Windows.Forms.Button();
            this.btnLoadPeriod = new System.Windows.Forms.Button();
            this.btnExportPeriod = new System.Windows.Forms.Button();
            this.ExportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblPopularity = new System.Windows.Forms.Label();
            this.lblChoiceTransp = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblSrok = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtSrok = new OwnControls.Controls.Modern_TextBox();
            this.txtPopularity = new OwnControls.Controls.Modern_TextBox();
            this.txtSell = new OwnControls.Controls.Modern_TextBox();
            this.txtChoiceTransp = new OwnControls.Controls.Modern_TextBox();
            this.tabControlPeriod.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriod)).BeginInit();
            this.ExportContextMenu.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPeriod
            // 
            this.tabControlPeriod.Controls.Add(this.pageMain);
            this.tabControlPeriod.Controls.Add(this.pageSettings);
            this.tabControlPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPeriod.Location = new System.Drawing.Point(0, 0);
            this.tabControlPeriod.Name = "tabControlPeriod";
            this.tabControlPeriod.SelectedIndex = 0;
            this.tabControlPeriod.Size = new System.Drawing.Size(769, 443);
            this.tabControlPeriod.TabIndex = 13;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.txtPeriod);
            this.pageMain.Controls.Add(this.btnEditPeriod);
            this.pageMain.Controls.Add(this.btnSearchPeriod);
            this.pageMain.Controls.Add(this.gridPeriod);
            this.pageMain.Controls.Add(this.btnAddPeriod);
            this.pageMain.Controls.Add(this.lblTitle);
            this.pageMain.Controls.Add(this.btnDelPeriod);
            this.pageMain.Controls.Add(this.btnLoadPeriod);
            this.pageMain.Controls.Add(this.btnExportPeriod);
            this.pageMain.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageMain.Location = new System.Drawing.Point(4, 22);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(761, 417);
            this.pageMain.TabIndex = 0;
            this.pageMain.Text = "Главная";
            this.pageMain.UseVisualStyleBackColor = true;
            // 
            // txtPeriod
            // 
            this.txtPeriod.BackColor = System.Drawing.SystemColors.Window;
            this.txtPeriod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtPeriod.BorderFocusColor = System.Drawing.Color.Red;
            this.txtPeriod.BorderRadius = 0;
            this.txtPeriod.BorderSize = 1;
            this.txtPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeriod.Location = new System.Drawing.Point(6, 35);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriod.MultiLine = false;
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeriod.PasswordStyle = false;
            this.txtPeriod.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeriod.PlaceholderText = "";
            this.txtPeriod.Size = new System.Drawing.Size(546, 27);
            this.txtPeriod.TabIndex = 14;
            this.txtPeriod.Texts = "";
            this.txtPeriod.UnderLineStyle = true;
            // 
            // btnEditPeriod
            // 
            this.btnEditPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEditPeriod.FlatAppearance.BorderSize = 0;
            this.btnEditPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPeriod.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPeriod.Location = new System.Drawing.Point(570, 216);
            this.btnEditPeriod.Name = "btnEditPeriod";
            this.btnEditPeriod.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditPeriod.Size = new System.Drawing.Size(180, 55);
            this.btnEditPeriod.TabIndex = 10;
            this.btnEditPeriod.Text = "Изменить";
            this.btnEditPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPeriod.UseVisualStyleBackColor = false;
            // 
            // btnSearchPeriod
            // 
            this.btnSearchPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSearchPeriod.FlatAppearance.BorderSize = 0;
            this.btnSearchPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPeriod.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPeriod.Location = new System.Drawing.Point(570, 33);
            this.btnSearchPeriod.Name = "btnSearchPeriod";
            this.btnSearchPeriod.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchPeriod.Size = new System.Drawing.Size(180, 55);
            this.btnSearchPeriod.TabIndex = 9;
            this.btnSearchPeriod.Text = "Поиск";
            this.btnSearchPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPeriod.UseVisualStyleBackColor = false;
            // 
            // gridPeriod
            // 
            this.gridPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeriod.Location = new System.Drawing.Point(6, 66);
            this.gridPeriod.Name = "gridPeriod";
            this.gridPeriod.Size = new System.Drawing.Size(546, 335);
            this.gridPeriod.TabIndex = 0;
            // 
            // btnAddPeriod
            // 
            this.btnAddPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddPeriod.FlatAppearance.BorderSize = 0;
            this.btnAddPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeriod.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPeriod.Location = new System.Drawing.Point(570, 155);
            this.btnAddPeriod.Name = "btnAddPeriod";
            this.btnAddPeriod.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddPeriod.Size = new System.Drawing.Size(180, 55);
            this.btnAddPeriod.TabIndex = 2;
            this.btnAddPeriod.Text = "Добавить";
            this.btnAddPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPeriod.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Archive", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "поиск периодич. печати:";
            // 
            // btnDelPeriod
            // 
            this.btnDelPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDelPeriod.FlatAppearance.BorderSize = 0;
            this.btnDelPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPeriod.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPeriod.Location = new System.Drawing.Point(570, 277);
            this.btnDelPeriod.Name = "btnDelPeriod";
            this.btnDelPeriod.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelPeriod.Size = new System.Drawing.Size(180, 55);
            this.btnDelPeriod.TabIndex = 4;
            this.btnDelPeriod.Text = "Удалить";
            this.btnDelPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelPeriod.UseVisualStyleBackColor = false;
            // 
            // btnLoadPeriod
            // 
            this.btnLoadPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLoadPeriod.FlatAppearance.BorderSize = 0;
            this.btnLoadPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPeriod.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPeriod.Location = new System.Drawing.Point(570, 94);
            this.btnLoadPeriod.Name = "btnLoadPeriod";
            this.btnLoadPeriod.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLoadPeriod.Size = new System.Drawing.Size(180, 55);
            this.btnLoadPeriod.TabIndex = 6;
            this.btnLoadPeriod.Text = "Загрузить";
            this.btnLoadPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPeriod.UseVisualStyleBackColor = false;
            this.btnLoadPeriod.Click += new System.EventHandler(this.btnLoadPeriod_Click);
            // 
            // btnExportPeriod
            // 
            this.btnExportPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnExportPeriod.ContextMenuStrip = this.ExportContextMenu;
            this.btnExportPeriod.FlatAppearance.BorderSize = 0;
            this.btnExportPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPeriod.Font = new System.Drawing.Font("Archive", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPeriod.Location = new System.Drawing.Point(570, 338);
            this.btnExportPeriod.Name = "btnExportPeriod";
            this.btnExportPeriod.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExportPeriod.Size = new System.Drawing.Size(180, 55);
            this.btnExportPeriod.TabIndex = 5;
            this.btnExportPeriod.Text = "Экспорт";
            this.btnExportPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportPeriod.UseVisualStyleBackColor = false;
            this.btnExportPeriod.Click += new System.EventHandler(this.btnExportPeriod_Click);
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
            this.pageSettings.Controls.Add(this.txtChoiceTransp);
            this.pageSettings.Controls.Add(this.txtSell);
            this.pageSettings.Controls.Add(this.txtPopularity);
            this.pageSettings.Controls.Add(this.txtSrok);
            this.pageSettings.Controls.Add(this.btnCancelSettings);
            this.pageSettings.Controls.Add(this.btnSaveSettings);
            this.pageSettings.Controls.Add(this.lblPopularity);
            this.pageSettings.Controls.Add(this.lblChoiceTransp);
            this.pageSettings.Controls.Add(this.lblSell);
            this.pageSettings.Controls.Add(this.lblSrok);
            this.pageSettings.Font = new System.Drawing.Font("Archive", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(761, 417);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Настройки";
            this.pageSettings.UseVisualStyleBackColor = true;
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
            this.btnCancelSettings.TabIndex = 5;
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
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // lblPopularity
            // 
            this.lblPopularity.AutoSize = true;
            this.lblPopularity.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPopularity.Location = new System.Drawing.Point(418, 102);
            this.lblPopularity.Name = "lblPopularity";
            this.lblPopularity.Size = new System.Drawing.Size(132, 18);
            this.lblPopularity.TabIndex = 6;
            this.lblPopularity.Text = "популярность";
            // 
            // lblChoiceTransp
            // 
            this.lblChoiceTransp.AutoSize = true;
            this.lblChoiceTransp.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoiceTransp.Location = new System.Drawing.Point(216, 102);
            this.lblChoiceTransp.Name = "lblChoiceTransp";
            this.lblChoiceTransp.Size = new System.Drawing.Size(156, 18);
            this.lblChoiceTransp.TabIndex = 4;
            this.lblChoiceTransp.Text = "способ доставки";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSell.Location = new System.Drawing.Point(419, 37);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(99, 18);
            this.lblSell.TabIndex = 2;
            this.lblSell.Text = "стоимость";
            // 
            // lblSrok
            // 
            this.lblSrok.AutoSize = true;
            this.lblSrok.Font = new System.Drawing.Font("Archive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSrok.Location = new System.Drawing.Point(216, 35);
            this.lblSrok.Name = "lblSrok";
            this.lblSrok.Size = new System.Drawing.Size(137, 18);
            this.lblSrok.TabIndex = 0;
            this.lblSrok.Text = "Срок подписки";
            // 
            // txtSrok
            // 
            this.txtSrok.BackColor = System.Drawing.SystemColors.Window;
            this.txtSrok.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtSrok.BorderFocusColor = System.Drawing.Color.Red;
            this.txtSrok.BorderRadius = 0;
            this.txtSrok.BorderSize = 1;
            this.txtSrok.ForeColor = System.Drawing.Color.DimGray;
            this.txtSrok.Location = new System.Drawing.Point(219, 60);
            this.txtSrok.Margin = new System.Windows.Forms.Padding(4);
            this.txtSrok.MultiLine = false;
            this.txtSrok.Name = "txtSrok";
            this.txtSrok.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSrok.PasswordStyle = false;
            this.txtSrok.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSrok.PlaceholderText = "";
            this.txtSrok.Size = new System.Drawing.Size(167, 27);
            this.txtSrok.TabIndex = 0;
            this.txtSrok.Texts = "";
            this.txtSrok.UnderLineStyle = true;
            // 
            // txtPopularity
            // 
            this.txtPopularity.BackColor = System.Drawing.SystemColors.Window;
            this.txtPopularity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtPopularity.BorderFocusColor = System.Drawing.Color.Red;
            this.txtPopularity.BorderRadius = 0;
            this.txtPopularity.BorderSize = 1;
            this.txtPopularity.ForeColor = System.Drawing.Color.DimGray;
            this.txtPopularity.Location = new System.Drawing.Point(421, 137);
            this.txtPopularity.Margin = new System.Windows.Forms.Padding(4);
            this.txtPopularity.MultiLine = false;
            this.txtPopularity.Name = "txtPopularity";
            this.txtPopularity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPopularity.PasswordStyle = false;
            this.txtPopularity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPopularity.PlaceholderText = "";
            this.txtPopularity.Size = new System.Drawing.Size(167, 27);
            this.txtPopularity.TabIndex = 3;
            this.txtPopularity.Texts = "";
            this.txtPopularity.UnderLineStyle = true;
            // 
            // txtSell
            // 
            this.txtSell.BackColor = System.Drawing.SystemColors.Window;
            this.txtSell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtSell.BorderFocusColor = System.Drawing.Color.Red;
            this.txtSell.BorderRadius = 0;
            this.txtSell.BorderSize = 1;
            this.txtSell.ForeColor = System.Drawing.Color.DimGray;
            this.txtSell.Location = new System.Drawing.Point(421, 60);
            this.txtSell.Margin = new System.Windows.Forms.Padding(4);
            this.txtSell.MultiLine = false;
            this.txtSell.Name = "txtSell";
            this.txtSell.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSell.PasswordStyle = false;
            this.txtSell.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSell.PlaceholderText = "";
            this.txtSell.Size = new System.Drawing.Size(167, 27);
            this.txtSell.TabIndex = 1;
            this.txtSell.Texts = "";
            this.txtSell.UnderLineStyle = true;
            // 
            // txtChoiceTransp
            // 
            this.txtChoiceTransp.BackColor = System.Drawing.SystemColors.Window;
            this.txtChoiceTransp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.txtChoiceTransp.BorderFocusColor = System.Drawing.Color.Red;
            this.txtChoiceTransp.BorderRadius = 0;
            this.txtChoiceTransp.BorderSize = 1;
            this.txtChoiceTransp.ForeColor = System.Drawing.Color.DimGray;
            this.txtChoiceTransp.Location = new System.Drawing.Point(219, 137);
            this.txtChoiceTransp.Margin = new System.Windows.Forms.Padding(4);
            this.txtChoiceTransp.MultiLine = false;
            this.txtChoiceTransp.Name = "txtChoiceTransp";
            this.txtChoiceTransp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtChoiceTransp.PasswordStyle = false;
            this.txtChoiceTransp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChoiceTransp.PlaceholderText = "";
            this.txtChoiceTransp.Size = new System.Drawing.Size(167, 27);
            this.txtChoiceTransp.TabIndex = 2;
            this.txtChoiceTransp.Texts = "";
            this.txtChoiceTransp.UnderLineStyle = true;
            // 
            // PeriodPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 443);
            this.Controls.Add(this.tabControlPeriod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeriodPress";
            this.Text = "Периодические издания";
            this.Load += new System.EventHandler(this.PeriodPress_Load);
            this.tabControlPeriod.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriod)).EndInit();
            this.ExportContextMenu.ResumeLayout(false);
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPeriod;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.Button btnEditPeriod;
        private System.Windows.Forms.Button btnSearchPeriod;
        private System.Windows.Forms.DataGridView gridPeriod;
        private System.Windows.Forms.Button btnAddPeriod;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelPeriod;
        private System.Windows.Forms.Button btnLoadPeriod;
        private System.Windows.Forms.Button btnExportPeriod;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblPopularity;
        private System.Windows.Forms.Label lblChoiceTransp;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblSrok;
        private System.Windows.Forms.ContextMenuStrip ExportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuItemExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private OwnControls.Controls.Modern_TextBox txtPeriod;
        private OwnControls.Controls.Modern_TextBox txtChoiceTransp;
        private OwnControls.Controls.Modern_TextBox txtSell;
        private OwnControls.Controls.Modern_TextBox txtPopularity;
        private OwnControls.Controls.Modern_TextBox txtSrok;
    }
}