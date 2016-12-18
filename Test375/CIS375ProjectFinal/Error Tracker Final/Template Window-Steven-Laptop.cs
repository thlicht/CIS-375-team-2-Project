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
            NameTextbox.Text = ReporterTextbox.Text = IDTextbox.Text = DateTextbox.Text = ReleaseDateTextbox.Text = ResolveDateTextbox.Text
                             = StatusComboBox.Text = AffectedComponentsTextbox.Text = StepsToReproduceTextbox.Text = DescriptionTextbox.Text = "";

            FileNameLabel.Text = "File Path Will be Displayed Here";
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseWindow form = new DatabaseWindow();
            form.Show();
            this.Hide();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = File.OpenText(openFileDialog1.FileName);
                string fileLines;
                string[] lines = {""};
                bool isDescription;
                bool isSteps;
                bool isAffected;

                while ((fileLines = read.ReadLine()) != null)
                {
                    if (fileLines == "Description")
                    {
                        isDescription = true;
                        while (isDescription)
                        {
                            if (fileLines == "Steps To Reproduce")
                            {
                                isDescription = false;
                                isSteps = true;
                            }
                            else
                            {
                                errorForm.description += fileLines;
                            }
                        }
                        
                    }
                    
                }

                fileLines = read.ReadToEnd();
                int x = 2;
                /*
                while ((fileLines = read.ReadLine()) != null)
                {
                    if (fileLines.Contains("Description"))
                    {
                        int x = 2;
                    }
                    lines = Regex.Split(fileLines, "   ");
                }
                */

                foreach(string line in lines)
                {

                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int n;

            if (string.IsNullOrEmpty(errorForm.name) || string.IsNullOrEmpty(errorForm.idNumber) || string.IsNullOrEmpty(errorForm.reportDate) ||
                string.IsNullOrEmpty(errorForm.releaseDate) || string.IsNullOrEmpty(errorForm.status) || string.IsNullOrEmpty(errorForm.affectedComponents) ||
                string.IsNullOrEmpty(errorForm.stepsToReproduce) || string.IsNullOrEmpty(errorForm.description))
            {
                RequiredFieldErrorWindow form = new RequiredFieldErrorWindow();
                form.Show();
                return;
            }

            if (((!int.TryParse(errorForm.reportDate, out n)) || (errorForm.reportDate.Length != 6))
                || ((!int.TryParse(errorForm.releaseDate, out n)) || (errorForm.releaseDate.Length != 6))
                || ((!string.IsNullOrEmpty(errorForm.resolveDate)) && ((!int.TryParse(errorForm.resolveDate, out n)) || (errorForm.resolveDate.Length != 6))))
            {
                DateFormatErrorWindow form = new DateFormatErrorWindow();
                form.Show();
                return;
            }

            if (string.IsNullOrEmpty(ReporterTextbox.Text))
            {
                errorForm.reporter = "None";
            }

            if (string.IsNullOrEmpty(ResolveDateTextbox.Text))
            {
                errorForm.resolveDate = "TBD";
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
                        if (errorForm.description.Length < DescriptionTextbox.MaxLength)
                        {
                            lineWrite.WriteLine(errorForm.description);

                            for (int i = 0; i < DescriptionTextbox.MaxLength - errorForm.description.Length; i++)
                            {
                                lineWrite.Write(" ");
                            }
                        }
                        else
                        {
                            lineWrite.WriteLine(errorForm.description);
                        }
                        lineWrite.WriteLine(errorForm.stepsToReproduce);
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
                ResolveDateTextbox.ReadOnly = true;
            else
                ResolveDateTextbox.ReadOnly = false;
        }

        private void AffectedComponentsTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.affectedComponents = AffectedComponentsTextbox.Text;
            ACCharactersRemaining.Text = (AffectedComponentsTextbox.MaxLength - errorForm.affectedComponents.Length).ToString();
        }

        private void DateTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.reportDate = DateTextbox.Text;
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

        private void ReleaseDateTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.releaseDate = ReleaseDateTextbox.Text;
        }

        private void ReporterTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.reporter = ReporterTextbox.Text;
        }

        private void ResolveDateTextbox_TextChanged(object sender, EventArgs e)
        {
            errorForm.resolveDate = ResolveDateTextbox.Text;
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
