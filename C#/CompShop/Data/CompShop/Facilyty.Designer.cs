namespace CompShop
{
    partial class Facilyty
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
            this.clientDataSet1 = new CompShop.ClientDataSet1();
            this.fACILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACILTableAdapter = new CompShop.ClientDataSet1TableAdapters.FACILTableAdapter();
            this.tableAdapterManager = new CompShop.ClientDataSet1TableAdapters.TableAdapterManager();
            this.fACILDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACILDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataSet1
            // 
            this.clientDataSet1.DataSetName = "ClientDataSet1";
            this.clientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.TOVARsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CompShop.ClientDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERsTableAdapter = null;
            // 
            // fACILDataGridView
            // 
            this.fACILDataGridView.AllowUserToAddRows = false;
            this.fACILDataGridView.AllowUserToDeleteRows = false;
            this.fACILDataGridView.AutoGenerateColumns = false;
            this.fACILDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fACILDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fACILDataGridView.DataSource = this.fACILBindingSource;
            this.fACILDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fACILDataGridView.Name = "fACILDataGridView";
            this.fACILDataGridView.ReadOnly = true;
            this.fACILDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fACILDataGridView.Size = new System.Drawing.Size(258, 220);
            this.fACILDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "F_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "F_PHONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Facilyty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 222);
            this.Controls.Add(this.fACILDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facilyty";
            this.ShowIcon = false;
            this.Text = "Производители";
            this.Load += new System.EventHandler(this.Facilyty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACILDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClientDataSet1 clientDataSet1;
        private System.Windows.Forms.BindingSource fACILBindingSource;
        private ClientDataSet1TableAdapters.FACILTableAdapter fACILTableAdapter;
        private ClientDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fACILDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}