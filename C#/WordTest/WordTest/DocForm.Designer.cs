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
            this.Lb_Num1 = new System.Windows.Forms.Label();
            this.Lb_Zak = new System.Windows.Forms.Label();
            this.Lb_Inn = new System.Windows.Forms.Label();
            this.Lb_Bik = new System.Windows.Forms.Label();
            this.Lb_OGRN = new System.Windows.Forms.Label();
            this.Lb_Count = new System.Windows.Forms.Label();
            this.NN = new System.Windows.Forms.TextBox();
            this.Lb_Num2 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросИзмененийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьНомерДоговораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DbList = new System.Windows.Forms.DataGridView();
            this.Z_URadr = new System.Windows.Forms.TextBox();
            this.Lb_UrAdr = new System.Windows.Forms.Label();
            this.SearchBut = new System.Windows.Forms.Button();
            this.Z_KPP = new System.Windows.Forms.TextBox();
            this.Z_Rs = new System.Windows.Forms.TextBox();
            this.Z_Ks = new System.Windows.Forms.TextBox();
            this.Lb_RS = new System.Windows.Forms.Label();
            this.Lb_KS = new System.Windows.Forms.Label();
            this.Lb_KPP = new System.Windows.Forms.Label();
            this.Z_DatOfCre = new System.Windows.Forms.TextBox();
            this.Lb_DatOfCre = new System.Windows.Forms.Label();
            this.Lb_StatusBar = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbList)).BeginInit();
            this.SuspendLayout();
            // 
            // replaceAllСheckBox
            // 
            this.replaceAllСheckBox.AutoSize = true;
            this.replaceAllСheckBox.Checked = true;
            this.replaceAllСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.replaceAllСheckBox.Location = new System.Drawing.Point(262, 384);
            this.replaceAllСheckBox.Name = "replaceAllСheckBox";
            this.replaceAllСheckBox.Size = new System.Drawing.Size(44, 17);
            this.replaceAllСheckBox.TabIndex = 122;
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
            this.Z_COL.Location = new System.Drawing.Point(12, 343);
            this.Z_COL.Name = "Z_COL";
            this.Z_COL.Size = new System.Drawing.Size(240, 20);
            this.Z_COL.TabIndex = 13;
            this.Z_COL.Text = "0";
            this.Z_COL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllKeyPress);
            // 
            // GenerateBut
            // 
            this.GenerateBut.Location = new System.Drawing.Point(12, 380);
            this.GenerateBut.Name = "GenerateBut";
            this.GenerateBut.Size = new System.Drawing.Size(116, 23);
            this.GenerateBut.TabIndex = 14;
            this.GenerateBut.Text = "Сформировать счет";
            this.GenerateBut.UseVisualStyleBackColor = true;
            this.GenerateBut.Click += new System.EventHandler(this.GenerateBut_Click);
            // 
            // Lb_Num1
            // 
            this.Lb_Num1.AutoSize = true;
            this.Lb_Num1.Location = new System.Drawing.Point(82, 86);
            this.Lb_Num1.Name = "Lb_Num1";
            this.Lb_Num1.Size = new System.Drawing.Size(91, 13);
            this.Lb_Num1.TabIndex = 40;
            this.Lb_Num1.Text = "Номер договора";
            // 
            // Lb_Zak
            // 
            this.Lb_Zak.AutoSize = true;
            this.Lb_Zak.Location = new System.Drawing.Point(258, 112);
            this.Lb_Zak.Name = "Lb_Zak";
            this.Lb_Zak.Size = new System.Drawing.Size(55, 13);
            this.Lb_Zak.TabIndex = 41;
            this.Lb_Zak.Text = "Заказчик";
            // 
            // Lb_Inn
            // 
            this.Lb_Inn.AutoSize = true;
            this.Lb_Inn.Location = new System.Drawing.Point(258, 138);
            this.Lb_Inn.Name = "Lb_Inn";
            this.Lb_Inn.Size = new System.Drawing.Size(31, 13);
            this.Lb_Inn.TabIndex = 42;
            this.Lb_Inn.Text = "ИНН";
            // 
            // Lb_Bik
            // 
            this.Lb_Bik.AutoSize = true;
            this.Lb_Bik.Location = new System.Drawing.Point(258, 164);
            this.Lb_Bik.Name = "Lb_Bik";
            this.Lb_Bik.Size = new System.Drawing.Size(29, 13);
            this.Lb_Bik.TabIndex = 43;
            this.Lb_Bik.Text = "БИК";
            // 
            // Lb_OGRN
            // 
            this.Lb_OGRN.AutoSize = true;
            this.Lb_OGRN.Location = new System.Drawing.Point(258, 190);
            this.Lb_OGRN.Name = "Lb_OGRN";
            this.Lb_OGRN.Size = new System.Drawing.Size(36, 13);
            this.Lb_OGRN.TabIndex = 44;
            this.Lb_OGRN.Text = "ОГРН";
            // 
            // Lb_Count
            // 
            this.Lb_Count.AutoSize = true;
            this.Lb_Count.Location = new System.Drawing.Point(258, 346);
            this.Lb_Count.Name = "Lb_Count";
            this.Lb_Count.Size = new System.Drawing.Size(66, 13);
            this.Lb_Count.TabIndex = 45;
            this.Lb_Count.Text = "Количество";
            // 
            // NN
            // 
            this.NN.Location = new System.Drawing.Point(178, 83);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(74, 20);
            this.NN.TabIndex = 3;
            // 
            // Lb_Num2
            // 
            this.Lb_Num2.AutoSize = true;
            this.Lb_Num2.Location = new System.Drawing.Point(259, 86);
            this.Lb_Num2.Name = "Lb_Num2";
            this.Lb_Num2.Size = new System.Drawing.Size(91, 13);
            this.Lb_Num2.TabIndex = 47;
            this.Lb_Num2.Text = "Номер договора";
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
            this.menuStrip.Text = "Дата создания";
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
            this.DbList.Size = new System.Drawing.Size(881, 370);
            this.DbList.TabIndex = 0;
            // 
            // Z_URadr
            // 
            this.Z_URadr.Location = new System.Drawing.Point(12, 213);
            this.Z_URadr.Name = "Z_URadr";
            this.Z_URadr.Size = new System.Drawing.Size(240, 20);
            this.Z_URadr.TabIndex = 8;
            // 
            // Lb_UrAdr
            // 
            this.Lb_UrAdr.AutoSize = true;
            this.Lb_UrAdr.Location = new System.Drawing.Point(259, 216);
            this.Lb_UrAdr.Name = "Lb_UrAdr";
            this.Lb_UrAdr.Size = new System.Drawing.Size(56, 13);
            this.Lb_UrAdr.TabIndex = 50;
            this.Lb_UrAdr.Text = "Юр.Адрес";
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(146, 380);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(106, 23);
            this.SearchBut.TabIndex = 15;
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
            // Lb_RS
            // 
            this.Lb_RS.AutoSize = true;
            this.Lb_RS.Location = new System.Drawing.Point(261, 242);
            this.Lb_RS.Name = "Lb_RS";
            this.Lb_RS.Size = new System.Drawing.Size(26, 13);
            this.Lb_RS.TabIndex = 55;
            this.Lb_RS.Text = "Р/С";
            // 
            // Lb_KS
            // 
            this.Lb_KS.AutoSize = true;
            this.Lb_KS.Location = new System.Drawing.Point(261, 268);
            this.Lb_KS.Name = "Lb_KS";
            this.Lb_KS.Size = new System.Drawing.Size(26, 13);
            this.Lb_KS.TabIndex = 56;
            this.Lb_KS.Text = "К/С";
            // 
            // Lb_KPP
            // 
            this.Lb_KPP.AutoSize = true;
            this.Lb_KPP.Location = new System.Drawing.Point(261, 294);
            this.Lb_KPP.Name = "Lb_KPP";
            this.Lb_KPP.Size = new System.Drawing.Size(30, 13);
            this.Lb_KPP.TabIndex = 57;
            this.Lb_KPP.Text = "КПП";
            // 
            // Z_DatOfCre
            // 
            this.Z_DatOfCre.Location = new System.Drawing.Point(12, 317);
            this.Z_DatOfCre.MaxLength = 10;
            this.Z_DatOfCre.Name = "Z_DatOfCre";
            this.Z_DatOfCre.Size = new System.Drawing.Size(240, 20);
            this.Z_DatOfCre.TabIndex = 12;
            // 
            // Lb_DatOfCre
            // 
            this.Lb_DatOfCre.AutoSize = true;
            this.Lb_DatOfCre.Location = new System.Drawing.Point(259, 320);
            this.Lb_DatOfCre.Name = "Lb_DatOfCre";
            this.Lb_DatOfCre.Size = new System.Drawing.Size(84, 13);
            this.Lb_DatOfCre.TabIndex = 59;
            this.Lb_DatOfCre.Text = "Дата создания";
            // 
            // Lb_StatusBar
            // 
            this.Lb_StatusBar.AutoSize = true;
            this.Lb_StatusBar.Location = new System.Drawing.Point(259, 384);
            this.Lb_StatusBar.Name = "Lb_StatusBar";
            this.Lb_StatusBar.Size = new System.Drawing.Size(59, 13);
            this.Lb_StatusBar.TabIndex = 123;
            this.Lb_StatusBar.Text = "Ожидание";
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 415);
            this.Controls.Add(this.Lb_StatusBar);
            this.Controls.Add(this.Lb_DatOfCre);
            this.Controls.Add(this.Z_DatOfCre);
            this.Controls.Add(this.Lb_KPP);
            this.Controls.Add(this.Lb_KS);
            this.Controls.Add(this.Lb_RS);
            this.Controls.Add(this.Z_Ks);
            this.Controls.Add(this.Z_Rs);
            this.Controls.Add(this.Z_KPP);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.Lb_UrAdr);
            this.Controls.Add(this.Z_URadr);
            this.Controls.Add(this.DbList);
            this.Controls.Add(this.Lb_Num2);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.Lb_Count);
            this.Controls.Add(this.Lb_OGRN);
            this.Controls.Add(this.Lb_Bik);
            this.Controls.Add(this.Lb_Inn);
            this.Controls.Add(this.Lb_Zak);
            this.Controls.Add(this.Lb_Num1);
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
            this.Text = "Составить счета v.1.0";
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
        private System.Windows.Forms.Label Lb_Num1;
        private System.Windows.Forms.Label Lb_Zak;
        private System.Windows.Forms.Label Lb_Inn;
        private System.Windows.Forms.Label Lb_Bik;
        private System.Windows.Forms.Label Lb_OGRN;
        private System.Windows.Forms.Label Lb_Count;
        private System.Windows.Forms.TextBox NN;
        private System.Windows.Forms.Label Lb_Num2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView DbList;
        private System.Windows.Forms.TextBox Z_URadr;
        private System.Windows.Forms.Label Lb_UrAdr;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.ToolStripMenuItem сбросИзмененийToolStripMenuItem;
        private System.Windows.Forms.TextBox Z_KPP;
        private System.Windows.Forms.TextBox Z_Rs;
        private System.Windows.Forms.TextBox Z_Ks;
        private System.Windows.Forms.Label Lb_RS;
        private System.Windows.Forms.Label Lb_KS;
        private System.Windows.Forms.Label Lb_KPP;
        private System.Windows.Forms.ToolStripMenuItem сформироватьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьНомерДоговораToolStripMenuItem;
        private System.Windows.Forms.TextBox Z_DatOfCre;
        private System.Windows.Forms.Label Lb_DatOfCre;
        private System.Windows.Forms.Label Lb_StatusBar;
    }
}