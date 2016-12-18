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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.T))
            {
                CreateButton.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                DatabaseButton.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.H))
            {
                HelpButton.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<WelcomeScreenHelp>().Any())
            {
                Application.OpenForms["WelcomeScreenHelp"].Show();
            }
            else
            {
                WelcomeScreenHelp form = new WelcomeScreenHelp();
                form.Show();
            }
        }
    }
}
