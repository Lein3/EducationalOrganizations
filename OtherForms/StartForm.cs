using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void guna2Button_Login_Click(object sender, EventArgs e)
        {
            new LoadingForm().Show();
            this.Hide();
        }
    }
}
