namespace OtMails
{
    partial class BD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BD));
            this.DataBaseViewer = new System.Windows.Forms.DataGridView();
            this.iDMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAILSDataSet = new OtMails.MAILSDataSet();
            this.smailTableAdapter = new OtMails.MAILSDataSetTableAdapters.SmailTableAdapter();
            this.UpdateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAILSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBaseViewer
            // 
            this.DataBaseViewer.AutoGenerateColumns = false;
            this.DataBaseViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMAILDataGridViewTextBoxColumn,
            this.mAILDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.DataBaseViewer.DataSource = this.smailBindingSource;
            this.DataBaseViewer.Location = new System.Drawing.Point(0, 0);
            this.DataBaseViewer.Name = "DataBaseViewer";
            this.DataBaseViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataBaseViewer.Size = new System.Drawing.Size(643, 239);
            this.DataBaseViewer.TabIndex = 0;
            // 
            // iDMAILDataGridViewTextBoxColumn
            // 
            this.iDMAILDataGridViewTextBoxColumn.DataPropertyName = "ID_MAIL";
            this.iDMAILDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDMAILDataGridViewTextBoxColumn.Name = "iDMAILDataGridViewTextBoxColumn";
            this.iDMAILDataGridViewTextBoxColumn.Width = 30;
            // 
            // mAILDataGridViewTextBoxColumn
            // 
            this.mAILDataGridViewTextBoxColumn.DataPropertyName = "MAIL";
            this.mAILDataGridViewTextBoxColumn.HeaderText = "Электронный адрес";
            this.mAILDataGridViewTextBoxColumn.Name = "mAILDataGridViewTextBoxColumn";
            this.mAILDataGridViewTextBoxColumn.Width = 250;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Название фирмы или Фамилия";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 350;
            // 
            // smailBindingSource
            // 
            this.smailBindingSource.DataMember = "Smail";
            this.smailBindingSource.DataSource = this.mAILSDataSet;
            // 
            // mAILSDataSet
            // 
            this.mAILSDataSet.DataSetName = "MAILSDataSet";
            this.mAILSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smailTableAdapter
            // 
            this.smailTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(12, 245);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(138, 23);
            this.UpdateBut.TabIndex = 1;
            this.UpdateBut.Text = "Принять изменения";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 275);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.DataBaseViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BD";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.BD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAILSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBaseViewer;
        private MAILSDataSet mAILSDataSet;
        private System.Windows.Forms.BindingSource smailBindingSource;
        private MAILSDataSetTableAdapters.SmailTableAdapter smailTableAdapter;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
    }
}