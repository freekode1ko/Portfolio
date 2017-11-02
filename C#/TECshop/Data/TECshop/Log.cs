using System;
using System.Windows.Forms;

namespace TECshop
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tecShopDataSet.Employer' table. You can move, or remove it, as needed.
            this.employerTableAdapter.Fill(this.tecShopDataSet.Employer);
            // TODO: This line of code loads data into the 'tecShopDataSet.Buyer' table. You can move, or remove it, as needed.
            this.buyerTableAdapter.Fill(this.tecShopDataSet.Buyer);

        }

        //to Client form
        private void UserBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                this.buyerTableAdapter.Update(this.tecShopDataSet);
                Client f2 = new Client();
                f2.Show();
                this.Hide();
            }
            else
            {
                string message = "Ошибка";
                string caption = "Пустые поля не допустимы!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

            }
        }

        //to Busines form
        private void BussBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                this.employerTableAdapter.Update(this.tecShopDataSet);
                Busines f3 = new Busines();
                f3.Show();
                this.Hide();
            }
            else
            {
                string message = "Ошибка";
                string caption = "Пустые поля не допустимы!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
