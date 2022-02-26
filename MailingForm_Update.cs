using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class MailingForm_Update : Form
    {
        Mailing mailing;
        public MailingForm_Update(Mailing temp)
        {
            InitializeComponent();
            mailing = temp;
            textBox1.Text = mailing.Email;
            textBox2.Text = mailing.Password;
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            label_validation1.Visible = false;
            label_validation12.Visible = false;
            label_validation13.Visible = false;
            label_validation2.Visible = false;
            if (Validation() == true)
            {
                if (MessageBox.Show("Обновить данные почты?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mailing.Email = textBox1.Text;
                    mailing.Password = textBox2.Text;
                    Connection.db.SaveChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
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
                return result;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
                return false;
            }
        }
    }
}
