namespace CompShop
{
    partial class SingIN
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EnterBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOGCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uSERsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet1 = new CompShop.ClientDataSet1();
            this.clientDataSet1 = new CompShop.ClientDataSet1();
            this.uSERsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSERsTableAdapter1 = new CompShop.ClientDataSet1TableAdapters.USERsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(86, 28);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(119, 20);
            this.LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(86, 54);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(119, 20);
            this.PasswordBox.TabIndex = 1;
            // 
            // EnterBut
            // 
            this.EnterBut.Location = new System.Drawing.Point(65, 93);
            this.EnterBut.Name = "EnterBut";
            this.EnterBut.Size = new System.Drawing.Size(94, 23);
            this.EnterBut.TabIndex = 2;
            this.EnterBut.Text = "Вход";
            this.EnterBut.UseVisualStyleBackColor = true;
            this.EnterBut.Click += new System.EventHandler(this.EnterBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lOGCDataGridViewTextBoxColumn,
            this.pASCDataGridViewTextBoxColumn,
            this.Admin});
            this.dataGridView1.DataSource = this.uSERsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(219, 64);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // lOGCDataGridViewTextBoxColumn
            // 
            this.lOGCDataGridViewTextBoxColumn.DataPropertyName = "LOG_C";
            this.lOGCDataGridViewTextBoxColumn.HeaderText = "LOG_C";
            this.lOGCDataGridViewTextBoxColumn.Name = "lOGCDataGridViewTextBoxColumn";
            this.lOGCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASCDataGridViewTextBoxColumn
            // 
            this.pASCDataGridViewTextBoxColumn.DataPropertyName = "PAS_C";
            this.pASCDataGridViewTextBoxColumn.HeaderText = "PAS_C";
            this.pASCDataGridViewTextBoxColumn.Name = "pASCDataGridViewTextBoxColumn";
            this.pASCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            // 
            // uSERsBindingSource
            // 
            this.uSERsBindingSource.DataMember = "USERs";
            this.uSERsBindingSource.DataSource = this.clientDataSet1;
            // 
            // clientDataSet
            // 
            this.clientDataSet1.DataSetName = "ClientDataSet1";
            this.clientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERsTableAdapter
            // 
            this.uSERsTableAdapter1.ClearBeforeFill = true;
            // 
            // clientDataSet1
            // 
            this.clientDataSet1.DataSetName = "ClientDataSet1";
            this.clientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERsBindingSource1
            // 
            this.uSERsBindingSource1.DataMember = "USERs";
            this.uSERsBindingSource1.DataSource = this.clientDataSet1;
            // 
            // uSERsTableAdapter1
            // 
            this.uSERsTableAdapter1.ClearBeforeFill = true;
            // 
            // SingIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 124);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterBut);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingIN";
            this.ShowIcon = false;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.SingIN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SingIN_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button EnterBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource uSERsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private ClientDataSet1 clientDataSet1;
        private System.Windows.Forms.BindingSource uSERsBindingSource1;
        private ClientDataSet1TableAdapters.USERsTableAdapter uSERsTableAdapter1;
    }
}

