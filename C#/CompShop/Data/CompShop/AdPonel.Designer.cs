namespace CompShop
{
    partial class AdPonel
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
            this.iDCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uSERsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet1 = new CompShop.ClientDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.наГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зайтиКакДругойПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERsTableAdapter1 = new CompShop.ClientDataSet1TableAdapters.USERsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTDataGridViewTextBoxColumn,
            this.lOGCDataGridViewTextBoxColumn,
            this.pASCDataGridViewTextBoxColumn,
            this.clientFNameDataGridViewTextBoxColumn,
            this.clientSNameDataGridViewTextBoxColumn,
            this.clientTNameDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.uSERsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(660, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDCLIENTDataGridViewTextBoxColumn
            // 
            this.iDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.HeaderText = "ID_CLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.Name = "iDCLIENTDataGridViewTextBoxColumn";
            this.iDCLIENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // lOGCDataGridViewTextBoxColumn
            // 
            this.lOGCDataGridViewTextBoxColumn.DataPropertyName = "LOG_C";
            this.lOGCDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.lOGCDataGridViewTextBoxColumn.Name = "lOGCDataGridViewTextBoxColumn";
            // 
            // pASCDataGridViewTextBoxColumn
            // 
            this.pASCDataGridViewTextBoxColumn.DataPropertyName = "PAS_C";
            this.pASCDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.pASCDataGridViewTextBoxColumn.Name = "pASCDataGridViewTextBoxColumn";
            // 
            // clientFNameDataGridViewTextBoxColumn
            // 
            this.clientFNameDataGridViewTextBoxColumn.DataPropertyName = "Client_FName";
            this.clientFNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.clientFNameDataGridViewTextBoxColumn.Name = "clientFNameDataGridViewTextBoxColumn";
            // 
            // clientSNameDataGridViewTextBoxColumn
            // 
            this.clientSNameDataGridViewTextBoxColumn.DataPropertyName = "Client_SName";
            this.clientSNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.clientSNameDataGridViewTextBoxColumn.Name = "clientSNameDataGridViewTextBoxColumn";
            // 
            // clientTNameDataGridViewTextBoxColumn
            // 
            this.clientTNameDataGridViewTextBoxColumn.DataPropertyName = "Client_TName";
            this.clientTNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.clientTNameDataGridViewTextBoxColumn.Name = "clientTNameDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Админестратор ?";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            // 
            // uSERsBindingSource1
            // 
            this.uSERsBindingSource1.DataMember = "USERs";
            this.uSERsBindingSource1.DataSource = this.clientDataSet1;
            // 
            // clientDataSet1
            // 
            this.clientDataSet1.DataSetName = "ClientDataSet1";
            this.clientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьБазуToolStripMenuItem,
            this.toolStripSeparator1,
            this.наГлавнуюToolStripMenuItem,
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
            // наГлавнуюToolStripMenuItem
            // 
            this.наГлавнуюToolStripMenuItem.Name = "наГлавнуюToolStripMenuItem";
            this.наГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.наГлавнуюToolStripMenuItem.Text = "На главную";
            this.наГлавнуюToolStripMenuItem.Click += new System.EventHandler(this.наГлавнуюToolStripMenuItem_Click);
            // 
            // зайтиКакДругойПользовательToolStripMenuItem
            // 
            this.зайтиКакДругойПользовательToolStripMenuItem.Name = "зайтиКакДругойПользовательToolStripMenuItem";
            this.зайтиКакДругойПользовательToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.зайтиКакДругойПользовательToolStripMenuItem.Text = "Зайти как другой пользователь";
            this.зайтиКакДругойПользовательToolStripMenuItem.Click += new System.EventHandler(this.зайтиКакДругойПользовательToolStripMenuItem_Click);
            // 
            // uSERsTableAdapter1
            // 
            this.uSERsTableAdapter1.ClearBeforeFill = true;
            // 
            // AdPonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 243);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdPonel";
            this.Text = "Панель админестратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdPonel_FormClosing);
            this.Load += new System.EventHandler(this.AdPonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem наГлавнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зайтиКакДругойПользовательToolStripMenuItem;
        private ClientDataSet1 clientDataSet1;
        private System.Windows.Forms.BindingSource uSERsBindingSource1;
        private ClientDataSet1TableAdapters.USERsTableAdapter uSERsTableAdapter1;
    }
}