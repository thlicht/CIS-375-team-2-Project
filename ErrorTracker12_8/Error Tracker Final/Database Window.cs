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

        float defectRemovalEfficiency;
        float correctness;
        string maintainability;
        float integrity;
        float[] probOfAttack;
        float[] probOfRepel;
        int numberOfThreats;

        public DatabaseWindow()
        {
            InitializeComponent();
        }

        private void GenerateMetricsButton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(KLOCTextbox.Text);
            metricsDatabase.releaseDate = ReleaseDateBox.Value.ToShortDateString();
            metricsDatabase.Kloc = x;

            DatabaseNameLabel.Text = "";
            DatabaseNameLabel.Text += metricsDatabase.Kloc;
            DatabaseNameLabel.Text += " " + metricsDatabase.releaseDate;

            if ((DRECheckbox.Checked == false) && (CorrectnessCheckbox.Checked == false) && (MaintainabilityCheckbox.Checked == false)
                && (IntegrityCheckbox.Checked == false))
            {
                MetricsSelectionErrorWindow form = new MetricsSelectionErrorWindow();
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
                integrity = metricsCalculator.integrity(probOfAttack, probOfRepel, numberOfThreats);
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
            string[] files;

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

        private void ReleaseDateBox_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void KLOCTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
