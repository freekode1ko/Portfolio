using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace OtMails
{
    public partial class MainForm : Form
    {
        string FORhu, ComNamSen, FilNameSen;
        string FileFormat = ".jpg";                     //Default File format on send
        string MailPass = "Password";               //Mail password
        string MailFrom = "Mail@yandex.ru";     //Mail of the sender
        int Rn,i;
        bool ActCheck;                                  //Check for the need for an act

        private void SendAct_Click(object sender, EventArgs e)
        {
            ActStatus.Text = "Отправка";
            Rn = 0;
            i = 0;
            int j = MailList.ColumnCount - 1;
            int ErrorCounter = 0;                   //error counter for sending act
            int Sended = 0;                         //number of sended acts
            while (Rn <= MailList.RowCount - 1)     //while row count more or equal run number
            {
                if (i <= MailList.RowCount - 1)
                {
                    MailList.CurrentCell = MailList.Rows[i].Cells[0];           //start from the beginning
                    FORhu = MailList.CurrentRow.Cells[0].Value.ToString();      // Get mail for hu need
                    ComNamSen = MailList.CurrentRow.Cells[1].Value.ToString();  // Get companu name
                    ActCheck = Convert.ToBoolean(MailList.CurrentRow.Cells[2].Value);  // Need akt or not
                    i++;
                    if (ActCheck == true)                                       //if the act must be sent to this sender, then take the file along the necessary path
                    {
                        FilNameSen = Path.GetFullPath("\\Act\\" + "Акт " + ComNamSen + FileFormat); //set path for file
                        if (FilNameSen != null)                                                     //if path is not empty, than send mail
                        {
                            SendMail("smtp.yandex.ru", MailFrom, MailPass, FORhu, "Счёт за ТО", MailText.Text, FilNameSen);         //send mail
                            j--;
                            Rn++;
                            Sended++;
                        }
                        else
                        { ErrorCounter++;}
                    }else { 
                        if (i == MailList.RowCount)    //If the pointer at the end of the mallist than end 
                            break;
                    }
                }
               }
            //update status
            OutLog.Items.Add ("Колличество ошибок при отправке актов: " + ErrorCounter);
            OutLog.Items.Add("Колличество успешно отправленых актов: " + Sended);
            OutLog.Items.Add("-----------------------------------------------------------------------------------------------------------------");
            ActStatus.Text = "Готово";
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Олег Дрябков +7 (985) 199-83-12", "О разработчике");          //show about
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для отправки актов и/или счетов необхадомо нажать соответствующую кнопку. Есле необхадимо дополнить базу данных то необхадимо открыть в кладку База данных и в свободные поля заполнить информацию. В случае если отправка была не успешной, то проверьте наличие отправляемого файла по следующему пути C:\\Act\\<Название>.jpg","Справка"); //show help
        }

        private void базаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BD formBD = new BD();
            this.Hide();
            formBD.ShowDialog();
            this.Show();
            this.smailTableAdapter.Fill(this.mAILSDataSet.Smail);
        }

        private void текстПисьмаToolStripMenuItem_Click(object sender, EventArgs e)         //showing a line for the mail text
        {
            MailText.Visible = true;
            this.Height = 420;
        }

        private void jpgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jepgToolStripMenuItem.Checked = false;                                          //uncheck jepg item 
            gifToolStripMenuItem.Checked = false;                                           //uncheck gif item 
            jpgToolStripMenuItem.Checked = true;                                            //check jpg item 
            FileFormat = ".jpg";                                                            //set jpg as format file
        }

        private void jepgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jpgToolStripMenuItem.Checked = false;                                           //uncheck jpg item 
            gifToolStripMenuItem.Checked = false;                                           //uncheck gif item 
            jepgToolStripMenuItem.Checked = true;                                           //check jepg item 
            FileFormat = ".jpeg";                                                           //set jpeg as format file
        }

        private void gifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jepgToolStripMenuItem.Checked = false;                                          //uncheck jpeg item 
            jpgToolStripMenuItem.Checked = false;                                           //uncheck jpg item 
            gifToolStripMenuItem.Checked = true;                                            //check gif item 
            FileFormat = ".gif";                                                            //set gif as format file
        }   

        public MainForm()
        {
            InitializeComponent();
        }
        public static void SendMail(string smtpServer, string from, string password,
        string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);                              //sender definition
                mail.To.Add(new MailAddress(mailto));                           //definition of the recipient
                mail.Subject = caption;                                         //adding caption to mail
                mail.Body = message;                                            //adding message to mail
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));           //attaching file
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;                                       //host
                client.Port = 587;                                              //port
                client.EnableSsl = true;                                        //enabling Secure Sockets Layer (true\false)
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);       //password
                client.DeliveryMethod = SmtpDeliveryMethod.Network;                             //method
                client.Send(mail);                                                              
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
        private void CheckSend_Click(object sender, EventArgs e)
        {
            ScoreStatus.Text = "Отправка";
            Rn = 0;
            i = 0;
            int j = MailList.ColumnCount - 1;
            int ErrorCounter = 0;                   //error counter for sending act
            int Sended = 0;                         //number of sended acts
            while (Rn <= MailList.RowCount - 1)     //while row count more or equal run number
            {
                if (i <= MailList.RowCount -1 )
                {
                    MailList.CurrentCell = MailList.Rows[i].Cells[0];               //start from the beginning
                    FORhu = MailList.CurrentRow.Cells[0].Value.ToString();          // Get mail for hu need
                    ComNamSen = MailList.CurrentRow.Cells[1].Value.ToString();      //Get companu name
                    FilNameSen = Path.GetFullPath("\\Act\\"+ComNamSen+ FileFormat); //set path for file
                    if (FilNameSen != null)                                         //if path is not empty, than send mail
                    {
                        SendMail("smtp.yandex.ru", MailFrom, MailPass, FORhu, "Счёт за ТО", MailText.Text, FilNameSen);     //send mail
                        i++;
                        j--;
                        Rn++;
                        Sended++;
                    }
                    else
                        {ErrorCounter ++;}
                }
                
            }
            //update status
            OutLog.Items.Add ("Колличествово ошибок при отпавке счетов: " + ErrorCounter);
            OutLog.Items.Add("Колличество успешно отправленых счетов: " + Sended);
            OutLog.Items.Add("-----------------------------------------------------------------------------------------------------------------");
            ScoreStatus.Text = "Готово";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAILSDataSet.Smail' table. You can move, or remove it, as needed.
            this.smailTableAdapter.Fill(this.mAILSDataSet.Smail);
            MailList.Columns[0].ReadOnly = true;
            MailList.Columns[1].ReadOnly = true;
            MailList.Columns[2].ReadOnly = false;

        }
    }
}
