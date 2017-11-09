namespace OtMails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ScoreSend = new System.Windows.Forms.Button();
            this.MailList = new System.Windows.Forms.DataGridView();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AKT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.smailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAILSDataSet = new OtMails.MAILSDataSet();
            this.smailTableAdapter = new OtMails.MAILSDataSetTableAdapters.SmailTableAdapter();
            this.ScoreStatus = new System.Windows.Forms.Label();
            this.OutLog = new System.Windows.Forms.ListBox();
            this.ActSend = new System.Windows.Forms.Button();
            this.ActStatus = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.письмоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстПисьмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jepgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MailText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAILSDataSet)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreSend
            // 
            this.ScoreSend.Location = new System.Drawing.Point(9, 184);
            this.ScoreSend.Name = "ScoreSend";
            this.ScoreSend.Size = new System.Drawing.Size(103, 23);
            this.ScoreSend.TabIndex = 0;
            this.ScoreSend.Text = "Отправить";
            this.ScoreSend.UseVisualStyleBackColor = true;
            this.ScoreSend.Click += new System.EventHandler(this.CheckSend_Click);
            // 
            // MailList
            // 
            this.MailList.AllowUserToAddRows = false;
            this.MailList.AllowUserToDeleteRows = false;
            this.MailList.AutoGenerateColumns = false;
            this.MailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAILDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.AKT});
            this.MailList.DataSource = this.smailBindingSource;
            this.MailList.Location = new System.Drawing.Point(12, 27);
            this.MailList.Name = "MailList";
            this.MailList.RowHeadersWidth = 20;
            this.MailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MailList.Size = new System.Drawing.Size(437, 150);
            this.MailList.TabIndex = 1;
            // 
            // mAILDataGridViewTextBoxColumn
            // 
            this.mAILDataGridViewTextBoxColumn.DataPropertyName = "MAIL";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mAILDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.mAILDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.mAILDataGridViewTextBoxColumn.Name = "mAILDataGridViewTextBoxColumn";
            this.mAILDataGridViewTextBoxColumn.Width = 160;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.nAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 160;
            // 
            // AKT
            // 
            this.AKT.HeaderText = "АКТ?";
            this.AKT.Name = "AKT";
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
            // ScoreStatus
            // 
            this.ScoreStatus.AutoSize = true;
            this.ScoreStatus.Location = new System.Drawing.Point(9, 210);
            this.ScoreStatus.Name = "ScoreStatus";
            this.ScoreStatus.Size = new System.Drawing.Size(133, 13);
            this.ScoreStatus.TabIndex = 2;
            this.ScoreStatus.Text = "Ожидание пользователя";
            // 
            // OutLog
            // 
            this.OutLog.FormattingEnabled = true;
            this.OutLog.Location = new System.Drawing.Point(144, 183);
            this.OutLog.Name = "OutLog";
            this.OutLog.Size = new System.Drawing.Size(305, 82);
            this.OutLog.TabIndex = 3;
            // 
            // ActSend
            // 
            this.ActSend.Location = new System.Drawing.Point(9, 227);
            this.ActSend.Name = "ActSend";
            this.ActSend.Size = new System.Drawing.Size(103, 23);
            this.ActSend.TabIndex = 4;
            this.ActSend.Text = "Отправить Акты";
            this.ActSend.UseVisualStyleBackColor = true;
            this.ActSend.Click += new System.EventHandler(this.SendAct_Click);
            // 
            // ActStatus
            // 
            this.ActStatus.AutoSize = true;
            this.ActStatus.Location = new System.Drawing.Point(9, 252);
            this.ActStatus.Name = "ActStatus";
            this.ActStatus.Size = new System.Drawing.Size(133, 13);
            this.ActStatus.TabIndex = 5;
            this.ActStatus.Text = "Ожидание пользователя";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.письмоToolStripMenuItem,
            this.форматToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(461, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.toolStripSeparator1,
            this.помощьToolStripMenuItem,
            this.оРазработчикеToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            this.базаДанныхToolStripMenuItem.Click += new System.EventHandler(this.базаДанныхToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // письмоToolStripMenuItem
            // 
            this.письмоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстПисьмаToolStripMenuItem});
            this.письмоToolStripMenuItem.Name = "письмоToolStripMenuItem";
            this.письмоToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.письмоToolStripMenuItem.Text = "Письмо";
            // 
            // текстПисьмаToolStripMenuItem
            // 
            this.текстПисьмаToolStripMenuItem.Name = "текстПисьмаToolStripMenuItem";
            this.текстПисьмаToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.текстПисьмаToolStripMenuItem.Text = "Текст письма";
            this.текстПисьмаToolStripMenuItem.Click += new System.EventHandler(this.текстПисьмаToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpgToolStripMenuItem,
            this.jepgToolStripMenuItem,
            this.gifToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // jpgToolStripMenuItem
            // 
            this.jpgToolStripMenuItem.Checked = true;
            this.jpgToolStripMenuItem.CheckOnClick = true;
            this.jpgToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jpgToolStripMenuItem.Name = "jpgToolStripMenuItem";
            this.jpgToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.jpgToolStripMenuItem.Text = ".jpg";
            this.jpgToolStripMenuItem.Click += new System.EventHandler(this.jpgToolStripMenuItem_Click);
            // 
            // jepgToolStripMenuItem
            // 
            this.jepgToolStripMenuItem.CheckOnClick = true;
            this.jepgToolStripMenuItem.Name = "jepgToolStripMenuItem";
            this.jepgToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.jepgToolStripMenuItem.Text = ".jpeg";
            this.jepgToolStripMenuItem.Click += new System.EventHandler(this.jepgToolStripMenuItem_Click);
            // 
            // gifToolStripMenuItem
            // 
            this.gifToolStripMenuItem.CheckOnClick = true;
            this.gifToolStripMenuItem.Name = "gifToolStripMenuItem";
            this.gifToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.gifToolStripMenuItem.Text = ".gif";
            this.gifToolStripMenuItem.Click += new System.EventHandler(this.gifToolStripMenuItem_Click);
            // 
            // MailText
            // 
            this.MailText.Location = new System.Drawing.Point(12, 278);
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(437, 96);
            this.MailText.TabIndex = 7;
            this.MailText.Text = "";
            this.MailText.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.Controls.Add(this.MailText);
            this.Controls.Add(this.ActStatus);
            this.Controls.Add(this.ActSend);
            this.Controls.Add(this.OutLog);
            this.Controls.Add(this.ScoreStatus);
            this.Controls.Add(this.MailList);
            this.Controls.Add(this.ScoreSend);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Отправка счётов за тех.обслуживание";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAILSDataSet)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScoreSend;
        private System.Windows.Forms.DataGridView MailList;
        private MAILSDataSet mAILSDataSet;
        private System.Windows.Forms.BindingSource smailBindingSource;
        private MAILSDataSetTableAdapters.SmailTableAdapter smailTableAdapter;
        private System.Windows.Forms.Label ScoreStatus;
        private System.Windows.Forms.ListBox OutLog;
        private System.Windows.Forms.Button ActSend;
        private System.Windows.Forms.Label ActStatus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem письмоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстПисьмаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox MailText;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AKT;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jepgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gifToolStripMenuItem;
    }
}

