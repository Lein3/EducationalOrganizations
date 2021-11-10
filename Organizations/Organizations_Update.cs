using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class Organizations_Update : Form
    {
        Organizations _object;
        public Organizations_Update(Organizations temp_object)
        {
            InitializeComponent();
            try
            {
                _object = temp_object;
                if (_object.Name != "")
                    textBox1.Text = Convert.ToString(_object.Name);
                textBox2.Text = Convert.ToString(_object.ShortName);
                maskedTextBox3.Text = Convert.ToString(_object.INN);
                textBox4.Text = Convert.ToString(_object.Address);
                textBox5.Text = Convert.ToString(_object.Website);
                SetDropDownLists();
                if (_object.Phone != "")
                    maskedTextBox9.Text = Convert.ToString(_object.Phone.Substring(1));
                if (_object.Phone.Length == 7)
                    maskedTextBox9.Text = Convert.ToString("383" + _object.Phone);
                textBox10.Text = Convert.ToString(_object.Email);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }

        private void SetDropDownLists()
        {
            try
            {
                var query = from Director in Connection.db.Directors select new { ID = Director.ID, FullName = Director.LastName + " " + Director.FirstName + " " + Director.MiddleName };
                comboBox6.DataSource = Connection.db.Regions.ToList();
                comboBox6.DisplayMember = "Name";
                comboBox6.ValueMember = "ID";
                comboBox6.SelectedValue = _object.ID_Region;
                comboBox7.DataSource = Connection.db.Types.ToList();
                comboBox7.DisplayMember = "Name";
                comboBox7.ValueMember = "ID";
                comboBox7.SelectedValue = _object.ID_Type;
                comboBox8.DataSource = query.ToList();
                comboBox8.DisplayMember = "FullName";
                comboBox8.ValueMember = "ID";
                comboBox8.SelectedValue = _object.ID_Director;
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
                label_validation2.Visible = false;
                label_validation3.Visible = false;
                label_validation32.Visible = false;
                label_validation4.Visible = false;
                label_validation8.Visible = false;
                label_validation102.Visible = false;
                foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                    textBox.Text = textBox.Text.Trim();
                if (Validation() == true)
                {
                    string phone;
                    if (maskedTextBox9.Text.Replace("+7", "7").Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") == "7")
                        phone = "";
                    else
                        phone = maskedTextBox9.Text.Replace("+7", "7").Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                    _object.Name = Convert.ToString(textBox1.Text);
                    _object.ShortName = Convert.ToString(textBox2.Text);
                    _object.INN = Convert.ToString(maskedTextBox3.Text);
                    _object.Address = Convert.ToString(textBox4.Text);
                    _object.Website = Convert.ToString(textBox5.Text);
                    _object.ID_Region = Convert.ToInt32(comboBox6.SelectedValue);
                    _object.ID_Type = Convert.ToInt32(comboBox7.SelectedValue);
                    _object.ID_Director = Convert.ToInt32(comboBox8.SelectedValue);
                    _object.Phone = Convert.ToString(phone);
                    _object.Email = Convert.ToString(textBox10.Text);
                    if (IsNotExist(_object))
                    {
                        if (MessageBox.Show("Обновить запись в базе данных?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Connection.db.SaveChanges();
                            MessageBox.Show("запись обновлена");
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                        this.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }

        private bool Validation()
        {
            try
            {
                bool result = true;
                if (textBox2.Text.Length == 0)
                {
                    label_validation2.Visible = true;
                    result = false;
                }
                if (maskedTextBox3.Text.Length == 0)
                {
                    label_validation3.Visible = true;
                    result = false;
                }
                else if (maskedTextBox3.Text.Length < 10 || maskedTextBox3.Text.Length == 11)
                {
                    label_validation32.Visible = true;
                    result = false;
                }
                if (textBox4.Text.Length == 0)
                {
                    label_validation4.Visible = true;
                    result = false;
                }
                if (Convert.ToInt32(comboBox8.SelectedValue) == 0)
                {
                    label_validation8.Visible = true;
                    result = false;
                }
                if (PhoneWithoutMask().Length != 1 && PhoneWithoutMask().Length != 11)
                {
                    label_validation92.Visible = true;
                    result = false;
                }
                if (!Regex.IsMatch(textBox10.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && textBox10.Text != "" || textBox10.Text.Contains("@gmail.ru") || textBox10.Text.Contains("@mail.com"))
                {
                    label_validation102.Visible = true;
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

        private string PhoneWithoutMask()
        {
            return maskedTextBox9.Text.Replace("+7", "7").Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
        }

        private bool IsNotExist(Organizations _object)
        {
            
            try
            {
                bool result = !Connection.db.Organizations.Any(a => a.Name == _object.Name
                && a.ShortName == _object.ShortName
                && a.INN == _object.INN
                && a.Address == _object.Address
                && a.Website == _object.Website
                && a.ID_Region == _object.ID_Region
                && a.ID_Type == _object.ID_Type
                && a.ID_Director == _object.ID_Director
                && a.Phone == _object.Phone
                && a.Email == _object.Email);
                return result;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
                return false;
            }
        }

        private void comboBox8_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                var query = from Director in Connection.db.Directors select new { ID = Director.ID, FullName = Director.LastName + " " + Director.FirstName + " " + Director.MiddleName };
                query = query.Where(a => a.FullName.Contains(comboBox8.Text));
                var list = query.ToList();
                //if (comboBox8.Text == "")
                //    comboBox8.Text = "выберите директора";
                list.Insert(0, new { ID = 0, FullName = comboBox8.Text });
                comboBox8.DataSource = list;
                comboBox8.DisplayMember = "FullName";
                comboBox8.ValueMember = "ID";
                comboBox8.DroppedDown = true;
                comboBox8.SelectionStart = comboBox8.Text.Length;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }

        private void button_Directors_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Directors_Create().ShowDialog() == DialogResult.OK)
                {
                    SetDropDownLists();
                    comboBox8.SelectedIndex = comboBox8.Items.Count - 1;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }

        private void button_Directors_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox8.SelectedIndex != 0)
                {
                    int temp_id = Convert.ToInt32(comboBox8.SelectedValue);
                    if (new Directors_Update(Connection.db.Directors.Where(a => a.ID == temp_id).FirstOrDefault()).ShowDialog() == DialogResult.OK)
                    {
                        SetDropDownLists();
                        comboBox8.SelectedValue = _object.ID_Director;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к администратору");
            }
        }
    }
}
