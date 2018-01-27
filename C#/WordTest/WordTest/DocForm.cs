using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Threading.Tasks;

namespace WordTest
{
    public partial class DocForm : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();
        private string pathToTemplate { get { return Application.StartupPath + "\\" + pathTextBox.Text; } }         //path to template
        int SUM;                                                                                                    //cost for the services provided
        string NTW;                                                                                                 //Result of function numToWord
        public DocForm()
        {
            InitializeComponent();
        }

        private void GenerateBut_Click(object sender, EventArgs e)
        {
            Lb_StatusBar.Text = "Формирование";
            if (Z_Name.Text == "" || Z_Name.Text == " ") { Z_Name.Text = "Заказчик"; }                  //error protection on an empty value
            if (Z_COL.Text == "" || Z_COL.Text == " ") { Z_COL.Text = "0"; }                            //error protection on an empty value
            SUM = Convert.ToInt32(Z_COL.Text) * 100;                                                    //finding the cost for the services provided
            numToWord();                                                                                //convert numbers to words
            DateTime thisDay = DateTime.Today;                                                         
            int today = DateTime.Now.Day;                                                               //get receipt of today's date
            string FPast = DateTime.Now.AddMonths(-1).AddDays(-(today - 1)).ToString("dd.MM.yyyy");     //get first day of previous month
            string LPast = DateTime.Now.AddDays(-today).ToString("dd.MM.yyyy");                         //get last day of previous month
            WordDocument wordDoc = null;
            try                                                                                         //try to create word document
            {
                wordDoc = new WordDocument(pathToTemplate);                                             //create word document
                if (replaceAllСheckBox.Checked)                                                         //hiden checkbox with check status = checked by default (necessary for further updates)
                {
                    wordDoc.ReplaceAllStrings("@@Kol", Z_COL.Text);                                     //replace @@Kol in template with value in Z_COL TextBox
                    wordDoc.ReplaceAllStrings("@@NameZak", Z_Name.Text);                                //replace @@NameZak in template with value in Z_Name TextBox

                    if (Z_OGRN.Text == "")                                                              //if OGRN fild is empty than replace @@OGRN else do same but add "ОГРН: "
                    { wordDoc.ReplaceAllStrings("@@OGRN", Z_OGRN.Text); }
                    else { wordDoc.ReplaceAllStrings("@@OGRN", "ОГРН: " + Z_OGRN.Text); }

                    if (Z_INN.Text == "")                                                               //if INN fild is empty than replace @@INN else do same but add "ИНН: "
                    { wordDoc.ReplaceAllStrings("@@INN", Z_INN.Text); }   
                    else {wordDoc.ReplaceAllStrings("@@INN", "ИНН: " + Z_INN.Text);}

                    if (Z_BIK.Text == "")                                                               //if BIK fild is empty than replace @@BIK else do same but add "БИК: "
                    { wordDoc.ReplaceAllStrings("@@BIK", Z_BIK.Text);}
                    else { wordDoc.ReplaceAllStrings("@@BIK", "БИК: " + Z_BIK.Text); }

                    wordDoc.ReplaceAllStrings("@@NumDog", replaceStrTextBox.Text);                      //replace @@NumDog in template with value in replaceStrTextBox TextBox
                    wordDoc.Selection.Aligment = TextAligment.Center;                                   //centering text in document
                    wordDoc.ReplaceAllStrings("@@SUM",SUM.ToString());                                  //replace @@SUM in template with value in SUM TextBox
                    wordDoc.ReplaceAllStrings("@@Today",thisDay.ToString("dd.MM.yyyy") +"г");           //replace @@Today in template with value of a variable thisDay 
                    wordDoc.ReplaceAllStrings("@@NumToWord", NTW);                                      //replace @@NumToWord in template with value of a variable NTW
                    wordDoc.ReplaceAllStrings("@@FD",FPast);                                            //replace @@FD in template with value of a variable FPast
                    wordDoc.ReplaceAllStrings("@@LD",LPast);                                            //replace @@LD in template with value of a variable LPast
                    wordDoc.ReplaceAllStrings("@@NN",NN.Text);                                          //replace @@NN in template with value in NN TextBox
                    wordDoc.ReplaceAllStrings("@@DatOfCre", Z_DatOfCre.Text);                           //replace @@DatOfCre in template with value in NN TextBox

                    if (Z_URadr.Text == "")                                                             //if URadr fild is empty than replace @@URadr else do same but add "Юридический адрес: "
                    { wordDoc.ReplaceAllStrings("@@URadr", Z_URadr.Text); }
                    else { wordDoc.ReplaceAllStrings("@@URadr", "Юридический адрес:" + Z_URadr.Text);}

                    if (Z_Rs.Text == "")                                                                //if Rs fild is empty than replace @@RS else do same but add "Р/С: "
                    { wordDoc.ReplaceAllStrings("@@RS", Z_Rs.Text); }
                    else { wordDoc.ReplaceAllStrings("@@RS", "Р/С:" + Z_Rs.Text); }

                    if (Z_Ks.Text == "")                                                                //if Ks fild is empty than replace @@KS else do same but add "К/С: "
                    { wordDoc.ReplaceAllStrings("@@KS", Z_Ks.Text); }
                    else { wordDoc.ReplaceAllStrings("@@KS", "К/С:" + Z_Ks.Text); }

                    if (Z_KPP.Text == "")                                                               //if KPP fild is empty than replace @@KPP else do same but add "КПП: "
                    { wordDoc.ReplaceAllStrings("@@KPP", Z_KPP.Text); }
                    else { wordDoc.ReplaceAllStrings("@@KPP", "КПП:" + Z_KPP.Text); }
                    Lb_StatusBar.Text = "Готово";
                }
               
            }
            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }                         //if microsoft word not find
                MessageBox.Show("Ошибка при замене текста на метке в документе  Word. Подробности: " + error.Message);
                Lb_StatusBar.Text = "Ошибка";
                return;
            }
            wordDoc.Save(@"C:\Act\" + Z_Name.Text + ".doc");            //save document as company name.doc
            wordDoc.Visible = false;                                    //windows visible control
            wordDoc.Close();                                            //free space
        }
        private void numToWord()                                        //convert numbers to words
        {
            int number = Convert.ToInt32(SUM);                          //get SUM as int32 number
            int[] array_int = new int[4];                               //create array
            string[,] array_string = new string[4, 3] {{" миллиард", " миллиарда", " миллиардов"},
                {" миллион", " миллиона", " миллионов"},
                {" тысяча", " тысячи", " тысяч"},
                {"", "", ""}};
            array_int[0] = (number - (number % 1000000000)) / 1000000000;
            array_int[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;
            array_int[2] = ((number % 1000000) - (number % 1000)) / 1000;
            array_int[3] = number % 1000;
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                if (array_int[i] != 0)
                {
                    if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                        switch (((array_int[i] - (array_int[i] % 100)) / 100))                  //definition of thousandths
                        {
                            case 1: result += " сто"; break;
                            case 2: result += " двести"; break;
                            case 3: result += " триста"; break;
                            case 4: result += " четыреста"; break;
                            case 5: result += " пятьсот"; break;
                            case 6: result += " шестьсот"; break;
                            case 7: result += " семьсот"; break;
                            case 8: result += " восемьсот"; break;
                            case 9: result += " девятьсот"; break;
                        }
                    if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                    {
                        switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)     //definition of hundredths
                        {
                            case 2: result += " двадцать"; break;
                            case 3: result += " тридцать"; break;
                            case 4: result += " сорок"; break;
                            case 5: result += " пятьдесят"; break;
                            case 6: result += " шестьдесят"; break;
                            case 7: result += " семьдесят"; break;
                            case 8: result += " восемьдесят"; break;
                            case 9: result += " девяносто"; break;
                        }
                    }
                    switch (array_int[i] % 10)                                                 //definition of tenths
                    {
                        case 1: if (i == 2) result += " одна"; else result += " один"; break;
                        case 2: if (i == 2) result += " две"; else result += " два"; break;
                        case 3: result += " три"; break;
                        case 4: result += " четыре"; break;
                        case 5: result += " пять"; break;
                        case 6: result += " шесть"; break;
                        case 7: result += " семь"; break;
                        case 8: result += " восемь"; break;
                        case 9: result += " девять"; break;
                    }
                }
                else switch (array_int[i] % 100)                                                //definition of tenths +
                    {
                        case 10: result += " десять"; break;
                        case 11: result += " одиннадцать"; break;
                        case 12: result += " двенадцать"; break;
                        case 13: result += " тринадцать"; break;
                        case 14: result += " четырнадцать"; break;
                        case 15: result += " пятнадцать"; break;
                        case 16: result += " шестнадцать"; break;
                        case 17: result += " семнадцать"; break;
                        case 18: result += " восемннадцать"; break;
                        case 19: result += " девятнадцать"; break;
                    }
                if (array_int[i] % 100 >= 10 && array_int[i] % 100 <= 19) result += " " + array_string[i, 2] + " ";
                else switch (array_int[i] % 10)
                    {
                        case 1: result += " " + array_string[i, 0] + " "; break;
                        case 2:
                        case 3:
                        case 4: result += " " + array_string[i, 1] + " "; break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9: result += " " + array_string[i, 2] + " "; break;
                    }
            }
            NTW = result;                                                                      //convert as the result
        }

        private void DocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();   //close application
        }

        private void AllKeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))     //control of input data
                {
                    e.Handled = true;
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для работы необхадимо включить в Word панель разработчика, для этого необхадимо: Файл > Настроить ленту > Основные вкладки > Поставить галочку 'Разработчик', Что бы сохранились данные необхадимо создать папку 'Act' здесь: 'С:\\'. Поле 'Заказчик' действует как поисковик","Справка"); //help message
        }

        private void DocForm_Load(object sender, EventArgs e)
        {
            DbList.CellDoubleClick += DbList_CellDoubleClick;
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                           @"Data Source= MainBD.mdb");                                     //connect to database

            adapter = new OleDbDataAdapter("SELECT * FROM ZAKAZ", conn);                    //get data from table "Zakaz"
            new OleDbCommandBuilder(adapter);
            adapter.Fill(dt);                                                               
            DbList.DataSource = dt;                                                         //fill datagrid with data from databse

            //customize the table
            DbList.Columns[0].Visible = false;
            DbList.Columns[1].HeaderText = "Заказчик";
            DbList.Columns[1].Width = 120;
            DbList.Columns[2].HeaderText = "№ Договора";
            DbList.Columns[3].HeaderText = "ИНН";
            DbList.Columns[4].HeaderText = "БИК";
            DbList.Columns[5].HeaderText = "ОГРН";
            DbList.Columns[6].HeaderText = "Юр.Адрес";
            DbList.Columns[6].Width = 205;
            DbList.Columns[7].HeaderText = "Р/С";
            DbList.Columns[7].Width = 135;
            DbList.Columns[8].HeaderText = "К/С";
            DbList.Columns[8].Width = 135;
            DbList.Columns[9].HeaderText = "КПП";
            DbList.Columns[10].HeaderText = "Колличество";
            DbList.Columns[11].HeaderText = "№ договора";
            DbList.Columns[12].HeaderText = "Дата создания";
            DbList.Columns[12].Width = 135;

            //columns 1-9,12 is read only
            DbList.Columns[1].ReadOnly = true;
            DbList.Columns[2].ReadOnly = true;
            DbList.Columns[3].ReadOnly = true;
            DbList.Columns[4].ReadOnly = true;
            DbList.Columns[5].ReadOnly = true; 
            DbList.Columns[6].ReadOnly = true;
            DbList.Columns[7].ReadOnly = true;
            DbList.Columns[8].ReadOnly = true;
            DbList.Columns[9].ReadOnly = true;
            DbList.Columns[12].ReadOnly = true;
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DbList.RowCount; i++)
            {
                DbList.Rows[i].Selected = false;
                for (int j = 0; j < DbList.ColumnCount; j++)
                    if (DbList.Rows[i].Cells[j].Value != null)
                        if (DbList.Rows[i].Cells[j].Value.ToString().Contains(Z_Name.Text))             //search name conpany by text from "Name company" field
                        {
                            NN.Text = DbList.Rows[i].Cells[j + 1].Value.ToString();                     //load Code of contract in the field
                            Z_INN.Text = DbList.Rows[i].Cells[j + 2].Value.ToString();                  //load identification Number in the field
                            Z_BIK.Text = DbList.Rows[i].Cells[j + 3].Value.ToString();                  //load Bank Identification Code name in the field
                            Z_OGRN.Text = DbList.Rows[i].Cells[j + 4].Value.ToString();                 //load main state registration number in the field
                            Z_URadr.Text = DbList.Rows[i].Cells[j + 5].Value.ToString();                //load Legal address in the field
                            Z_Rs.Text = DbList.Rows[i].Cells[j + 6].Value.ToString();                   //load Checking account in the field
                            Z_Ks.Text = DbList.Rows[i].Cells[j + 7].Value.ToString();                   //load corporate account in the field
                            Z_KPP.Text = DbList.Rows[i].Cells[j + 8].Value.ToString();                  //load Code of reason in the field
                            Z_COL.Text = DbList.Rows[i].Cells[j + 9].Value.ToString();                  //load Number of services in the field
                            replaceStrTextBox.Text = DbList.Rows[i].Cells[j + 10].Value.ToString();     //load Number of contract in the field
                            Z_DatOfCre.Text = DbList.Rows[i].Cells[j + 11].Value.ToString();
                            break;
                        }
                DelSymb();
            }
        }

        private void DbList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Z_Name.Text = DbList.Rows[e.RowIndex].Cells[1].Value.ToString();                                //load company name in the field
            NN.Text = DbList.Rows[e.RowIndex].Cells[2].Value.ToString();                                    //load Code of contract in the field
            Z_INN.Text = DbList.Rows[e.RowIndex].Cells[3].Value.ToString();                                 //load identification Number in the field
            Z_BIK.Text = DbList.Rows[e.RowIndex].Cells[4].Value.ToString();                                 //load Bank Identification Code name in the field
            Z_OGRN.Text = DbList.Rows[e.RowIndex].Cells[5].Value.ToString();                                //load main state registration number in the field
            Z_URadr.Text = DbList.Rows[e.RowIndex].Cells[6].Value.ToString();                               //load Legal address in the field
            Z_Rs.Text = DbList.Rows[e.RowIndex].Cells[7].Value.ToString();                                  //load Checking account in the field
            Z_Ks.Text = DbList.Rows[e.RowIndex].Cells[8].Value.ToString();                                  //load corporate account in the field
            Z_KPP.Text = DbList.Rows[e.RowIndex].Cells[9].Value.ToString();                                 //load Code of reason in the field
            Z_COL.Text = DbList.Rows[e.RowIndex].Cells[10].Value.ToString();                                //load Number of services in the field
            replaceStrTextBox.Text = DbList.Rows[e.RowIndex].Cells[11].Value.ToString();                    //load Number of contract in the field
            Z_DatOfCre.Text = DbList.Rows[e.RowIndex].Cells[12].Value.ToString();                           //load Date of creation in the field
            DelSymb();                                                                                      //remove time symb from date
        }

        private void сбросИзмененийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Z_Name.Text = "";                               //
            NN.Text = "";                                   //
            Z_INN.Text = "";                                //
            Z_BIK.Text = "";                                //
            Z_OGRN.Text = "";                               //
            Z_URadr.Text = "";                              //erase all data
            Z_COL.Text = "0";                               //
            Z_KPP.Text = "";                                //and restore to default
            Z_Ks.Text = "";                                 //
            Z_Rs.Text = "";                                 //
            Z_DatOfCre.Text = "";                           //
            replaceStrTextBox.Text = "";                    //
            pathTextBox.Text = "Shab.docx";                 //
        }

        private async void сформироватьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Z_Name.Enabled = false;                                     //
            NN.Enabled = false;                                         //
            Z_INN.Enabled = false;                                      //
            Z_BIK.Enabled = false;                                      //
            Z_OGRN.Enabled = false;                                     //
            Z_URadr.Enabled = false;                                    //
            Z_COL.Enabled = false;                                      //
            Z_KPP.Enabled = false;                                      //
            Z_Ks.Enabled = false;                                       //  Disabling UI for sefety
            Z_Rs.Enabled = false;                                       //
            Z_DatOfCre.Enabled = false;                                 //
            replaceStrTextBox.Enabled = false;                          //
            pathTextBox.Enabled = false;                                //
            справкаToolStripMenuItem.Enabled = false;                   //
            сбросИзмененийToolStripMenuItem.Enabled = false;            //
            сформироватьВсеToolStripMenuItem.Enabled = false;           //
            сохранитьИзмененияToolStripMenuItem.Enabled = false;        //
            увеличитьНомерДоговораToolStripMenuItem.Enabled = false;    //
            GenerateBut.Enabled = false;                                //
            SearchBut.Enabled = false;                                  //

            await GenerateAllDocs();                                    //  Run generate documents

            Z_Name.Enabled = true;                                      //
            NN.Enabled = true;                                          //
            Z_INN.Enabled = true;                                       //
            Z_BIK.Enabled = true;                                       //
            Z_OGRN.Enabled = true;                                      //
            Z_URadr.Enabled = true;                                     //
            Z_COL.Enabled = true;                                       //
            Z_KPP.Enabled = true;                                       //
            Z_Ks.Enabled = true;                                        //  Аctivation UI
            Z_Rs.Enabled = true;                                        //
            Z_DatOfCre.Enabled = true;                                  //
            replaceStrTextBox.Enabled = true;                           //
            pathTextBox.Enabled = true;                                 //
            справкаToolStripMenuItem.Enabled = true;                    //
            сбросИзмененийToolStripMenuItem.Enabled = true;             //
            сформироватьВсеToolStripMenuItem.Enabled = true;            //
            сохранитьИзмененияToolStripMenuItem.Enabled = true;         // 
            увеличитьНомерДоговораToolStripMenuItem.Enabled = true;     //
            GenerateBut.Enabled = true;                                 //
            SearchBut.Enabled = true;                                   //
        }

        private Task GenerateAllDocs()
        {
            return Task.Run(() =>
            {
               
                int CompletedCounter = 0;

                for (int i = 0; i < DbList.RowCount; i++)                                   //do until reach the last line
                {
                    Z_Name.Text = DbList.Rows[i].Cells[1].Value.ToString();                 //get name company
                    SearchBut_Click(this, EventArgs.Empty);                                 //search company and load into text boxes
                    GenerateBut_Click(this, EventArgs.Empty);                               //generate documents
                    CompletedCounter++;
                }
                MessageBox.Show("Успешно сформированных документов: " + CompletedCounter + " из " + DbList.RowCount);

            });
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
               @"Data Source= MainBD.mdb");                                                     //connect to database
            adapter.Update(dt);                                                                 //update database
        }

        private void увеличитьНомерДоговораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbList.Rows[0].Cells[11].Selected = true;                                                       //started from the beginning
            for (int i= 0;i<DbList.Rows.Count;i++)                                                          //do until reach the last line
            {
                if (DbList.Rows[i].Cells[11].Value != null)                                                 //if cell not empty
                {
                    DbList.Rows[i].Cells[11].Value = Convert.ToInt32(DbList.Rows[i].Cells[11].Value) + 1;   //cell value + 1
                }
                else
                {
                    DbList.Rows[i].Cells[11].Value = 0;                                                     //else cell value = 0
                }
            }
        }
        private void DelSymb()
        {
            string s = Z_DatOfCre.Text;

            if (s.Length > 10)
            {
                s = s.Substring(0, s.Length - 8);
            }

            Z_DatOfCre.Text = s;
        }
    }

}
