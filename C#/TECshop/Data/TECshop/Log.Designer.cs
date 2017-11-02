namespace TECshop
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tecShopDataSet = new TECshop.TecShopDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.byFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bySNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byTnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyerTableAdapter = new TECshop.TecShopDataSetTableAdapters.BuyerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employerTableAdapter = new TECshop.TecShopDataSetTableAdapters.EmployerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.tecShopDataSet;
            this.bindingSource1.Position = 0;
            // 
            // tecShopDataSet
            // 
            this.tecShopDataSet.DataSetName = "TecShopDataSet";
            this.tecShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.byFNameDataGridViewTextBoxColumn,
            this.bySNameDataGridViewTextBoxColumn,
            this.byTnameDataGridViewTextBoxColumn,
            this.byPhoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buyerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(406, 47);
            this.dataGridView1.TabIndex = 0;
            // 
            // byFNameDataGridViewTextBoxColumn
            // 
            this.byFNameDataGridViewTextBoxColumn.DataPropertyName = "By_FName";
            this.byFNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.byFNameDataGridViewTextBoxColumn.Name = "byFNameDataGridViewTextBoxColumn";
            // 
            // bySNameDataGridViewTextBoxColumn
            // 
            this.bySNameDataGridViewTextBoxColumn.DataPropertyName = "By_SName";
            this.bySNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.bySNameDataGridViewTextBoxColumn.Name = "bySNameDataGridViewTextBoxColumn";
            // 
            // byTnameDataGridViewTextBoxColumn
            // 
            this.byTnameDataGridViewTextBoxColumn.DataPropertyName = "By_Tname";
            this.byTnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.byTnameDataGridViewTextBoxColumn.Name = "byTnameDataGridViewTextBoxColumn";
            // 
            // byPhoneDataGridViewTextBoxColumn
            // 
            this.byPhoneDataGridViewTextBoxColumn.DataPropertyName = "By_Phone";
            this.byPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.byPhoneDataGridViewTextBoxColumn.Name = "byPhoneDataGridViewTextBoxColumn";
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "Buyer";
            this.buyerBindingSource.DataSource = this.bindingSource1;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eFNameDataGridViewTextBoxColumn,
            this.eSNameDataGridViewTextBoxColumn,
            this.eTNameDataGridViewTextBoxColumn,
            this.ePhoneDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyPhoneDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.employerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 4;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(677, 47);
            this.dataGridView2.TabIndex = 1;
            // 
            // eFNameDataGridViewTextBoxColumn
            // 
            this.eFNameDataGridViewTextBoxColumn.DataPropertyName = "E_FName";
            this.eFNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.eFNameDataGridViewTextBoxColumn.Name = "eFNameDataGridViewTextBoxColumn";
            // 
            // eSNameDataGridViewTextBoxColumn
            // 
            this.eSNameDataGridViewTextBoxColumn.DataPropertyName = "E_SName";
            this.eSNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.eSNameDataGridViewTextBoxColumn.Name = "eSNameDataGridViewTextBoxColumn";
            // 
            // eTNameDataGridViewTextBoxColumn
            // 
            this.eTNameDataGridViewTextBoxColumn.DataPropertyName = "E_TName";
            this.eTNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.eTNameDataGridViewTextBoxColumn.Name = "eTNameDataGridViewTextBoxColumn";
            // 
            // ePhoneDataGridViewTextBoxColumn
            // 
            this.ePhoneDataGridViewTextBoxColumn.DataPropertyName = "E_Phone";
            this.ePhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.ePhoneDataGridViewTextBoxColumn.Name = "ePhoneDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Название компании";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // companyPhoneDataGridViewTextBoxColumn
            // 
            this.companyPhoneDataGridViewTextBoxColumn.DataPropertyName = "Company_Phone";
            this.companyPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон компании";
            this.companyPhoneDataGridViewTextBoxColumn.Name = "companyPhoneDataGridViewTextBoxColumn";
            this.companyPhoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "Employer";
            this.employerBindingSource.DataSource = this.bindingSource1;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вас приветствует команда TECshop. Мы рады что выбрали нас для ваших покупок.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пожалуйста, идентифицируйте себя для нашего дальнейшего сотрудничества.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Форма заполнения данных для часных лиц:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Форма для предпринемателей:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Готово";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BussBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 265);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.Text = "TECshop";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private TecShopDataSet tecShopDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private TecShopDataSetTableAdapters.BuyerTableAdapter buyerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn byFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bySNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byTnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private TecShopDataSetTableAdapters.EmployerTableAdapter employerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

