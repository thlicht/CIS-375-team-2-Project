using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Tracker_Final
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TemplateWindow form = new TemplateWindow();
            form.Show();
            this.Hide();
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseWindow form = new DatabaseWindow();
            form.Show();
            this.Hide();
        }
    }
}
