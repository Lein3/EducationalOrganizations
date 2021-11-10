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
        public MailingForm(List<string> temp_emails)
        {
            InitializeComponent();
            emails = temp_emails;
            guna2DataGridView_Emails.DataSource = emails.Select(a => new { Value = a }).ToList();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            try
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
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Проверьте введенные логин и пароль, если ошибка сохраняется - обратитесь к администратору");
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
                if (textBox1.Text.Length == 0)
                {
                    label_validation1.Visible = true;
                    result = false;
                }
                if (!Regex.IsMatch(textBox1.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && textBox1.Text != "")
                {
                    label_validation12.Visible = true;
                    result = false;
                }
                if (!containsAcceptedEmail)
                {
                    label_validation13.Visible = true;
                    result = false;
                }
                if (textBox2.Text.Length == 0)
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
    }
}
