using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EducationalOrganizationsApp
{
    public partial class MailingForm : Form
    {
        List<string> emails;
        List<string> files;
        Mailing mailFormDb = null;
        bool useDataFromDb = false;
        public MailingForm(List<string> temp_emails)
        {
            InitializeComponent();
            emails = temp_emails;
            guna2DataGridView_Emails.DataSource = emails.Select(a => new { Value = a }).ToList();

            var listMailings = Connection.db.Mailing.ToList();
            listMailings.Insert(0, new Mailing { ID = 0, Email = "почта не выбрана", Password = "" });
            comboBox_mailing.DataSource = listMailings;
            comboBox_mailing.DisplayMember = "Email";
            comboBox_mailing.ValueMember = "ID";
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            label_validation1.Visible = false;
            label_validation12.Visible = false;
            label_validation13.Visible = false;
            label_validation2.Visible = false;
            label_validation4.Visible = false;
            if (Validation() == true)
            {
                if (MessageBox.Show("Провести рассылку?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (useDataFromDb)
                        SendFromDbMail();
                    else
                        SendFromNewMail();
                }
            }      
        }

        private void SendFromDbMail()
        {
            try
            {
                foreach (var email in emails)
                {
                    if (email == "")
                        continue;
                    string smtp_string = "";
                    if (mailFormDb.Email.Contains("@mail.ru"))
                        smtp_string = "smtp.mail.ru";
                    if (mailFormDb.Email.Contains("@gmail.com"))
                        smtp_string = "smtp.gmail.com";
                    if (mailFormDb.Email.Contains("@yandex.ru"))
                        smtp_string = "smtp.yandex.ru";
                    MailAddress from = new MailAddress(mailFormDb.Email);
                    MailAddress to = new MailAddress(email);
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = textBox3.Text;
                    message.Body = textBox4.Text;
                    AddAttachment(message);
                    SmtpClient smtp = new SmtpClient(smtp_string, 25);
                    smtp.Credentials = new NetworkCredential(mailFormDb.Email, mailFormDb.Password);
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
                MessageBox.Show("все сообщения отправлены");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Проверьте введенные логин и пароль, если ошибка сохраняется - обратитесь к администратору");
            }
        }
        private void SendFromNewMail()
        {
            try
            {
                foreach (var email in emails)
                {
                    if (email == "")
                        continue;
                    string smtp_string = "";
                    if (textBox1.Text.Contains("@mail.ru"))
                        smtp_string = "smtp.mail.ru";
                    if (textBox1.Text.Contains("@gmail.com"))
                        smtp_string = "smtp.gmail.com";
                    if (textBox1.Text.Contains("@yandex.ru"))
                        smtp_string = "smtp.yandex.ru";
                    MailAddress from = new MailAddress(textBox1.Text);
                    MailAddress to = new MailAddress(email);
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = textBox3.Text;
                    message.Body = textBox4.Text;
                    AddAttachment(message);
                    SmtpClient smtp = new SmtpClient(smtp_string, 25);
                    smtp.Credentials = new NetworkCredential(textBox1.Text, textBox2.Text);
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
                MessageBox.Show("все сообщения отправлены");
                var mailing = new Mailing();
                mailing.Email = textBox1.Text;
                mailing.Password = textBox2.Text;
                if (checkBox_rememberMe.Checked == true && NotExist(mailing))
                {
                    Connection.db.Mailing.Add(mailing);
                    Connection.db.SaveChanges();
                }    
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Проверьте введенные логин и пароль, если ошибка сохраняется - обратитесь к администратору");
            }
        }

        private bool NotExist(Mailing _object)
        {
            try
            {
                bool result = !Connection.db.Mailing.Any(a => a.Email == _object.Email && a.Password == _object.Password);
                return result;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
                return false;
            }
        }

        private void AddAttachment(MailMessage message)
        {
            if(files != null)
                foreach (string file in files)
                    message.Attachments.Add(new Attachment(file));
        }

        private bool Validation()
        {
            try
            {
                bool result = true;
                bool containsAcceptedEmail = textBox1.Text.Contains("@mail.ru") || textBox1.Text.Contains("@gmail.com") || textBox1.Text.Contains("@yandex.ru");
                if (textBox1.Text.Length == 0 && textBox1.Enabled == true)
                {
                    label_validation1.Visible = true;
                    result = false;
                }
                if (!Regex.IsMatch(textBox1.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && textBox1.Text != "" && textBox1.Enabled == true)
                {
                    label_validation12.Visible = true;
                    result = false;
                }
                if (!containsAcceptedEmail && textBox1.Enabled == true)
                {
                    label_validation13.Visible = true;
                    result = false;
                }
                if (textBox2.Text.Length == 0 && textBox2.Enabled == true)
                {
                    label_validation2.Visible = true;
                    result = false;
                }
                if (textBox4.Text.Length == 0)
                {
                    label_validation4.Visible = true;
                    result = false;
                }
                return result;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
                return false;
            }
        }

        private void guna2DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string email = guna2DataGridView_Emails.CurrentCell.Value.ToString();
            var organization = Connection.db.Organizations.Where(a => a.Email == email).FirstOrDefault();
            label_addressname.Text = organization.ShortName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();
            files = openFileDialog.FileNames.ToList();
            List<string> temp = new List<string>();
            foreach (string file in files)
                temp.Add(System.IO.Path.GetFileName(file));
            guna2DataGridView_Files.DataSource = temp.Select(a => new { Value = a }).ToList();
        }

        private void comboBox_mailing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_mailing.SelectedIndex != 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                var id = comboBox_mailing.SelectedValue;
                mailFormDb = Connection.db.Mailing.Find(id);
                useDataFromDb = true;
                button_mailing_Update.Enabled = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                useDataFromDb = false;
                button_mailing_Update.Enabled = false;
            }
        }

        private void button_mailing_Update_Click(object sender, EventArgs e)
        {
            var id = comboBox_mailing.SelectedValue;
            mailFormDb = Connection.db.Mailing.Find(id);
            new MailingForm_Update(mailFormDb).ShowDialog();
        }

        private void button_passwordVisible_MouseEnter(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button_passwordVisible_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
