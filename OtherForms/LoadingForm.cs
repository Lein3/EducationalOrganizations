using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar.Value >= 100)
            {
                timer.Stop();
                new Organizations_Read().Show();
                this.Close();

            }
            else
            {
                guna2CircleProgressBar.Value += 4;
                label_val.Text = (Convert.ToInt32(label_val.Text) + 4).ToString();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
