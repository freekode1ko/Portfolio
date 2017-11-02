namespace CompShop
{
    partial class Tov
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tQUADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOVARsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet1 = new CompShop.ClientDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клинетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.зайтиКакДругойПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinusBox = new System.Windows.Forms.ToolStripTextBox();
            this.вычетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlusBox = new System.Windows.Forms.ToolStripTextBox();
            this.дабавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тЕСТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_TOVARS = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_TRANZ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.сформироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOVARsTableAdapter = new CompShop.ClientDataSet1TableAdapters.TOVARsTableAdapter();
            this.fACILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACILTableAdapter = new CompShop.ClientDataSet1TableAdapters.FACILTableAdapter();
            this.tableAdapterManager = new CompShop.ClientDataSet1TableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tNAMEDataGridViewTextBoxColumn,
            this.tFACDataGridViewTextBoxColumn,
            this.tQUADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tOVARsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(466, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // tNAMEDataGridViewTextBoxColumn
            // 
            this.tNAMEDataGridViewTextBoxColumn.DataPropertyName = "T_NAME";
            this.tNAMEDataGridViewTextBoxColumn.HeaderText = "Название";
            this.tNAMEDataGridViewTextBoxColumn.Name = "tNAMEDataGridViewTextBoxColumn";
            this.tNAMEDataGridViewTextBoxColumn.Width = 140;
            // 
            // tFACDataGridViewTextBoxColumn
            // 
            this.tFACDataGridViewTextBoxColumn.DataPropertyName = "T_COLOR";
            this.tFACDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.tFACDataGridViewTextBoxColumn.Name = "tFACDataGridViewTextBoxColumn";
            this.tFACDataGridViewTextBoxColumn.Width = 160;
            // 
            // tQUADataGridViewTextBoxColumn
            // 
            this.tQUADataGridViewTextBoxColumn.DataPropertyName = "T_QUA";
            this.tQUADataGridViewTextBoxColumn.HeaderText = "Колличество";
            this.tQUADataGridViewTextBoxColumn.Name = "tQUADataGridViewTextBoxColumn";
            // 
            // tOVARsBindingSource
            // 
            this.tOVARsBindingSource.DataMember = "TOVARs";
            this.tOVARsBindingSource.DataSource = this.clientDataSet1;
            // 
            // clientDataSet1
            // 
            this.clientDataSet1.DataSetName = "ClientDataSet1";
            this.clientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.продажаToolStripMenuItem,
            this.поставкаToolStripMenuItem,
            this.производителиToolStripMenuItem,
            this.тЕСТToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клинетыToolStripMenuItem,
            this.toolStripSeparator1,
            this.зайтиКакДругойПользовательToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // клинетыToolStripMenuItem
            // 
            this.клинетыToolStripMenuItem.Name = "клинетыToolStripMenuItem";
            this.клинетыToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.клинетыToolStripMenuItem.Text = "Клинеты";
            this.клинетыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // зайтиКакДругойПользовательToolStripMenuItem
            // 
            this.зайтиКакДругойПользовательToolStripMenuItem.Name = "зайтиКакДругойПользовательToolStripMenuItem";
            this.зайтиКакДругойПользовательToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.зайтиКакДругойПользовательToolStripMenuItem.Text = "Зайти как другой пользователь";
            this.зайтиКакДругойПользовательToolStripMenuItem.Click += new System.EventHandler(this.зайтиКакДругойПользовательToolStripMenuItem_Click);
            // 
            // продажаToolStripMenuItem
            // 
            this.продажаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MinusBox,
            this.вычетToolStripMenuItem});
            this.продажаToolStripMenuItem.Name = "продажаToolStripMenuItem";
            this.продажаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.продажаToolStripMenuItem.Text = "Продажа";
            // 
            // MinusBox
            // 
            this.MinusBox.MaxLength = 8;
            this.MinusBox.Name = "MinusBox";
            this.MinusBox.Size = new System.Drawing.Size(100, 23);
            this.MinusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // вычетToolStripMenuItem
            // 
            this.вычетToolStripMenuItem.Name = "вычетToolStripMenuItem";
            this.вычетToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.вычетToolStripMenuItem.Text = "Вычет";
            this.вычетToolStripMenuItem.Click += new System.EventHandler(this.продатьToolStripMenuItem_Click);
            // 
            // поставкаToolStripMenuItem
            // 
            this.поставкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlusBox,
            this.дабавитьToolStripMenuItem});
            this.поставкаToolStripMenuItem.Name = "поставкаToolStripMenuItem";
            this.поставкаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.поставкаToolStripMenuItem.Text = "Поставка";
            // 
            // PlusBox
            // 
            this.PlusBox.MaxLength = 8;
            this.PlusBox.Name = "PlusBox";
            this.PlusBox.Size = new System.Drawing.Size(100, 23);
            this.PlusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // дабавитьToolStripMenuItem
            // 
            this.дабавитьToolStripMenuItem.Name = "дабавитьToolStripMenuItem";
            this.дабавитьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.дабавитьToolStripMenuItem.Text = "Дабавить";
            this.дабавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производительToolStripMenuItem});
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.производителиToolStripMenuItem.Text = "Больше о товарах";
            // 
            // производительToolStripMenuItem
            // 
            this.производительToolStripMenuItem.Name = "производительToolStripMenuItem";
            this.производительToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.производительToolStripMenuItem.Text = "Производитель";
            this.производительToolStripMenuItem.Click += new System.EventHandler(this.производительToolStripMenuItem_Click);
            // 
            // тЕСТToolStripMenuItem
            // 
            this.тЕСТToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CB_TOVARS,
            this.CB_TRANZ,
            this.toolStripSeparator2,
            this.сформироватьToolStripMenuItem});
            this.тЕСТToolStripMenuItem.Name = "тЕСТToolStripMenuItem";
            this.тЕСТToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.тЕСТToolStripMenuItem.Text = "Чек";
            // 
            // CB_TOVARS
            // 
            this.CB_TOVARS.Checked = true;
            this.CB_TOVARS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_TOVARS.Name = "CB_TOVARS";
            this.CB_TOVARS.Size = new System.Drawing.Size(181, 22);
            this.CB_TOVARS.Text = "Список товаров";
            this.CB_TOVARS.Click += new System.EventHandler(this.TOVchek_Click);
            // 
            // CB_TRANZ
            // 
            this.CB_TRANZ.Checked = true;
            this.CB_TRANZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_TRANZ.Name = "CB_TRANZ";
            this.CB_TRANZ.Size = new System.Drawing.Size(181, 22);
            this.CB_TRANZ.Text = "Список транзакций";
            this.CB_TRANZ.Click += new System.EventHandler(this.CB_TRANZ_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // сформироватьToolStripMenuItem
            // 
            this.сформироватьToolStripMenuItem.Name = "сформироватьToolStripMenuItem";
            this.сформироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сформироватьToolStripMenuItem.Text = "Сформировать";
            this.сформироватьToolStripMenuItem.Click += new System.EventHandler(this.Chek_Click);
            // 
            // tOVARsTableAdapter
            // 
            this.tOVARsTableAdapter.ClearBeforeFill = true;
            // 
            // fACILBindingSource
            // 
            this.fACILBindingSource.DataMember = "FACIL";
            this.fACILBindingSource.DataSource = this.clientDataSet1;
            // 
            // fACILTableAdapter
            // 
            this.fACILTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BYERsTableAdapter = null;
            this.tableAdapterManager.FACILTableAdapter = this.fACILTableAdapter;
            this.tableAdapterManager.TOVARsTableAdapter = this.tOVARsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CompShop.ClientDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERsTableAdapter = null;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(346, 191);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            // 
            // Tov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tov";
            this.Text = "Товары";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tov_FormClosing);
            this.Load += new System.EventHandler(this.Tov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACILBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClientDataSet1 clientDataSet1;
        private System.Windows.Forms.BindingSource tOVARsBindingSource;
        private ClientDataSet1TableAdapters.TOVARsTableAdapter tOVARsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клинетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem зайтиКакДругойПользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox MinusBox;
        private System.Windows.Forms.ToolStripMenuItem вычетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PlusBox;
        private System.Windows.Forms.ToolStripMenuItem дабавитьToolStripMenuItem;
        private System.Windows.Forms.BindingSource fACILBindingSource;
        private ClientDataSet1TableAdapters.FACILTableAdapter fACILTableAdapter;
        private ClientDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tQUADataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тЕСТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CB_TOVARS;
        private System.Windows.Forms.ToolStripMenuItem CB_TRANZ;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem сформироватьToolStripMenuItem;
    }
}