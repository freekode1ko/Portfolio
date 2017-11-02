using System;
using System.Windows.Forms;

namespace CompShop
{
    public partial class Facilyty : Form
    {
        public Facilyty()
        {
            InitializeComponent();
        }

        private void fACILBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fACILBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientDataSet1);

        }

        private void Facilyty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDataSet1.FACIL' table. You can move, or remove it, as needed.
            this.fACILTableAdapter.Fill(this.clientDataSet1.FACIL);

        }
    }
}
