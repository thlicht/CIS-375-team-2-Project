using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Error_Tracker_Final
{
    public partial class TemplateWindow : Form
    {
        Document errorForm = new Document();
        string filePath = "";

        public TemplateWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            NameTextbox.Text = ReporterTextbox.Text = IDTextbox.Text = StatusComboBox.Text = AffectedComponentsTextbox.Text
                             = StepsToReproduceTextbox.Text = DescriptionTextbox.Text = "";

            ReportDateBox.Value = ReleaseDateBox.Value = ResolveDateBox.Value = DateTime.Now;
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DatabaseWindow>().Any())
            {
                Application.OpenForms["DatabaseWindow"].Show();
            }

            else
            {
                DatabaseWindow form = new DatabaseWindow();
                form.Show();
            }

            this.Hide();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            string fileLine;
            string[] fileFields;
            bool isDescription = false;
            bool isSteps = false;
            bool isComponents = false;
            bool isFirstLine = true;
            bool isSecondLine = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader read = File.OpenText(openFileDialog1.FileName))
                {
                    while ((fileLine = read.ReadLine()) != null)
                    {
                        if (isComponents)
                        {
                            AffectedComponentsTextbox.Text += fileLine;
                            fileLine = read.ReadLine();
                            while(fileLine != null)
                            {
                                AffectedComponentsTextbox.Text += fileLine;
                                fileLine = "";
                                fileLine = read.ReadLine();                                
                            }
                            isComponents = false;
                        }

                        if (isSteps)
                        {
                            StepsToReproduceTextbox.Text += fileLine;
                            fileLine = read.ReadLine();
                            while (fileLine != "Affected Components")
                            {
                                StepsToReproduceTextbox.Text += fileLine;
                                fileLine = "";
                                fileLine = read.ReadLine();
                            }
                            isSteps = false;
                            isComponents = true;
                        }

                        if (isDescription)
                        {
                            DescriptionTextbox.Text += fileLine;
                            fileLine = read.ReadLine();
                            while (fileLine != "Steps To Reproduce")
                            {                                                              
                                DescriptionTextbox.Text += fileLine;
                                fileLine = "";
                                fileLine = read.ReadLine();
                            }
                            isDescription = false;
                            isSteps = true;
                        }

                        if (isSecondLine)
                        {
                            isSecondLine = false;
                            fileFields = Regex.Split(fileLine, "   ");
                            ReportDateBox.Value = Convert.ToDateTime(fileFields[0]);
                            ResolveDateBox.Value = Convert.ToDateTime(fileFields[1]);
                            StatusComboBox.Text = fileFields[2];
                            isDescription = true;
                        }

                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            fileFields = Regex.Split(fileLine, "   ");
                            NameTextbox.Text = fileFields[0];
                            IDTextbox.Text = fileFields[1];
                            ReleaseDateBox.Value = Convert.ToDateTime(fileFields[2]);
                            ReporterTextbox.Text = fileFields[3];
                            isSecondLine = true;
                        }

                        /*
                        if (fileLine == "Description")
                        {
                            isDescription = true;
                            while (isDescription)
                            {
                                if (fileLine == "Steps To Reproduce")
                                {
                                    isDescription = false;
                                    isSteps = true;
                                }
                                else
                                {
                                    DescriptionTextbox.Text += fileLine;
                                }
                            }
                        }
                        */
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int n;

            errorForm.reportDate = ReportDateBox.Value.ToShortDateString();
            errorForm.releaseDate = ReleaseDateBox.Value.ToShortDateString();
            errorForm.resolveDate = ResolveDateBox.Value.ToShortDateString();

            if (string.IsNullOrEmpty(errorForm.name) || string.IsNullOrEmpty(errorForm.idNumber) ||
                string.IsNullOrEmpty(errorForm.status) || string.IsNullOrEmpty(errorForm.affectedComponents) ||
                string.IsNullOrEmpty(errorForm.stepsToReproduce) || string.IsNullOrEmpty(errorForm.description))
            {
                RequiredFieldErrorWindow form = new RequiredFieldErrorWindow();
                form.ShowDialog(this);
                return;
            }

            if (string.IsNullOrEmpty(ReporterTextbox.Text))
            {
                errorForm.reporter = "None";
            }

            if (filePath.Length == 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string newFile = saveFileDialog1.FileName;
                    using (StreamWriter lineWrite = File.CreateText(newFile))
                    {
                        lineWrite.WriteLine(errorForm.name + "   " + errorForm.idNumber + "   " + errorForm.releaseDate + "   " + errorForm.reporter);
                        lineWrite.WriteLine(errorForm.reportDate + "   " + errorForm.resolveDate + "   " + errorForm.status);
                        lineWrite.WriteLine(errorForm.description);
                        lineWrite.WriteLine("Steps To Reproduce");
                        lineWrite.WriteLine(errorForm.stepsToReproduce);
                        lineWrite.WriteLine("Affected Components");
                        lineWrite.WriteLine(errorForm.affectedComponents);
                        lineWrite.Close();
                    }
                }
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorForm.status = StatusComboBox.Text;

            if (StatusComboBox.Text == "Resolved")
                ResolveDateBox.Enabled = true;
            else
                ResolveDateBox.Enabled = false;
        }

        private void AffectedComponentsTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.affectedComponents = AffectedComponentsTextbox.Text;
            ACCharactersRemaining.Text = (AffectedComponentsTextbox.MaxLength - errorForm.affectedComponents.Length).ToString();
        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.description = DescriptionTextbox.Text;
            DCharactersRemaining.Text = (DescriptionTextbox.MaxLength - errorForm.description.Length).ToString();
        }

        private void IDTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.idNumber = IDTextbox.Text;
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.name = NameTextbox.Text;
        }

        private void ReporterTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.reporter = ReporterTextbox.Text;
        }

        private void StepsToReproduceTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.stepsToReproduce = StepsToReproduceTextbox.Text;
            StRCharactersRemaining.Text = (StepsToReproduceTextbox.MaxLength - errorForm.stepsToReproduce.Length).ToString();
        }

        private void TemplateWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
        }
    }
}
