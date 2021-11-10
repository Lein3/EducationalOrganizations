using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class Organizations_Read : Form
    {
        int ID;
        int currentPage = 0;
        List<Page> pages;
        Form activeForm = null;
        public class Page
        {
            public int PageNumber;
            public int countRows;

            public Page(int temp_currentPageNumber, int temp_countRows)
            {
                PageNumber = temp_currentPageNumber;
                countRows = temp_countRows;
            }
            
            public List<MyOrganization> DisplayPage()
            {
                return Queryies.query.ToList().GetRange(PageNumber * Convert.ToInt32(AppSettings.PageCount), countRows);              
            }
        }

        public Organizations_Read()
        {
            InitializeComponent();
            AppSettings.PageCount = Convert.ToInt32(guna2NumericUpDown_Page.Value);
            guna2NumericUpDown_Page.Maximum = Queryies.query.Count();
            List<string> list = new List<string>() { "районы"};
            guna2ComboBox_Region.DataSource = list;
        }

        private void Organizations_Read_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Organizations_Read_Load(object sender, EventArgs e)
        {
            if (guna2CheckBox_ResetF.Checked == true)
            {
                SetFilters();
                SetPages(Queryies.query.ToList().Count());
                guna2ComboBox_Page.SelectedIndex = currentPage;
                guna2DataGridView.DataSource = pages[currentPage].DisplayPage();
                guna2DataGridView.ClearSelection();
                label_Topic.Text = "Всего записей: " + Queryies.query.ToList().Count().ToString();
            }
            else
                UniversalFilter(sender, e);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2Panel_Application.Controls.Clear();
            guna2Panel_Application.Controls.Add(childForm);
            guna2Panel_Application.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //выбор записи

        private void guna2DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells[0].Value);
        }

        private void guna2DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2Button_Update_Click(sender, e);
        }

        //круды

        private void guna2Button_Create_Click(object sender, EventArgs e)
        {
            if (new Organizations_Create().ShowDialog() == DialogResult.OK)
            {
                AddPageIfMax(Queryies.query.ToList().Count, true);
                new LoadingForm().ShowDialog();
                Organizations_Read_Load(sender, e);
            }
        }

        private void guna2Button_Update_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView.SelectedRows.Count < 1) MessageBox.Show("Запись не выбрана");
            else if (new Organizations_Update(Connection.db.Organizations.Where(a => a.ID == ID).FirstOrDefault()).ShowDialog() == DialogResult.OK)
                Organizations_Read_Load(sender, e);
        }

        private void guna2Button_Delete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView.SelectedRows.Count < 1) MessageBox.Show("Запись не выбрана");
            else if (MessageBox.Show("Удалить выбранную запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Connection.db.Organizations.Remove(Connection.db.Organizations.Where(a => a.ID == ID).FirstOrDefault());
                Connection.db.SaveChanges();
                if (guna2DataGridView.Rows.Count == 1 && currentPage != 0)
                {
                    currentPage -= 1;
                    AddPageIfMax(Queryies.query.ToList().Count, false);
                    Organizations_Read_Load(sender, e);
                }
                else
                {
                    AddPageIfMax(Queryies.query.ToList().Count, false);
                    Organizations_Read_Load(sender, e);
                }
            }
        }

        //остальное

        private void guna2Button_Organizations_Click(object sender, EventArgs e)
        {
            guna2Panel_Application.Controls.Clear();
            guna2Panel_Application.Controls.Add(checkedListBox_Region);
            guna2Panel_Application.Controls.Add(guna2DataGridView);
            guna2DataGridView.MultiSelect = false;
            guna2Button_Excel.Enabled = true;
            guna2Panel_Top.Visible = true;
            guna2Panel_Bottom.Visible = true;
            guna2Button_Mailing_Auto.Enabled = true;
            guna2Button_Mailing_Manual.Enabled = true;
            guna2Button_Mailing_Manual_Next.Visible = false;
            guna2Button_Settings_ButtonPages.Enabled = true;
            guna2Button_Settings_ButtonPages.FillColor = System.Drawing.Color.RoyalBlue;
            guna2Button_Settings_Reset.Enabled = true;
            guna2Button_Create.Enabled = true;
            guna2Button_Update.Enabled = true;
            guna2Button_Delete.Enabled = true;
            Organizations_Read_Load(sender, e);
        }

        private void guna2Button_Mailing_Click(object sender, EventArgs e)
        {
            if (guna2Panel_Button_Mailing.Visible == true)
                guna2Panel_Button_Mailing.Visible = false;
            else
                guna2Panel_Button_Mailing.Visible = true;
        }

        private void guna2Button_Mailing_Auto_Click(object sender, EventArgs e)
        {
            List<string> emails = new List<string>();
            for (int i = 0; i < guna2DataGridView.RowCount; i++)
                emails.Add(guna2DataGridView.Rows[i].Cells[10].Value.ToString());
            openChildForm(new MailingForm(emails));
            guna2Button_Excel.Enabled = false;
            guna2Panel_Top.Visible = false;
            guna2Panel_Bottom.Visible = false;
            guna2Button_Mailing_Auto.Enabled = false;
            guna2Button_Settings_ButtonPages.FillColor = System.Drawing.Color.Gray;
            guna2Button_Settings_ButtonPages.Enabled = false;
            guna2Button_Settings_Reset.Enabled = false;
            guna2Button_Mailing_Manual.Enabled = false;
            guna2Button_Mailing_Manual_Next.Visible = false;
        }

        private void guna2Button_Mailing_Manual_Click(object sender, EventArgs e)
        {
            guna2DataGridView.MultiSelect = true;
            guna2Button_Create.Enabled = false;
            guna2Button_Update.Enabled = false;
            guna2Button_Delete.Enabled = false;
            guna2Button_Mailing_Manual_Next.Visible = true;
        }

        private void guna2Button_Mailing_Manual_Next_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView.SelectedRows.Count != 0)
            {
                List<string> emails = new List<string>();
                var selectedRows = guna2DataGridView.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToList();
                foreach (var row in selectedRows)
                    emails.Add(row.Cells[10].Value.ToString());
                openChildForm(new MailingForm(emails));
                guna2Button_Excel.Enabled = false;
                guna2Panel_Top.Visible = false;
                guna2Panel_Bottom.Visible = false;
                guna2Button_Mailing_Auto.Enabled = false;
                guna2Button_Settings_ButtonPages.FillColor = System.Drawing.Color.Gray;
                guna2Button_Settings_ButtonPages.Enabled = false;
                guna2Button_Settings_Reset.Enabled = false;
                guna2Button_Mailing_Manual.Enabled = false;
                guna2Button_Mailing_Manual_Next.Visible = false;
            }
            else
                MessageBox.Show("Записи не выбраны");
        }

        private void guna2Button_Settings_Click(object sender, EventArgs e)
        {
            if (guna2Panel_Button_Settings.Visible == true)
                guna2Panel_Button_Settings.Visible = false;
            else
                guna2Panel_Button_Settings.Visible = true;
        }

        private void guna2Button_Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://profartnso.ru/");
        }

        private void button_CopyEmail_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView.SelectedRows.Count < 1) MessageBox.Show("Запись не выбрана");
            else
                Clipboard.SetText(guna2DataGridView.CurrentRow.Cells[10].Value.ToString());
        }

        private void guna2Button_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)application.ActiveSheet;
            for (int i = 0; i < guna2DataGridView.RowCount; i++)
            {
                worksheet.Cells[i + 1, 1] = guna2DataGridView.Rows[i].Cells[2].Value.ToString();
                worksheet.Cells[i + 1, 2] = guna2DataGridView.Rows[i].Cells[10].Value.ToString();
            }
            application.Visible = true;
        }

        //фильтры

        private void SetFilters()
        {
            var listRegions = Connection.db.Regions.ToList();
            checkedListBox_Region.DataSource = listRegions;
            checkedListBox_Region.DisplayMember = "Name";
            checkedListBox_Region.ValueMember = "ID";
            var listTypes = Connection.db.Types.ToList();
            listTypes.Insert(0, new Types { ID = 0, Name = "Все типы" });
            guna2ComboBox_Type.DataSource = listTypes;
            guna2ComboBox_Type.DisplayMember = "Name";
            guna2ComboBox_Type.ValueMember = "ID";
            guna2TextBox_Search.Text = "";
        }

        private void UniversalFilter(object sender, EventArgs e)
        {
            List<string> regionString = new List<string>();
            foreach (var item in checkedListBox_Region.CheckedItems)
                regionString.Add(checkedListBox_Region.GetItemText(item));
            string typeString = guna2ComboBox_Type.GetItemText(guna2ComboBox_Type.SelectedItem);
            string globalFilter = guna2TextBox_Search.Text;
            var result_query = Queryies.query;
            if (regionString.Count != 0)
            {
                result_query = Queryies.nullQuery;
                foreach (var region in regionString)
                {
                    var temp_query = Queryies.query.Where(a => a.Район == region);
                    result_query = result_query.Concat(temp_query);
                }
            }
            if (Convert.ToInt32(guna2ComboBox_Type.SelectedValue) != 0)
                result_query = result_query.Where(a => a.Тип == typeString);
            if (globalFilter != "")
                result_query = result_query.Where(a => a.Полное_наименование.Contains(globalFilter)
                || a.Короткое_наименование.Contains(globalFilter)
                || a.ИНН.Contains(globalFilter)
                || a.Адрес.Contains(globalFilter)
                || a.Сайт.Contains(globalFilter)
                || a.Район.Contains(globalFilter)
                || a.Тип.Contains(globalFilter)
                || a.Директор.Contains(globalFilter)
                || a.Телефон.Contains(globalFilter)
                || a.Email.Contains(globalFilter)
                );
            guna2DataGridView.DataSource = result_query.ToList();
            guna2DataGridView.ClearSelection();
            label_Topic.Text = "Всего записей: " + result_query.ToList().Count().ToString();
        }

        private void checkedListBox_Region_MouseLeave(object sender, EventArgs e)
        {
            checkedListBox_Region.Visible = false;
            guna2ComboBox_Region.Enabled = true;
        }

        private void guna2ComboBox_Region_Click(object sender, EventArgs e)
        {
            checkedListBox_Region.Visible = true;
            guna2ComboBox_Region.Enabled = false;
            guna2ComboBox_Region.DroppedDown = false;
        }

        private void checkedListBox_Region_VisibleChanged(object sender, EventArgs e)
        {
            if (checkedListBox_Region.Visible == false && checkedListBox_Region.CheckedItems.Count != 0)
            {
                var listText = new List<string>();
                listText.Add("выбранные районы");
                guna2ComboBox_Region.DataSource = listText;
                UniversalFilter(sender, e);
            }              
        }

        private void guna2CheckBox_ResetF_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox_ResetF.Checked == true)
            {
                guna2Button_Next.Enabled = true;
                guna2Button_Previous.Enabled = true;
                guna2ComboBox_Page.Enabled = true;
                guna2Button_Settings_ButtonPages.Enabled = true;
                guna2Button_Settings_ButtonPages.FillColor = System.Drawing.Color.RoyalBlue;
                guna2Button_Settings_Reset.Enabled = true;
            }
            else
            {
                guna2Button_Next.Enabled = false;
                guna2Button_Previous.Enabled = false;
                guna2ComboBox_Page.Enabled = false;
                guna2Button_Settings_ButtonPages.FillColor = System.Drawing.Color.Gray;
                guna2Button_Settings_ButtonPages.Enabled = false;
                guna2Button_Settings_Reset.Enabled = false;
            }
        }

        private void guna2Panel_Button_Settings_Panel_Reset_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            Organizations_Read_Load(sender, e);
        }

        //страницы

        private void SetPages(int databaseSize)
        {
            pages = new List<Page>();
            for (int i = 0; i < databaseSize / AppSettings.PageCount; i++)
                pages.Add(new Page(i, AppSettings.PageCount));
            if (databaseSize % AppSettings.PageCount != 0)
                pages.Add(new Page(pages.Count, databaseSize % AppSettings.PageCount));
            guna2ComboBox_Page.Items.Clear();
            foreach (var item in pages)
                guna2ComboBox_Page.Items.Add(item.PageNumber + 1);
        }

        private void guna2Button_Previous_Click(object sender, EventArgs e)
        {
            if (currentPage == 0)
                return;
            else
            {
                currentPage--;
                Organizations_Read_Load(sender, e);
            }
        }

        private void guna2Button_Next_Click(object sender, EventArgs e)
        {
            if (currentPage == pages.Count - 1)
                return;
            else
            {
                currentPage++;
                Organizations_Read_Load(sender, e);
            }
        }

        private void guna2NumericUpDown_Page_ValueChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView.Rows.Count > 0)
            {
                currentPage = 0;
                AppSettings.PageCount = Convert.ToInt32(guna2NumericUpDown_Page.Value);
                Organizations_Read_Load(sender, e);
            }
            else
                return;
        }

        private void guna2ComboBox_Page_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentPage = Convert.ToInt32(guna2ComboBox_Page.SelectedIndex);
            Organizations_Read_Load(sender, e);
        }

        private void AddPageIfMax(int databaseSize, bool Add_Remove)
        {
            if (guna2NumericUpDown_Page.Value == guna2NumericUpDown_Page.Maximum)
            {
                if (Add_Remove == true)
                {
                    guna2NumericUpDown_Page.Maximum += 1;
                    guna2NumericUpDown_Page.Value += 1;
                }
                else
                    guna2NumericUpDown_Page.Maximum -= 1;
            }
            else
                guna2NumericUpDown_Page.Maximum = databaseSize;
        }
    }
}
