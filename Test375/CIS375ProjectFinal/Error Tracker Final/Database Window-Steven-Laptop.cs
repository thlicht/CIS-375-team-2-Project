using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Error_Tracker_Final
{
    public partial class DatabaseWindow : Form
    {
        Metrics metricsCalculator;
        Database metricsDatabase = new Database();

        int intOut;

        float floatOut;

        float defectRemovalEfficiency;
        float correctness;
        float integrity;

        string[] files;
        string maintainability;

        public DatabaseWindow()
        {
            InitializeComponent();
        }

        private void GenerateMetricsButton_Click(object sender, EventArgs e)
        {
            metricsDatabase.releaseDate = ReleaseDateBox.Value.ToShortDateString();
            DatabaseNameLabel.Text = metricsDatabase.klocManip + " " + metricsDatabase.releaseDate;

            if ((files == null) || (files.Length == 0))
            {
                NoDatabaseOpenError form = new NoDatabaseOpenError();
                form.ShowDialog();
                return;
            }

            if ((DRECheckbox.Checked == false) && (CorrectnessCheckbox.Checked == false) && (MaintainabilityCheckbox.Checked == false)
                && (IntegrityCheckbox.Checked == false))
            {
                MetricsSelectionErrorWindow form = new MetricsSelectionErrorWindow();
                form.ShowDialog();
                return;
            }

            if ((CorrectnessCheckbox.Checked == true) && !int.TryParse(KLOCTextbox.Text, out intOut))
            {
                KLOCRequiredError form = new KLOCRequiredError();
                form.ShowDialog();
                return;
            }

            if ((IntegrityCheckbox.Checked == true) && (!float.TryParse(AttackTextbox.Text, out floatOut)
                || !float.TryParse(RepelTextbox.Text, out floatOut)))
            {
                AttackOrRepelRequiredError form = new AttackOrRepelRequiredError();
                form.ShowDialog();
                return;
            }

            if (DRECheckbox.Checked == true)
            {
                defectRemovalEfficiency = metricsCalculator.defectRemovalEfficiency(metricsDatabase);
            }
            else
            {
                defectRemovalEfficiency = -1;
            }

            if (CorrectnessCheckbox.Checked == true)
            {
                correctness = metricsCalculator.correctness(metricsDatabase);
            }
            else
            {
                correctness = -1;
            }

            if (MaintainabilityCheckbox.Checked == true)
            {
                maintainability = metricsCalculator.maintainabilty(metricsDatabase);
            }
            else
            {
                maintainability = "";
            }

            if (IntegrityCheckbox.Checked == true)
            {
                integrity = metricsCalculator.integrity(Convert.ToDouble(AttackTextbox.Text),
                    Convert.ToInt32(RepelTextbox.Text));
            }
            else
            {
                integrity = -1;
            }

            GenerateMetricsDisplay.Text = "Defect Removal Efficiency: ";
            if (defectRemovalEfficiency == -1)
            {
                GenerateMetricsDisplay.Text += "Not Selected\nCorrectness: ";
            }
            else
            {
                GenerateMetricsDisplay.Text += defectRemovalEfficiency.ToString() + "\nCorrectness: ";
            }

            if (correctness == -1)
            {
                GenerateMetricsDisplay.Text += "Not Selected\nMaintainability: ";
            }
            else
            {
                GenerateMetricsDisplay.Text += correctness.ToString() + "\nMaintainability: ";
            }

            if (maintainability == "")
            {
                GenerateMetricsDisplay.Text += "Not Selected\nIntegrity: ";
            }
            else
            {
                GenerateMetricsDisplay.Text += maintainability + "\nIntegrity: ";
            }

            if (integrity == -1)
            {
                GenerateMetricsDisplay.Text += "Not Selected";
            }
            else
            {
                GenerateMetricsDisplay.Text += integrity.ToString();
            }
        }

        private void OpenDatabaseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader read = File.OpenText(openFileDialog1.FileName))
                {
                    try
                    {
                        DatabaseNameLabel.Text = "";
                        files = openFileDialog1.FileNames;
                        foreach (string file in files)
                        {
                            DatabaseNameLabel.Text += file + "\n";

                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void TemplateButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TemplateWindow>().Any())
            {
                Application.OpenForms["TemplateWindow"].Show();
            }

            else
            {
                TemplateWindow form = new TemplateWindow();
                form.Show();
            }

            this.Hide();
        }

        private void DatabaseWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void KLOCTextbox_TextChanged(object sender, EventArgs e)
        {
            int intOut;

            if (int.TryParse(KLOCTextbox.Text, out intOut))
            {
                metricsDatabase.klocManip = Convert.ToInt32(KLOCTextbox.Text);
            }
        }

        private void AttackTextbox_TextChanged(object sender, EventArgs e)
        {
            float floutOut;

            
        }
    }
}
