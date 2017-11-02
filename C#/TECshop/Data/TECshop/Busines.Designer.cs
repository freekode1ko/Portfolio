namespace TECshop
{
    partial class Busines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busines));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMountingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bWholesalePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerBlindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecShopDataSet = new TECshop.TecShopDataSet();
            this.tecShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blindsTableAdapter = new TECshop.TecShopDataSetTableAdapters.BlindsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerTableAdapter = new TECshop.TecShopDataSetTableAdapters.ManufacturerTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.сСlothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.bNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMountingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bWholesalePriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBlindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compositionTableAdapter = new TECshop.TecShopDataSetTableAdapters.CompositionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировакаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВесьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.bNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMountingDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bWholesalePriceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blindsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBlindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBlindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNameDataGridViewTextBoxColumn,
            this.bMountingDataGridViewTextBoxColumn,
            this.bColorDataGridViewTextBoxColumn,
            this.bWholesalePriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.manufacturerBlindsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 0;
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
            // bWholesalePriceDataGridViewTextBoxColumn
            // 
            this.bWholesalePriceDataGridViewTextBoxColumn.DataPropertyName = "B_Wholesale_Price";
            this.bWholesalePriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.bWholesalePriceDataGridViewTextBoxColumn.Name = "bWholesalePriceDataGridViewTextBoxColumn";
            this.bWholesalePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerBlindsBindingSource
            // 
            this.manufacturerBlindsBindingSource.DataMember = "ManufacturerBlinds";
            this.manufacturerBlindsBindingSource.DataSource = this.manufacturerBindingSource;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.tecShopDataSet;
            // 
            // tecShopDataSet
            // 
            this.tecShopDataSet.DataSetName = "TecShopDataSet";
            this.tecShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecShopDataSetBindingSource
            // 
            this.tecShopDataSetBindingSource.DataSource = this.tecShopDataSet;
            this.tecShopDataSetBindingSource.Position = 0;
            // 
            // blindsBindingSource
            // 
            this.blindsBindingSource.DataMember = "Blinds";
            this.blindsBindingSource.DataSource = this.tecShopDataSet;
            // 
            // blindsTableAdapter
            // 
            this.blindsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNameDataGridViewTextBoxColumn,
            this.mPhoneDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.manufacturerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(470, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(245, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "M_Name";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "Производитель";
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
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сСlothDataGridViewTextBoxColumn,
            this.cProductionDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.compositionBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(470, 210);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(245, 150);
            this.dataGridView3.TabIndex = 3;
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
            this.compositionBindingSource.DataSource = this.tecShopDataSet;
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
            this.bWholesalePriceDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.compositionBlindsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 210);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(452, 150);
            this.dataGridView4.TabIndex = 2;
            // 
            // bNameDataGridViewTextBoxColumn1
            // 
            this.bNameDataGridViewTextBoxColumn1.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.bNameDataGridViewTextBoxColumn1.Name = "bNameDataGridViewTextBoxColumn1";
            this.bNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bMountingDataGridViewTextBoxColumn1
            // 
            this.bMountingDataGridViewTextBoxColumn1.DataPropertyName = "B_Mounting";
            this.bMountingDataGridViewTextBoxColumn1.HeaderText = "Тип крепления";
            this.bMountingDataGridViewTextBoxColumn1.Name = "bMountingDataGridViewTextBoxColumn1";
            this.bMountingDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bMountingDataGridViewTextBoxColumn1.Width = 120;
            // 
            // bColorDataGridViewTextBoxColumn1
            // 
            this.bColorDataGridViewTextBoxColumn1.DataPropertyName = "B_Color";
            this.bColorDataGridViewTextBoxColumn1.HeaderText = "Цвет";
            this.bColorDataGridViewTextBoxColumn1.Name = "bColorDataGridViewTextBoxColumn1";
            this.bColorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bWholesalePriceDataGridViewTextBoxColumn1
            // 
            this.bWholesalePriceDataGridViewTextBoxColumn1.DataPropertyName = "B_Wholesale_Price";
            this.bWholesalePriceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.bWholesalePriceDataGridViewTextBoxColumn1.Name = "bWholesalePriceDataGridViewTextBoxColumn1";
            this.bWholesalePriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // compositionBlindsBindingSource
            // 
            this.compositionBlindsBindingSource.DataMember = "CompositionBlinds";
            this.compositionBlindsBindingSource.DataSource = this.compositionBindingSource;
            // 
            // manufacturerBindingSource1
            // 
            this.manufacturerBindingSource1.DataMember = "Manufacturer";
            this.manufacturerBindingSource1.DataSource = this.tecShopDataSet;
            // 
            // compositionTableAdapter
            // 
            this.compositionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Нашы замечальные товары:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сортировка по материалу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сортировка по производителю:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem,
            this.формаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировакаToolStripMenuItem,
            this.показатьВесьТоварToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // сортировакаToolStripMenuItem
            // 
            this.сортировакаToolStripMenuItem.Name = "сортировакаToolStripMenuItem";
            this.сортировакаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.сортировакаToolStripMenuItem.Text = "Сортировака";
            this.сортировакаToolStripMenuItem.Click += new System.EventHandler(this.сортировакаToolStripMenuItem_Click);
            // 
            // показатьВесьТоварToolStripMenuItem
            // 
            this.показатьВесьТоварToolStripMenuItem.Name = "показатьВесьТоварToolStripMenuItem";
            this.показатьВесьТоварToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.показатьВесьТоварToolStripMenuItem.Text = "Показать весь товар";
            this.показатьВесьТоварToolStripMenuItem.Click += new System.EventHandler(this.показатьВесьТоварToolStripMenuItem_Click);
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.формаToolStripMenuItem.Text = "Форма";
            this.формаToolStripMenuItem.Click += new System.EventHandler(this.формаToolStripMenuItem_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNameDataGridViewTextBoxColumn2,
            this.bMountingDataGridViewTextBoxColumn2,
            this.bColorDataGridViewTextBoxColumn2,
            this.bWholesalePriceDataGridViewTextBoxColumn2});
            this.dataGridView5.DataSource = this.blindsBindingSource1;
            this.dataGridView5.Location = new System.Drawing.Point(57, 27);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(603, 333);
            this.dataGridView5.TabIndex = 8;
            this.dataGridView5.Visible = false;
            // 
            // bNameDataGridViewTextBoxColumn2
            // 
            this.bNameDataGridViewTextBoxColumn2.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.bNameDataGridViewTextBoxColumn2.Name = "bNameDataGridViewTextBoxColumn2";
            this.bNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.bNameDataGridViewTextBoxColumn2.Width = 140;
            // 
            // bMountingDataGridViewTextBoxColumn2
            // 
            this.bMountingDataGridViewTextBoxColumn2.DataPropertyName = "B_Mounting";
            this.bMountingDataGridViewTextBoxColumn2.HeaderText = "Тип крепления";
            this.bMountingDataGridViewTextBoxColumn2.Name = "bMountingDataGridViewTextBoxColumn2";
            this.bMountingDataGridViewTextBoxColumn2.ReadOnly = true;
            this.bMountingDataGridViewTextBoxColumn2.Width = 140;
            // 
            // bColorDataGridViewTextBoxColumn2
            // 
            this.bColorDataGridViewTextBoxColumn2.DataPropertyName = "B_Color";
            this.bColorDataGridViewTextBoxColumn2.HeaderText = "Цвет";
            this.bColorDataGridViewTextBoxColumn2.Name = "bColorDataGridViewTextBoxColumn2";
            this.bColorDataGridViewTextBoxColumn2.ReadOnly = true;
            this.bColorDataGridViewTextBoxColumn2.Width = 140;
            // 
            // bWholesalePriceDataGridViewTextBoxColumn2
            // 
            this.bWholesalePriceDataGridViewTextBoxColumn2.DataPropertyName = "B_Wholesale_Price";
            this.bWholesalePriceDataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.bWholesalePriceDataGridViewTextBoxColumn2.Name = "bWholesalePriceDataGridViewTextBoxColumn2";
            this.bWholesalePriceDataGridViewTextBoxColumn2.ReadOnly = true;
            this.bWholesalePriceDataGridViewTextBoxColumn2.Width = 140;
            // 
            // blindsBindingSource1
            // 
            this.blindsBindingSource1.DataMember = "Blinds";
            this.blindsBindingSource1.DataSource = this.tecShopDataSet;
            // 
            // Busines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 374);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Busines";
            this.Text = "TECshop. Версия для предпринимателей.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Busines_FormClosing);
            this.Load += new System.EventHandler(this.Busines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBlindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBlindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tecShopDataSetBindingSource;
        private TecShopDataSet tecShopDataSet;
        private System.Windows.Forms.BindingSource blindsBindingSource;
        private TecShopDataSetTableAdapters.BlindsTableAdapter blindsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private TecShopDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBlindsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource manufacturerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private TecShopDataSetTableAdapters.CompositionTableAdapter compositionTableAdapter;
        private System.Windows.Forms.BindingSource compositionBlindsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMountingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bWholesalePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сСlothDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMountingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bWholesalePriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировакаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВесьТоварToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMountingDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bWholesalePriceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource blindsBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
    }
}