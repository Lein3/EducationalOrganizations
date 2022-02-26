using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class StartForm : Form
    {
        private int changeIP = 0;
        public StartForm()
        {
            InitializeComponent();
        }

        private void guna2Button_Login_Click(object sender, EventArgs e)
        {
            new LoadingForm().Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            changeIP++;
            if (changeIP > 3)
            {
                guna2Button_ChangeIP.Visible = true;
                guna2TextBox_ChangeIP.Visible = true;
                guna2PictureBox1.Click -= guna2PictureBox1_Click;
            }
        }

        private void guna2Button_ChangeIP_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            var newIP = guna2TextBox_ChangeIP.Text;
            connectionStringsSection.ConnectionStrings["EducationalOrganizationsEntities"].ConnectionString = $"metadata=res://*/ModelEducationalOrganizations.csdl|res://*/ModelEducationalOrganizations.ssdl|res://*/ModelEducationalOrganizations.msl;provider=System.Data.SqlClient;provider connection string='data source=\"{newIP}\";;initial catalog=EducationalOrganizations;user id=app;password=app;MultipleActiveResultSets=True;App=EntityFramework'";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            MessageBox.Show("IP адрес изменен");
        }
    }
}
