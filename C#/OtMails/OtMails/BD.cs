using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtMails
{
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();
        }



        private void BD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAILSDataSet.Smail' table. You can move, or remove it, as needed.
            this.smailTableAdapter.Fill(this.mAILSDataSet.Smail);
            
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            this.smailTableAdapter.Update(this.mAILSDataSet);       //update table adapter
            this.Close();                                           //close form
        }
    }
}
