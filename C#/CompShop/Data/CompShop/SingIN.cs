using System;
using System.Windows.Forms;

namespace CompShop
{
    public partial class SingIN : Form
    {
        public SingIN()
        {
            InitializeComponent();
        }
           
        private void SingIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDataSet1.USERs' table. You can move, or remove it, as needed.
            this.uSERsTableAdapter1.Fill(this.clientDataSet1.USERs);

        }
        //logining to app
        private void EnterBut_Click(object sender, EventArgs e)
        {
              for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == LoginBox.Text)           //checking login
                    {
                        j++;
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == PasswordBox.Text)    //checking pass
                        {
                            j++;
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value) == false)       //if user
                            {
                                this.Hide();
                                MainForm f2 = new MainForm();
                                f2.ShowDialog();
                            }
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value) == true)        //if admin
                            {
                                this.Hide();
                                AdPonel f3 = new AdPonel();
                                f3.ShowDialog();
                            }
                            break;
                        }
                    }                  
        }

        private void SingIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterBut.PerformClick();
            }
        }
    }
}
