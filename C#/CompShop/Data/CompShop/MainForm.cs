using System;
using System.Windows.Forms;

namespace CompShop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDataSet1.BYERs' table. You can move, or remove it, as needed.
            this.bYERsTableAdapter1.Fill(this.clientDataSet1.BYERs);
        }
        //update database
        private void обновитьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bYERsTableAdapter1.Update(this.clientDataSet1);
        }
        //to tov form
        private void списокТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tov f2 = new Tov();
            f2.ShowDialog();
        }
        //change user
        private void зайтиКакДругойПользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingIN f3 = new SingIN();
            f3.ShowDialog();
        }
    }
}
