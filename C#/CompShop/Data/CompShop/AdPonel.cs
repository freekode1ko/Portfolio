using System;
using System.Windows.Forms;

namespace CompShop
{
    public partial class AdPonel : Form
    {
        public AdPonel()
        {
            InitializeComponent();
        }

        private void AdPonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDataSet1.USERs' table. You can move, or remove it, as needed.
            this.uSERsTableAdapter1.Fill(this.clientDataSet1.USERs);
        }
        //to Main form
        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.ShowDialog();
        }

        private void AdPonel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Upload to DataBase
        private void обновитьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.uSERsTableAdapter1.Update(this.clientDataSet1);
        }
        //Change user
        private void зайтиКакДругойПользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingIN f3 = new SingIN();
            f3.ShowDialog();
        }
    }
}
