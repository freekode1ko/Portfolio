namespace WordTest
{
    partial class DocForm
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
            this.replaceAllСheckBox = new System.Windows.Forms.CheckBox();
            this.replaceStrTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.Z_OGRN = new System.Windows.Forms.TextBox();
            this.Z_BIK = new System.Windows.Forms.TextBox();
            this.Z_INN = new System.Windows.Forms.TextBox();
            this.Z_Name = new System.Windows.Forms.TextBox();
            this.Z_COL = new System.Windows.Forms.TextBox();
            this.GenerateBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросИзмененийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьНомерДоговораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DbList = new System.Windows.Forms.DataGridView();
            this.Z_URadr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchBut = new System.Windows.Forms.Button();
            this.Z_KPP = new System.Windows.Forms.TextBox();
            this.Z_Rs = new System.Windows.Forms.TextBox();
            this.Z_Ks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbList)).BeginInit();
            this.SuspendLayout();
            // 
            // replaceAllСheckBox
            // 
            this.replaceAllСheckBox.AutoSize = true;
            this.replaceAllСheckBox.Checked = true;
            this.replaceAllСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.replaceAllСheckBox.Location = new System.Drawing.Point(262, 348);
            this.replaceAllСheckBox.Name = "replaceAllСheckBox";
            this.replaceAllСheckBox.Size = new System.Drawing.Size(44, 17);
            this.replaceAllСheckBox.TabIndex = 13;
            this.replaceAllСheckBox.Text = "все";
            this.replaceAllСheckBox.UseVisualStyleBackColor = true;
            this.replaceAllСheckBox.Visible = false;
            // 
            // replaceStrTextBox
            // 
            this.replaceStrTextBox.Location = new System.Drawing.Point(12, 83);
            this.replaceStrTextBox.Name = "replaceStrTextBox";
            this.replaceStrTextBox.Size = new System.Drawing.Size(64, 20);
            this.replaceStrTextBox.TabIndex = 2;
            this.replaceStrTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllKeyPress);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 33);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(293, 13);
            this.pathLabel.TabIndex = 21;
            this.pathLabel.Text = "Имя файла с шаблоном Word в каталоге с программой:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 52);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(338, 20);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "Shab.docx";
            // 
            // Z_OGRN
            // 
            this.Z_OGRN.Location = new System.Drawing.Point(12, 187);
            this.Z_OGRN.MaxLength = 13;
            this.Z_OGRN.Name = "Z_OGRN";
            this.Z_OGRN.Size = new System.Drawing.Size(240, 20);
            this.Z_OGRN.TabIndex = 7;
            this.Z_OGRN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllKeyPress);
            // 
            // Z_BIK
            // 
            this.Z_BIK.Location = new System.Drawing.Point(12, 161);
            this.Z_BIK.MaxLength = 9;
            this.Z_BIK.Name = "Z_BIK";
            this.Z_BIK.Size = new System.Drawing.Size(240, 20);
            this.Z_BIK.TabIndex = 6;
            this.Z_BIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllKeyPress);
            // 
            // Z_INN
            // 
            this.Z_INN.Location = new System.Drawing.Point(12, 135);
            this.Z_INN.MaxLength = 12;
            this.Z_INN.Name = "Z_INN";
            this.Z_INN.Size = new System.Drawing.Size(240, 20);
            this.Z_INN.TabIndex = 5;
            this.Z_INN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllKeyPress);
            // 
            // Z_Name
            // 
            this.Z_Name.Location = new System.Drawing.Point(12, 109);
            this.Z_Name.Name = "Z_Name";
            this.Z_Name.Size = new System.Drawing.Size(240, 20);
            this.Z_Name.TabIndex = 4;
            // 
            // Z_COL
            // 
            this.Z_COL.Location = new System.Drawing.Point(12, 318);
            this.Z_COL.Name = "Z_COL";
            this.Z_COL.Size = new System.Drawing.Size(240, 20);
            this.Z_COL.TabIndex = 12;
            this.Z_COL.Text = "0";
            this.Z_COL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllKeyPress);
            // 
            // GenerateBut
            // 
            this.GenerateBut.Location = new System.Drawing.Point(12, 344);
            this.GenerateBut.Name = "GenerateBut";
            this.GenerateBut.Size = new System.Drawing.Size(116, 23);
            this.GenerateBut.TabIndex = 39;
            this.GenerateBut.Text = "Сформировать счет";
            this.GenerateBut.UseVisualStyleBackColor = true;
            this.GenerateBut.Click += new System.EventHandler(this.GenerateBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Номер договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Заказчик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "БИК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "ОГРН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Количество";
            // 
            // NN
            // 
            this.NN.Location = new System.Drawing.Point(178, 83);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(74, 20);
            this.NN.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Номер договора";
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.сбросИзмененийToolStripMenuItem,
            this.сформироватьВсеToolStripMenuItem,
            this.сохранитьИзмененияToolStripMenuItem,
            this.увеличитьНомерДоговораToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip.TabIndex = 48;
            this.menuStrip.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // сбросИзмененийToolStripMenuItem
            // 
            this.сбросИзмененийToolStripMenuItem.Name = "сбросИзмененийToolStripMenuItem";
            this.сбросИзмененийToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.сбросИзмененийToolStripMenuItem.Text = "Сброс изменений";
            this.сбросИзмененийToolStripMenuItem.Click += new System.EventHandler(this.сбросИзмененийToolStripMenuItem_Click);
            // 
            // сформироватьВсеToolStripMenuItem
            // 
            this.сформироватьВсеToolStripMenuItem.Name = "сформироватьВсеToolStripMenuItem";
            this.сформироватьВсеToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.сформироватьВсеToolStripMenuItem.Text = "Сформировать все";
            this.сформироватьВсеToolStripMenuItem.Click += new System.EventHandler(this.сформироватьВсеToolStripMenuItem_Click);
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // увеличитьНомерДоговораToolStripMenuItem
            // 
            this.увеличитьНомерДоговораToolStripMenuItem.Name = "увеличитьНомерДоговораToolStripMenuItem";
            this.увеличитьНомерДоговораToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.увеличитьНомерДоговораToolStripMenuItem.Text = "Увеличить номер договора";
            this.увеличитьНомерДоговораToolStripMenuItem.Click += new System.EventHandler(this.увеличитьНомерДоговораToolStripMenuItem_Click);
            // 
            // DbList
            // 
            this.DbList.AllowUserToAddRows = false;
            this.DbList.AllowUserToDeleteRows = false;
            this.DbList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbList.Location = new System.Drawing.Point(356, 33);
            this.DbList.Name = "DbList";
            this.DbList.RowHeadersWidth = 4;
            this.DbList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DbList.Size = new System.Drawing.Size(881, 334);
            this.DbList.TabIndex = 0;
            this.DbList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbList_CellDoubleClick);
            // 
            // Z_URadr
            // 
            this.Z_URadr.Location = new System.Drawing.Point(12, 213);
            this.Z_URadr.Name = "Z_URadr";
            this.Z_URadr.Size = new System.Drawing.Size(240, 20);
            this.Z_URadr.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Юр.Адрес";
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(146, 344);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(106, 23);
            this.SearchBut.TabIndex = 51;
            this.SearchBut.Text = "Найти";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // Z_KPP
            // 
            this.Z_KPP.Location = new System.Drawing.Point(12, 291);
            this.Z_KPP.Name = "Z_KPP";
            this.Z_KPP.Size = new System.Drawing.Size(240, 20);
            this.Z_KPP.TabIndex = 11;
            // 
            // Z_Rs
            // 
            this.Z_Rs.Location = new System.Drawing.Point(12, 239);
            this.Z_Rs.Name = "Z_Rs";
            this.Z_Rs.Size = new System.Drawing.Size(240, 20);
            this.Z_Rs.TabIndex = 9;
            // 
            // Z_Ks
            // 
            this.Z_Ks.Location = new System.Drawing.Point(12, 265);
            this.Z_Ks.Name = "Z_Ks";
            this.Z_Ks.Size = new System.Drawing.Size(240, 20);
            this.Z_Ks.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Р/С";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "К/С";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "КПП";
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 380);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Z_Ks);
            this.Controls.Add(this.Z_Rs);
            this.Controls.Add(this.Z_KPP);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Z_URadr);
            this.Controls.Add(this.DbList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateBut);
            this.Controls.Add(this.Z_COL);
            this.Controls.Add(this.Z_Name);
            this.Controls.Add(this.Z_INN);
            this.Controls.Add(this.Z_BIK);
            this.Controls.Add(this.Z_OGRN);
            this.Controls.Add(this.replaceAllСheckBox);
            this.Controls.Add(this.replaceStrTextBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DocForm";
            this.Text = "Составить счета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocForm_FormClosing);
            this.Load += new System.EventHandler(this.DocForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox replaceAllСheckBox;
        private System.Windows.Forms.TextBox replaceStrTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox Z_OGRN;
        private System.Windows.Forms.TextBox Z_BIK;
        private System.Windows.Forms.TextBox Z_INN;
        private System.Windows.Forms.TextBox Z_Name;
        private System.Windows.Forms.TextBox Z_COL;
        private System.Windows.Forms.Button GenerateBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView DbList;
        private System.Windows.Forms.TextBox Z_URadr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.ToolStripMenuItem сбросИзмененийToolStripMenuItem;
        private System.Windows.Forms.TextBox Z_KPP;
        private System.Windows.Forms.TextBox Z_Rs;
        private System.Windows.Forms.TextBox Z_Ks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem сформироватьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьНомерДоговораToolStripMenuItem;
    }
}