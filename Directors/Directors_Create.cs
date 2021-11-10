using System;
using System.Linq;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class Directors_Create : Form
    {
        public Directors_Create()
        {
            InitializeComponent();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                    textBox.Text = textBox.Text.Trim();
                Directors _object = new Directors { LastName = textBox1.Text, FirstName = textBox2.Text, MiddleName = textBox3.Text };
                if (IsNotExist(_object))
                {
                    if (MessageBox.Show("Добавить запись с введенными данными?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Connection.db.Directors.Add(_object);
                        Connection.db.SaveChanges();
                        MessageBox.Show("Запись добавлена");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Запись уже существует");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }

        private bool IsNotExist(Directors _object)
        {            
            try
            {
                bool result = !Connection.db.Directors.Any(a => a.LastName == _object.LastName
                && a.FirstName == _object.FirstName
                && a.MiddleName == _object.MiddleName);
                return result;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
                return false;
            }
        }

        private void OnlyChars(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }
    }
}
