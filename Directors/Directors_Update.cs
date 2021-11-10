using System;
using System.Linq;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class Directors_Update : Form
    {
        Directors _object;
        public Directors_Update(Directors temp_object)
        {
            InitializeComponent();
            try
            {
                _object = temp_object;
                textBox1.Text = _object.LastName;
                textBox2.Text = _object.FirstName;
                textBox3.Text = _object.MiddleName;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                    textBox.Text = textBox.Text.Trim();
                if (MessageBox.Show("Обновить запись с введенными данными?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _object.LastName = textBox1.Text;
                    _object.FirstName = textBox2.Text;
                    _object.MiddleName = textBox3.Text;
                    Connection.db.SaveChanges();
                    MessageBox.Show("Запись добавлена");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
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
