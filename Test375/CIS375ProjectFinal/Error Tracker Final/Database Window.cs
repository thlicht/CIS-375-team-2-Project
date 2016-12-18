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
using System.Text.RegularExpressions;

using Word = Microsoft.Office.Interop.Word;

namespace Error_Tracker_Final
{
    public partial class DatabaseWindow : Form
    {
        Database metricsDatabase = new Database();

        string[] files = null;
        int DocToChangeIndex = -1;

        public DatabaseWindow()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        public DatabaseWindow(Database x)
        {
            metricsDatabase = x;
            for (int i =0; i < metricsDatabase.documents.Length;i++)
            {
                DocumentBox.Items.Add(metricsDatabase.documents[i].name + "\t\t" + metricsDatabase.documents[i].reportDate + "\t" +
                        metricsDatabase.documents[i].resolveDate + "\t" + metricsDatabase.documents[i].status);
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                GenerateMetricsButton.PerformClick();
                return true;
            }

            if(keyData == (Keys.Control | Keys.O))
            {
                OpenDatabaseButton.PerformClick();
                return true;
            }

            if(keyData == (Keys.Control | Keys.T))
            {
                TemplateButton.PerformClick();
            }

            if(keyData == (Keys.Control | Keys.H))
            {
                HelpButton.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void GenerateMetricsButton_Click(object sender, EventArgs e)
        {
            Metrics metricsCalculator = new Metrics();

            int intOut;

            float defectRemovalEfficiency;
            float correctness;       
            float maintainability;

            metricsDatabase.releaseDateManip = ReleaseDateBox.Value.ToShortDateString();

            if ((files == null) || (files.Length == 0))
            {
                NoDatabaseOpenError form = new NoDatabaseOpenError();
                form.ShowDialog();
                return;
            }

            if ((DRECheckbox.Checked == false) && (CorrectnessCheckbox.Checked == false) && (MaintainabilityCheckbox.Checked == false))
            {
                MetricsSelectionErrorWindow form = new MetricsSelectionErrorWindow();
                form.ShowDialog();
                return;
            }

            if ((CorrectnessCheckbox.Checked == true) && (!int.TryParse(KLOCTextbox.Text, out intOut) || (intOut < 0)))
            {
                KLOCRequiredError form = new KLOCRequiredError();
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
                maintainability = metricsCalculator.meanTimetoFix(metricsDatabase);
            }
            else
            {
                maintainability = -1;
            }

            GenerateMetricsDisplay.Text = "Defect Removal Efficiency: ";
            if (defectRemovalEfficiency == -1)
            {
                GenerateMetricsDisplay.Text += "Not Selected" + Environment.NewLine + "Correctness: ";
            }
            else
            {
                GenerateMetricsDisplay.Text += defectRemovalEfficiency.ToString("0.##") + Environment.NewLine + "Correctness: ";
            }

            if (correctness == -1)
            {
                GenerateMetricsDisplay.Text += "Not Selected" + Environment.NewLine + "Mean Time to Change: ";
            }
            else
            {
                GenerateMetricsDisplay.Text += correctness.ToString("0.##") + Environment.NewLine + "Mean Time to Change: ";
            }

            if (maintainability == -1)
            {
                GenerateMetricsDisplay.Text += "Not Selected" + Environment.NewLine + "Integrity: ";
            }
            else
            {
                GenerateMetricsDisplay.Text += maintainability.ToString("0.##") + Environment.NewLine + "Integrity: ";
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DatabaseHelp>().Any())
            {
                Application.OpenForms["DatabaseHelp"].Show();
            }
            else
            {
                DatabaseHelp form = new DatabaseHelp();
                form.Show();
            }
        }

        private void OpenDatabaseButton_Click(object sender, EventArgs e)
        {
            Document newDocument = new Document();

            string fileLine;
            string[] fileFields;

            bool isDescription = false;
            bool isSteps = false;
            bool isComponents = false;
            bool isFirstLine = true;
            bool isSecondLine = false;

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog1.FileNames;

                Array.Resize(ref metricsDatabase.documents, files.Length);

                for (int j = 0; j < metricsDatabase.documents.Length; j++)
                {
                    metricsDatabase.documents[j] = new Document();
                }

                DocumentBox.Visible = true;
                DocumentBox.Items.Clear();
                DocumentBox.Items.Add("Name of Error\tReport Date\tResolveDate\tStatus");

                for (int i = 0; i < files.Length; i++)
                {
                    string extension = Path.GetExtension(files[i]);

                    if( extension == ".doc" || extension == ".docx")
                    {
                        Word.Application wordFile = new Word.Application();
                        object File = files[i];
                        object nullobj = System.Reflection.Missing.Value;
                        object unit = Word.WdUnits.wdLine;
                        isFirstLine = true;

                        int c = 0;
                        bool k = false;
                        object noShow = k;
                        Word.Document wordDoc = wordFile.Documents.Open(ref File, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref noShow, ref nullobj, ref nullobj, ref nullobj, ref nullobj);


                        while (c < wordDoc.Paragraphs.Count)
                        {
                            
                            fileLine = wordDoc.Paragraphs[c + 1].Range.Text.Trim();

                            if (isComponents && fileLine != "Affected Components")
                            {
                                metricsDatabase.documents[i].affectedComponents = fileLine;
                                isComponents = false;
                            }

                            if (isSteps && fileLine != "Steps to Reproduce")
                            {
                                metricsDatabase.documents[i].stepsToReproduce = fileLine;
                                isSteps = false;
                                isComponents = true;
                            }

                            if (isDescription && fileLine != "Description")
                            {
                                metricsDatabase.documents[i].description = fileLine;
                                isDescription = false;
                                isSteps = true;
                            }

                            if (isSecondLine)
                            {
                                isSecondLine = false;
                                fileFields = Regex.Split(fileLine, "   ");
                                metricsDatabase.documents[i].reportDate = fileFields[0];
                                metricsDatabase.documents[i].resolveDate = fileFields[1];
                                metricsDatabase.documents[i].status = fileFields[2];
                                isDescription = true;
                            }

                            if (isFirstLine)
                            {
                                isFirstLine = false;
                                fileFields = Regex.Split(fileLine, "   ");
                                metricsDatabase.documents[i].name = fileFields[0];
                                metricsDatabase.documents[i].idNumber = fileFields[1];
                                metricsDatabase.documents[i].reporter = fileFields[2];
                                isSecondLine = true;
                            }
                            c++;
                        }
                        wordFile.Quit();
                        DocumentBox.Items.Add(metricsDatabase.documents[i].name + "\t\t" + metricsDatabase.documents[i].reportDate + "\t" +
                        metricsDatabase.documents[i].resolveDate + "\t" + metricsDatabase.documents[i].status);
                    }
                    else
                    {
                        isFirstLine = true;
                        using (StreamReader read = File.OpenText(openFileDialog1.FileNames[i]))
                        {
                            while ((fileLine = read.ReadLine()) != null)
                            {
                                if (isComponents)
                                {
                                    metricsDatabase.documents[i].affectedComponents = fileLine;
                                    isComponents = false;

                                }

                                if (isSteps)
                                {
                                    metricsDatabase.documents[i].stepsToReproduce = fileLine;
                                    isSteps = false;
                                    isComponents = true;
                                }

                                if (isDescription)
                                {
                                    metricsDatabase.documents[i].description = fileLine;
                                    isDescription = false;
                                    isSteps = true;
                                }

                                if (isSecondLine)
                                {
                                    isSecondLine = false;
                                    fileFields = Regex.Split(fileLine, "   ");
                                    metricsDatabase.documents[i].reportDate = fileFields[0];
                                    metricsDatabase.documents[i].resolveDate = fileFields[1];
                                    metricsDatabase.documents[i].status = fileFields[2];
                                    isDescription = true;
                                }

                                if (isFirstLine)
                                {
                                    isFirstLine = false;
                                    fileFields = Regex.Split(fileLine, "   ");
                                    metricsDatabase.documents[i].name = fileFields[0];
                                    metricsDatabase.documents[i].idNumber = fileFields[1];
                                    metricsDatabase.documents[i].reporter = fileFields[2];
                                    isSecondLine = true;
                                }
                            }
                        }
                        DocumentBox.Items.Add(metricsDatabase.documents[i].name + "\t\t" + metricsDatabase.documents[i].reportDate + "\t" +
                        metricsDatabase.documents[i].resolveDate + "\t" + metricsDatabase.documents[i].status);
                    }
                    
                }
            }
            button1.Enabled = true;
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

        private void KLOCTextbox_TextChanged(object sender, EventArgs e)
        {
            int intOut;

            if (int.TryParse(KLOCTextbox.Text, out intOut))
            {
                metricsDatabase.klocManip = Convert.ToInt32(KLOCTextbox.Text);
            }
        }

        private void DatabaseWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void DocumentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocToChangeIndex = DocumentBox.SelectedIndex;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemplateWindow form = new TemplateWindow(metricsDatabase, DocToChangeIndex - 1);
            form.ShowDialog();


        }
    }
}