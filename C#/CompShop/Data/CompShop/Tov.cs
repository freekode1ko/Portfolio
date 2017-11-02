using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.IO;



namespace CompShop
{
    public partial class Tov : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();
        Int32 TRANZAKT = 0;
        public Tov()
        {
            InitializeComponent();
            listBox1.Text = Properties.Settings.Default.Save_text1;
            Properties.Settings.Default.Save();
        }
        //connect to database at loading form
        private void Tov_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'clientDataSet1.FACIL' table. You can move, or remove it, as needed.
            this.fACILTableAdapter.Fill(this.clientDataSet1.FACIL);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;                               
            dataGridView1.Columns[2].ReadOnly = true;
            conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" +
                           @"Data Source= Client.mdb");

            adapter = new OleDbDataAdapter("SELECT * FROM TOVARs", conn);
            new OleDbCommandBuilder(adapter);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //to client form
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.ShowDialog();
        }
        //change user
        private void зайтиКакДругойПользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingIN f3 = new SingIN();
            f3.ShowDialog();
        }
        //Upload to DataBase at close form
        private void Tov_FormClosing(object sender, FormClosingEventArgs e)
        {
            adapter.Update(dt);
            Properties.Settings.Default.Save_text1 = listBox1.Text; // Записываем содержимое в Save_text
            Properties.Settings.Default.Save(); // Сохраняем переменные.
        }
        // deduction of the quantity of goods from the database
        private void продатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MinusBox.Text == "") { MessageBox.Show("Поле не должно быть пустым", "Внимание !"); }
            else
            {
                Int32 VAL = Convert.ToInt32(MinusBox.Text);
                VAL = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) - VAL;
                if (VAL >= 0)
                {
                    dataGridView1.Columns[2].ReadOnly = false;
                    dataGridView1.CurrentRow.Cells[2].Value = VAL;
                    adapter.Update(dt);
                    dataGridView1.Columns[2].ReadOnly = true;
                    listBox1.Items.Add("- " + MinusBox.Text);
                    TRANZAKT++;
                }
                else { MessageBox.Show("На складе недостаточно товара", "Внимание!"); }
            }
        }
        //addition of the quantity of goods from the database
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PlusBox.Text == "") { MessageBox.Show("Поле не должно быть пустым", "Внимание !"); }
            else
            {
                dataGridView1.Columns[2].ReadOnly = false;
                Int32 VAL = Convert.ToInt32(PlusBox.Text);
                VAL = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) + VAL;
                dataGridView1.CurrentRow.Cells[2].Value = VAL;
                adapter.Update(dt);
                dataGridView1.Columns[2].ReadOnly = true;
                listBox2.Items.Add("+ " + PlusBox.Text);
                TRANZAKT++;
            }
        }
        //check for empty values
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fACILTableAdapter.FillBy(this.clientDataSet1.FACIL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // to facilyty form
        private void производительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facilyty f4 = new Facilyty();
            f4.ShowDialog();
        }
        //check formation
        private void ToCsV(DataGridView dGV, string filename)
        {
            string LBVALUE = "";
            string stOutput = "";
            string sHeaders = "";
            if (CB_TOVARS.Checked == true)
            {
                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }
            }

            Encoding Uni = Encoding.UTF8;
            byte[] output = Uni.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(output, 0, output.Length); //write the encoded file
            if (CB_TRANZ.Checked == true)
            {
                bw.Write("\r\n" + "Список последних транзакций" + "\r\n" + "Продажи" + "\r\n");
                if (listBox1.Items.Count > 0)
                {
                    listBox1.SelectedIndex = 0;


                    int l = 1;
                    while (l <= listBox1.Items.Count)
                    {
                        LBVALUE = listBox1.SelectedItem.ToString();
                        bw.Write(LBVALUE + "\r\n");
                        if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                        {
                            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                        }
                        l++;
                    }
                }
                bw.Write("Поставка" + "\r\n");
                if (listBox2.Items.Count > 0)
                {
                    listBox2.SelectedIndex = 0;
                    int l = 1;
                    while (l <= listBox2.Items.Count)
                    {
                        LBVALUE = listBox2.SelectedItem.ToString();
                        bw.Write(LBVALUE + "\r\n");
                        if (listBox2.SelectedIndex < listBox2.Items.Count - 1)
                        {
                            listBox2.SelectedIndex = listBox2.SelectedIndex + 1;
                        }
                        l++;
                    }
                }
            }
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        //call formation check
        private void Chek_Click(object sender, EventArgs e)
        {
            if (CB_TOVARS.Checked == false && CB_TRANZ.Checked == false)
            { MessageBox.Show("Для начала выберите то, что необходимо в чеке", "Внимание!"); }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Word Documents (*.doc)|*.doc";
                sfd.FileName = "export.doc";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name 
                }
            }
        }

        private void TOVchek_Click(object sender, EventArgs e)
        {
            if (CB_TOVARS.Checked == true) { CB_TOVARS.Checked = false; }
            else { CB_TOVARS.Checked = true; }
        }

        private void CB_TRANZ_Click(object sender, EventArgs e)
        {
            if (CB_TRANZ.Checked == true) { CB_TRANZ.Checked = false; }
            else { CB_TRANZ.Checked = true; }
        }
    }
}
