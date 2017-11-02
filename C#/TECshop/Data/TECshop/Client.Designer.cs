namespace TECshop
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tecShopDataSet = new TECshop.TecShopDataSet();
            this.blindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blindsTableAdapter = new TECshop.TecShopDataSetTableAdapters.BlindsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сСlothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blindsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMountingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPriceInstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBlindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionTableAdapter = new TECshop.TecShopDataSetTableAdapters.CompositionTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new TECshop.TecShopDataSetTableAdapters.ManufacturerTableAdapter();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerBlindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВесьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.bNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMountingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPriceInstDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blindsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBlindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBlindsBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource2)).BeginInit();
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
            // blindsBindingSource
            // 
            this.blindsBindingSource.DataMember = "Blinds";
            this.blindsBindingSource.DataSource = this.bindingSource1;
            // 
            // blindsTableAdapter
            // 
            this.blindsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наши замечательные товары.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сСlothDataGridViewTextBoxColumn,
            this.cProductionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compositionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(502, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 37;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // сСlothDataGridViewTextBoxColumn
            // 
            this.сСlothDataGridViewTextBoxColumn.DataPropertyName = "С_Сloth";
            this.сСlothDataGridViewTextBoxColumn.HeaderText = "Ткань";
            this.сСlothDataGridViewTextBoxColumn.Name = "сСlothDataGridViewTextBoxColumn";
            this.сСlothDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cProductionDataGridViewTextBoxColumn
            // 
            this.cProductionDataGridViewTextBoxColumn.DataPropertyName = "C_Production";
            this.cProductionDataGridViewTextBoxColumn.HeaderText = "Производство";
            this.cProductionDataGridViewTextBoxColumn.Name = "cProductionDataGridViewTextBoxColumn";
            this.cProductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataMember = "Composition";
            this.compositionBindingSource.DataSource = this.bindingSource1;
            // 
            // blindsBindingSource1
            // 
            this.blindsBindingSource1.DataMember = "Blinds";
            this.blindsBindingSource1.DataSource = this.bindingSource1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNameDataGridViewTextBoxColumn,
            this.bMountingDataGridViewTextBoxColumn,
            this.bColorDataGridViewTextBoxColumn,
            this.bPriceInstDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.compositionBlindsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(464, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // bNameDataGridViewTextBoxColumn
            // 
            this.bNameDataGridViewTextBoxColumn.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.bNameDataGridViewTextBoxColumn.Name = "bNameDataGridViewTextBoxColumn";
            this.bNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bMountingDataGridViewTextBoxColumn
            // 
            this.bMountingDataGridViewTextBoxColumn.DataPropertyName = "B_Mounting";
            this.bMountingDataGridViewTextBoxColumn.HeaderText = "Тип крепления";
            this.bMountingDataGridViewTextBoxColumn.Name = "bMountingDataGridViewTextBoxColumn";
            this.bMountingDataGridViewTextBoxColumn.ReadOnly = true;
            this.bMountingDataGridViewTextBoxColumn.Width = 120;
            // 
            // bColorDataGridViewTextBoxColumn
            // 
            this.bColorDataGridViewTextBoxColumn.DataPropertyName = "B_Color";
            this.bColorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.bColorDataGridViewTextBoxColumn.Name = "bColorDataGridViewTextBoxColumn";
            this.bColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bPriceInstDataGridViewTextBoxColumn
            // 
            this.bPriceInstDataGridViewTextBoxColumn.DataPropertyName = "B_Price_Inst";
            this.bPriceInstDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.bPriceInstDataGridViewTextBoxColumn.Name = "bPriceInstDataGridViewTextBoxColumn";
            this.bPriceInstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compositionBlindsBindingSource
            // 
            this.compositionBlindsBindingSource.DataMember = "CompositionBlinds";
            this.compositionBlindsBindingSource.DataSource = this.compositionBindingSource;
            // 
            // compositionTableAdapter
            // 
            this.compositionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNameDataGridViewTextBoxColumn,
            this.mPhoneDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.manufacturerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(502, 226);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 37;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "M_Name";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mPhoneDataGridViewTextBoxColumn
            // 
            this.mPhoneDataGridViewTextBoxColumn.DataPropertyName = "M_Phone";
            this.mPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.mPhoneDataGridViewTextBoxColumn.Name = "mPhoneDataGridViewTextBoxColumn";
            this.mPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.bindingSource1;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView5.DataSource = this.manufacturerBlindsBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(9, 226);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(464, 150);
            this.dataGridView5.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "B_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "B_Mounting";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип крепления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "B_Color";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "B_Price_Inst";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // manufacturerBlindsBindingSource
            // 
            this.manufacturerBlindsBindingSource.DataMember = "ManufacturerBlinds";
            this.manufacturerBlindsBindingSource.DataSource = this.manufacturerBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сортировка по производителю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сортировка по состовляющим";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem,
            this.bayToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(755, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.показатьВесьТоварToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // показатьВесьТоварToolStripMenuItem
            // 
            this.показатьВесьТоварToolStripMenuItem.Name = "показатьВесьТоварToolStripMenuItem";
            this.показатьВесьТоварToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.показатьВесьТоварToolStripMenuItem.Text = "Показать весь товар";
            this.показатьВесьТоварToolStripMenuItem.Click += new System.EventHandler(this.показатьВесьТоварToolStripMenuItem_Click);
            // 
            // bayToolStripMenuItem
            // 
            this.bayToolStripMenuItem.Name = "bayToolStripMenuItem";
            this.bayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bayToolStripMenuItem.Text = "Форма";
            this.bayToolStripMenuItem.Click += new System.EventHandler(this.bayToolStripMenuItem_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNameDataGridViewTextBoxColumn1,
            this.bMountingDataGridViewTextBoxColumn1,
            this.bColorDataGridViewTextBoxColumn1,
            this.bPriceInstDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.blindsBindingSource2;
            this.dataGridView4.Location = new System.Drawing.Point(73, 27);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(601, 349);
            this.dataGridView4.TabIndex = 11;
            this.dataGridView4.Visible = false;
            // 
            // bNameDataGridViewTextBoxColumn1
            // 
            this.bNameDataGridViewTextBoxColumn1.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.bNameDataGridViewTextBoxColumn1.Name = "bNameDataGridViewTextBoxColumn1";
            this.bNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bNameDataGridViewTextBoxColumn1.Width = 140;
            // 
            // bMountingDataGridViewTextBoxColumn1
            // 
            this.bMountingDataGridViewTextBoxColumn1.DataPropertyName = "B_Mounting";
            this.bMountingDataGridViewTextBoxColumn1.HeaderText = "Тип крепления";
            this.bMountingDataGridViewTextBoxColumn1.Name = "bMountingDataGridViewTextBoxColumn1";
            this.bMountingDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bMountingDataGridViewTextBoxColumn1.Width = 140;
            // 
            // bColorDataGridViewTextBoxColumn1
            // 
            this.bColorDataGridViewTextBoxColumn1.DataPropertyName = "B_Color";
            this.bColorDataGridViewTextBoxColumn1.HeaderText = "Цвет";
            this.bColorDataGridViewTextBoxColumn1.Name = "bColorDataGridViewTextBoxColumn1";
            this.bColorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bColorDataGridViewTextBoxColumn1.Width = 140;
            // 
            // bPriceInstDataGridViewTextBoxColumn1
            // 
            this.bPriceInstDataGridViewTextBoxColumn1.DataPropertyName = "B_Price_Inst";
            this.bPriceInstDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.bPriceInstDataGridViewTextBoxColumn1.Name = "bPriceInstDataGridViewTextBoxColumn1";
            this.bPriceInstDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bPriceInstDataGridViewTextBoxColumn1.Width = 140;
            // 
            // blindsBindingSource2
            // 
            this.blindsBindingSource2.DataMember = "Blinds";
            this.blindsBindingSource2.DataSource = this.tecShopDataSet;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 388);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.Text = "TECshop.Версия для часных лиц.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBlindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBlindsBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private TecShopDataSet tecShopDataSet;
        private System.Windows.Forms.BindingSource blindsBindingSource;
        private TecShopDataSetTableAdapters.BlindsTableAdapter blindsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource blindsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private TecShopDataSetTableAdapters.CompositionTableAdapter compositionTableAdapter;
        private System.Windows.Forms.BindingSource compositionBlindsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private TecShopDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn сСlothDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMountingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPriceInstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource manufacturerBlindsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВесьТоварToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource blindsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMountingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPriceInstDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem bayToolStripMenuItem;
    }
}