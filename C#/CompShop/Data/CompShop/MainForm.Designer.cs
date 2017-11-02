namespace CompShop
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.списокТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зайтиКакДругойПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDByerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byerSNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byerTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bYERsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet1 = new CompShop.ClientDataSet1();
            this.bYERsTableAdapter1 = new CompShop.ClientDataSet1TableAdapters.BYERsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bYERsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьБазуToolStripMenuItem,
            this.toolStripSeparator1,
            this.списокТоваровToolStripMenuItem,
            this.зайтиКакДругойПользовательToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // обновитьБазуToolStripMenuItem
            // 
            this.обновитьБазуToolStripMenuItem.Name = "обновитьБазуToolStripMenuItem";
            this.обновитьБазуToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.обновитьБазуToolStripMenuItem.Text = "Обновить базу";
            this.обновитьБазуToolStripMenuItem.Click += new System.EventHandler(this.обновитьБазуToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // списокТоваровToolStripMenuItem
            // 
            this.списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            this.списокТоваровToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.списокТоваровToolStripMenuItem.Text = "Список товаров";
            this.списокТоваровToolStripMenuItem.Click += new System.EventHandler(this.списокТоваровToolStripMenuItem_Click);
            // 
            // зайтиКакДругойПользовательToolStripMenuItem
            // 
            this.зайтиКакДругойПользовательToolStripMenuItem.Name = "зайтиКакДругойПользовательToolStripMenuItem";
            this.зайтиКакДругойПользовательToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.зайтиКакДругойПользовательToolStripMenuItem.Text = "Зайти как другой пользователь";
            this.зайтиКакДругойПользовательToolStripMenuItem.Click += new System.EventHandler(this.зайтиКакДругойПользовательToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDByerDataGridViewTextBoxColumn,
            this.byerFNameDataGridViewTextBoxColumn,
            this.byerSNameDataGridViewTextBoxColumn,
            this.byerTNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bYERsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 207);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDByerDataGridViewTextBoxColumn
            // 
            this.iDByerDataGridViewTextBoxColumn.DataPropertyName = "ID_Byer";
            this.iDByerDataGridViewTextBoxColumn.HeaderText = "ID_Byer";
            this.iDByerDataGridViewTextBoxColumn.Name = "iDByerDataGridViewTextBoxColumn";
            this.iDByerDataGridViewTextBoxColumn.Visible = false;
            // 
            // byerFNameDataGridViewTextBoxColumn
            // 
            this.byerFNameDataGridViewTextBoxColumn.DataPropertyName = "Byer_FName";
            this.byerFNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.byerFNameDataGridViewTextBoxColumn.Name = "byerFNameDataGridViewTextBoxColumn";
            // 
            // byerSNameDataGridViewTextBoxColumn
            // 
            this.byerSNameDataGridViewTextBoxColumn.DataPropertyName = "Byer_SName";
            this.byerSNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.byerSNameDataGridViewTextBoxColumn.Name = "byerSNameDataGridViewTextBoxColumn";
            this.byerSNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // byerTNameDataGridViewTextBoxColumn
            // 
            this.byerTNameDataGridViewTextBoxColumn.DataPropertyName = "Byer_TName";
            this.byerTNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.byerTNameDataGridViewTextBoxColumn.Name = "byerTNameDataGridViewTextBoxColumn";
            // 
            // bYERsBindingSource1
            // 
            this.bYERsBindingSource1.DataMember = "BYERs";
            this.bYERsBindingSource1.DataSource = this.clientDataSet1;
            // 
            // clientDataSet1
            // 
            this.clientDataSet1.DataSetName = "ClientDataSet1";
            this.clientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bYERsTableAdapter1
            // 
            this.bYERsTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 234);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tonkar enterprise software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bYERsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDByerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byerSNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byerTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem зайтиКакДругойПользовательToolStripMenuItem;
        private ClientDataSet1 clientDataSet1;
        private System.Windows.Forms.BindingSource bYERsBindingSource1;
        private ClientDataSet1TableAdapters.BYERsTableAdapter bYERsTableAdapter1;
    }
}