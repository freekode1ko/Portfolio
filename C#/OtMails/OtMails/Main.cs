using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Threading.Tasks;

namespace OtMails
{
    public partial class MainForm : Form
    {
        string FORhu, ComNamSen, FilNameSen;
        string FileFormat = ".jpg";                     //Default File format on send
        string MailPass = "Mail password";               //Mail password
        string MailFrom = "Exemp@Domain.com";     //Mail of the sender
        bool ActCheck;                                  //Check for the need for an act

        private async void SendAct_Click(object sender, EventArgs e)
        {
            ActStatus.Text = "Отправка";
            int Rn = 0;
            int i = 0;
            int ErrorCounter = 0;                   //error counter for sending act
            int Sended = 0;                         //number of sended acts
            ActSend.Enabled = false;
            ScoreSend.Enabled = false;

            await SendAct(Rn, i, ErrorCounter, Sended);
        }

        private Task SendAct(int Rn, int i, int ErrorCounter, int Sended)
        { 
            return Task.Run(() =>
            {
                while (Rn <= MailList.RowCount - 1)     //while row count more or equal run number
                {

                    try
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
                                    Rn++;
                                    Sended++;
                                    OutLog.Items.Add("Отправлен Акт: " + ComNamSen + " \\ " + FORhu);
                                }

                            }
                        }
                        else { break; }     //If the pointer at the end of the mallist than end

                    }
                    catch (Exception ex)
                    {
                        ErrorCounter++;
                        Rn++;
                        OutLog.Items.Add("Ошибка отправки: " + ex.Message);
                    }
                }
                if (Sended == 0 && ErrorCounter == 0)
                { ActStatus.Text = "Проверте выборку актов для отпраки!"; }
                if (Sended != 0 || ErrorCounter != 0)
                {
                    //update status
                    OutLog.Items.Add("-----------------------------------------------------------------------------------------------------------------");
                    OutLog.Items.Add("Колличество ошибок при отправке актов: " + ErrorCounter);
                    OutLog.Items.Add("Колличество успешно отправленых актов: " + Sended);
                    OutLog.Items.Add("-----------------------------------------------------------------------------------------------------------------");
                    ActStatus.Text = "Готово";
                }
                ActSend.Enabled = true;
                ScoreSend.Enabled = true;
            });
        }
        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Олег Дрябков ", "О разработчике");          //show about
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = @"c:\Act\Log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("[" + DateTime.Now + "]");
                    sw.WriteLine("[Что отправлено: Кому отправлено \\ на какую почту]");
                    sw.WriteLine("__________________________________________________________________________________________________________________");
                    int i = 1;
                    while (i < OutLog.Items.Count)
                    {
                        sw.WriteLine(OutLog.Items[i]);
                        i++;
                    }
                    if (i == 1)
                        sw.WriteLine("Ничего не сформировано");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("__________________________________________________________________________________________________________________");
                    sw.WriteLine("[" + DateTime.Now + "]");
                    sw.WriteLine("__________________________________________________________________________________________________________________");
                    int i = 1;
                    while (i < OutLog.Items.Count)
                        {
                        sw.WriteLine(OutLog.Items[i-1]);
                        i++;
                        }
                    if (i == 1)
                        sw.WriteLine("Ничего не сформировано");
                }
            }

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
                throw new Exception(" " + e.Message);
            }
        }
        private async void CheckSend_Click(object sender, EventArgs e)
        {
            ScoreStatus.Text = "Отправка";
            int Rn = 0;
            int ErrorCounter = 0;                   //error counter for sending act
            int Sended = 0;                         //number of sended acts
            ActSend.Enabled = false;
            ScoreSend.Enabled = false;

            await SendChek(Rn, ErrorCounter, Sended);
        }

        private Task SendChek(int Rn, int ErrorCounter, int Sended)
        {
            return Task.Run(() =>
            {

                while (Rn <= MailList.RowCount - 1)     //while row count more or equal run number
                {
                    Application.DoEvents();
                    try
                    {
                        MailList.CurrentCell = MailList.Rows[Rn].Cells[0];               //start from the beginning
                        FORhu = MailList.CurrentRow.Cells[0].Value.ToString();          // Get mail for hu need
                        ComNamSen = MailList.CurrentRow.Cells[1].Value.ToString();      //Get companu name
                        FilNameSen = Path.GetFullPath("\\Act\\" + ComNamSen + FileFormat); //set path for file
                        if (FilNameSen != null)                                         //if path is not empty, than send mail
                        {
                            SendMail("smtp.yandex.ru", MailFrom, MailPass, FORhu, "Счёт за ТО", MailText.Text, FilNameSen);     //send mail
                            Rn++;
                            Sended++;
                            OutLog.Items.Add("Отправлен Счет: " + ComNamSen + " \\ " + FORhu);
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorCounter++;
                        Rn++;
                        OutLog.Items.Add("Ошибка отправки " + ex.Message);

                    }

                }
                //update status
                OutLog.Items.Add("-----------------------------------------------------------------------------------------------------------------");
                OutLog.Items.Add("Колличествово ошибок при отпавке счетов: " + ErrorCounter);
                OutLog.Items.Add("Колличество успешно отправленых счетов: " + Sended);
                OutLog.Items.Add("-----------------------------------------------------------------------------------------------------------------");
                ScoreStatus.Text = "Готово";
                ActSend.Enabled = true;
                ScoreSend.Enabled = true;
            });
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
