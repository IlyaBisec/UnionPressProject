
namespace UnionPressOnSharp
{
    partial class TablesForms
    {
        
        private System.ComponentModel.IContainer components = null;

        
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

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForms));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbPage1 = new System.Windows.Forms.TabPage();
            this.tbPage2 = new System.Windows.Forms.TabPage();
            this.tbPage3 = new System.Windows.Forms.TabPage();
            this.tbPage4 = new System.Windows.Forms.TabPage();
            this.tbPage5 = new System.Windows.Forms.TabPage();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.souz_PechatiDataSet = new UnionPressOnSharp.Souz_PechatiDataSet();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.ДоставкаTableAdapter();
            this.tableAdapterManager = new UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.TableAdapterManager();
            this.изданияTableAdapter = new UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.ИзданияTableAdapter();
            this.периодические_изданияTableAdapter = new UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.Периодические_изданияTableAdapter();
            this.сотрудникиTableAdapter = new UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.СотрудникиTableAdapter();
            this.тип_изданийTableAdapter = new UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.Тип_изданийTableAdapter();
            this.изданияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.периодические_изданияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_изданийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.souz_PechatiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изданияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.периодические_изданияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_изданийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(801, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.экспортироватьВToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // экспортироватьВToolStripMenuItem
            // 
            this.экспортироватьВToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.экспортироватьВToolStripMenuItem.Name = "экспортироватьВToolStripMenuItem";
            this.экспортироватьВToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.экспортироватьВToolStripMenuItem.Text = "Экспортировать в";
            this.экспортироватьВToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьВToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.обАвтореToolStripMenuItem.Text = "Об Авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbPage1);
            this.tabControl.Controls.Add(this.tbPage2);
            this.tabControl.Controls.Add(this.tbPage3);
            this.tabControl.Controls.Add(this.tbPage4);
            this.tabControl.Controls.Add(this.tbPage5);
            this.tabControl.ItemSize = new System.Drawing.Size(58, 26);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(777, 24);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tbPage1
            // 
            this.tbPage1.Location = new System.Drawing.Point(4, 30);
            this.tbPage1.Name = "tbPage1";
            this.tbPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage1.Size = new System.Drawing.Size(769, 0);
            this.tbPage1.TabIndex = 0;
            this.tbPage1.Text = "Тип изданий";
            this.tbPage1.UseVisualStyleBackColor = true;
            // 
            // tbPage2
            // 
            this.tbPage2.Location = new System.Drawing.Point(4, 30);
            this.tbPage2.Name = "tbPage2";
            this.tbPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage2.Size = new System.Drawing.Size(769, 0);
            this.tbPage2.TabIndex = 1;
            this.tbPage2.Text = "Сотрудники";
            this.tbPage2.UseVisualStyleBackColor = true;
            // 
            // tbPage3
            // 
            this.tbPage3.Location = new System.Drawing.Point(4, 30);
            this.tbPage3.Name = "tbPage3";
            this.tbPage3.Size = new System.Drawing.Size(769, 0);
            this.tbPage3.TabIndex = 2;
            this.tbPage3.Text = "Период. издания";
            this.tbPage3.UseVisualStyleBackColor = true;
            // 
            // tbPage4
            // 
            this.tbPage4.Location = new System.Drawing.Point(4, 30);
            this.tbPage4.Name = "tbPage4";
            this.tbPage4.Size = new System.Drawing.Size(769, 0);
            this.tbPage4.TabIndex = 3;
            this.tbPage4.Text = "Издания";
            this.tbPage4.UseVisualStyleBackColor = true;
            // 
            // tbPage5
            // 
            this.tbPage5.Location = new System.Drawing.Point(4, 30);
            this.tbPage5.Name = "tbPage5";
            this.tbPage5.Size = new System.Drawing.Size(769, 0);
            this.tbPage5.TabIndex = 4;
            this.tbPage5.Text = "Доставка";
            this.tbPage5.UseVisualStyleBackColor = true;
            // 
            // MainGridView
            // 
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Location = new System.Drawing.Point(12, 63);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.Size = new System.Drawing.Size(773, 311);
            this.MainGridView.TabIndex = 2;
            this.MainGridView.Visible = false;
            this.MainGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridView_CellContentClick);
            // 
            // souz_PechatiDataSet
            // 
            this.souz_PechatiDataSet.DataSetName = "Souz_PechatiDataSet";
            this.souz_PechatiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.souz_PechatiDataSet;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = UnionPressOnSharp.Souz_PechatiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоставкаTableAdapter = this.доставкаTableAdapter;
            this.tableAdapterManager.ИзданияTableAdapter = this.изданияTableAdapter;
            this.tableAdapterManager.Периодические_изданияTableAdapter = this.периодические_изданияTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.Тип_изданийTableAdapter = this.тип_изданийTableAdapter;
            // 
            // изданияTableAdapter
            // 
            this.изданияTableAdapter.ClearBeforeFill = true;
            // 
            // периодические_изданияTableAdapter
            // 
            this.периодические_изданияTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // тип_изданийTableAdapter
            // 
            this.тип_изданийTableAdapter.ClearBeforeFill = true;
            // 
            // изданияBindingSource
            // 
            this.изданияBindingSource.DataMember = "Издания";
            this.изданияBindingSource.DataSource = this.souz_PechatiDataSet;
            // 
            // периодические_изданияBindingSource
            // 
            this.периодические_изданияBindingSource.DataMember = "Периодические издания";
            this.периодические_изданияBindingSource.DataSource = this.souz_PechatiDataSet;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.souz_PechatiDataSet;
            // 
            // тип_изданийBindingSource
            // 
            this.тип_изданийBindingSource.DataMember = "Тип изданий";
            this.тип_изданийBindingSource.DataSource = this.souz_PechatiDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 311);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(773, 311);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 63);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(773, 311);
            this.dataGridView3.TabIndex = 5;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 63);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(773, 311);
            this.dataGridView4.TabIndex = 6;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(12, 63);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(773, 311);
            this.dataGridView5.TabIndex = 7;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // TablesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 386);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MainGridView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TablesForms";
            this.Text = "Пустой прокет";
            this.Load += new System.EventHandler(this.TablesForms_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.souz_PechatiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изданияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.периодические_изданияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_изданийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbPage1;
        private System.Windows.Forms.TabPage tbPage2;
        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.TabPage tbPage3;
        private System.Windows.Forms.TabPage tbPage4;
        private System.Windows.Forms.TabPage tbPage5;
        private Souz_PechatiDataSet souz_PechatiDataSet;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private Souz_PechatiDataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private Souz_PechatiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Souz_PechatiDataSetTableAdapters.ИзданияTableAdapter изданияTableAdapter;
        private System.Windows.Forms.BindingSource изданияBindingSource;
        private Souz_PechatiDataSetTableAdapters.Периодические_изданияTableAdapter периодические_изданияTableAdapter;
        private System.Windows.Forms.BindingSource периодические_изданияBindingSource;
        private Souz_PechatiDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Souz_PechatiDataSetTableAdapters.Тип_изданийTableAdapter тип_изданийTableAdapter;
        private System.Windows.Forms.BindingSource тип_изданийBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}