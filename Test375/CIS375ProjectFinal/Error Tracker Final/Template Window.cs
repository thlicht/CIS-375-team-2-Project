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
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Word = Microsoft.Office.Interop.Word;

namespace Error_Tracker_Final
{
    public partial class TemplateWindow : Form
    {
        Document errorForm = new Document();
        Database tmp = new Database();
        int fromDatabaseIndex = -1;
        string filePath = "";

        public TemplateWindow(Database x, int DocumentIndex)
        {
            
            InitializeComponent();
            errorForm = x.documents[DocumentIndex];
            tmp = x;
            AffectedComponentsTextbox.Text = errorForm.affectedComponents;
            DescriptionTextbox.Text = errorForm.description;
            StepsToReproduceTextbox.Text = errorForm.stepsToReproduce;
            ReporterTextbox.Text = errorForm.reporter;
            NameTextbox.Text = errorForm.name;
            StatusComboBox.Text = errorForm.status;
            IDTextbox.Text = errorForm.idNumber;
            ReportDateBox.Value = Convert.ToDateTime(errorForm.reportDate);
            ResolveDateBox.Value = Convert.ToDateTime(errorForm.resolveDate);
            fromDatabaseIndex = DocumentIndex;
        }

        public TemplateWindow()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control |Keys.S))
            {
                SaveButton.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.R))
            {
                CreateButton.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.O))
            {
                OpenButton.PerformClick();
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                DatabaseButton.PerformClick();
            }

            if (keyData == (Keys.Control | Keys.H))
            {
                HelpButton.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            NameTextbox.Text = ReporterTextbox.Text = IDTextbox.Text = StatusComboBox.Text = AffectedComponentsTextbox.Text
                             = StepsToReproduceTextbox.Text = DescriptionTextbox.Text = "";
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            if(fromDatabaseIndex != -1)
            {
                if (Application.OpenForms.OfType<DatabaseWindow>().Any())
                {
                    Application.OpenForms["DatabaseWindow"].Refresh();
                    Application.OpenForms["DatabaseWindow"].Show();
                      
                }

                else
                {
                    DatabaseWindow form = new DatabaseWindow(tmp);
                    form.Show();
                }
            }
            else if (Application.OpenForms.OfType<DatabaseWindow>().Any())
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

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TemplateHelp>().Any())
            {
                Application.OpenForms["TemplateHelp"].Show();
            }
            else
            {
                TemplateHelp form = new TemplateHelp();
                form.Show();
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

            string fileLine;
            string extension;
            string[] fileFields;

            bool isDescription = false;
            bool isSteps = false;
            bool isComponents = false;
            bool isFirstLine = true;
            bool isSecondLine = false;

            

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                extension = Path.GetExtension(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;

                if (extension == ".txt")
                {
                    using (StreamReader read = File.OpenText(openFileDialog1.FileName))
                    {
                        while ((fileLine = read.ReadLine()) != null)
                        {
                            if (isComponents)
                            {
                                AffectedComponentsTextbox.Text = fileLine;
                                isComponents = false;
                            }

                            if (isSteps)
                            {
                                StepsToReproduceTextbox.Text = fileLine;
                                isSteps = false;
                                isComponents = true;
                            }

                            if (isDescription)
                            {
                                DescriptionTextbox.Text = fileLine;
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
                                ReporterTextbox.Text = fileFields[2];
                                isSecondLine = true;
                            }
                        }
                    }
                }

                else if (extension == ".docx" || extension == ".doc")
                {
                    Word.Application wordFile = new Word.Application();
                    object File = filePath;
                    object nullobj = System.Reflection.Missing.Value;
                    object unit = Word.WdUnits.wdLine;

                    int i = 0;
                    bool k = false;
                    object noShow = k;
                    Word.Document wordDoc = wordFile.Documents.Open(ref File, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref noShow, ref nullobj, ref nullobj, ref nullobj, ref nullobj);
                    

                    while (i < wordDoc.Paragraphs.Count)
                    {
                        fileLine = wordDoc.Paragraphs[i+1].Range.Text.Trim();

                        if (isComponents && fileLine != "Affected Components")
                        {
                            AffectedComponentsTextbox.Text = fileLine;
                            isComponents = false;
                        }

                        if (isSteps && fileLine != "Steps to Reproduce")
                        {
                            StepsToReproduceTextbox.Text = fileLine;
                            isSteps = false;
                            isComponents = true;
                        }

                        if (isDescription && fileLine != "Description")
                        {
                            DescriptionTextbox.Text = fileLine;
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
                            ReporterTextbox.Text = fileFields[2];
                            isSecondLine = true;
                        }
                        i++;
                    }
                    wordFile.Quit();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            string extension = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                extension = Path.GetExtension(filePath);
            }

            errorForm.reportDate = ReportDateBox.Value.ToShortDateString();
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

            if ( extension == ".txt")
            {
          
                    using (StreamWriter lineWrite = File.CreateText(filePath))
                    {
                        lineWrite.WriteLine(errorForm.name + "   " + errorForm.idNumber + "   " + errorForm.reporter);
                        lineWrite.WriteLine(errorForm.reportDate + "   " + errorForm.resolveDate + "   " + errorForm.status);
                        lineWrite.WriteLine(errorForm.description);
                        lineWrite.WriteLine(errorForm.stepsToReproduce);
                        lineWrite.WriteLine(errorForm.affectedComponents);
                        lineWrite.Close();
                    }
            }

            else if (extension == ".doc" || extension == ".docx")
            {
                Word.Paragraph fileParagraph;
                object File1;
                object format = Word.WdSaveFormat.wdFormatDocument;
                object nullobj = System.Reflection.Missing.Value;
                Word.Application wordFile = new Word.Application();
                Word.Document wordDoc = wordFile.Documents.Add(ref nullobj, ref nullobj, ref nullobj, ref nullobj);
                fileParagraph = wordDoc.Content.Paragraphs.Add(ref nullobj);

                fileParagraph.Range.Text = errorForm.name + "   " + errorForm.idNumber + "   " + errorForm.reporter;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = errorForm.reportDate + "   " + errorForm.resolveDate + "   " + errorForm.status;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = "Description";
                fileParagraph.Range.Bold = 1;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = errorForm.description;
                fileParagraph.Range.Bold = 0;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = "Steps to Reproduce";
                fileParagraph.Range.Bold = 1;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = errorForm.stepsToReproduce;
                fileParagraph.Range.Bold = 0;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = "Affected Components";
                fileParagraph.Range.Bold = 1;
                fileParagraph.Range.InsertParagraphAfter();

                fileParagraph.Range.Text = errorForm.affectedComponents;
                fileParagraph.Range.Bold = 0;
                fileParagraph.Range.InsertParagraphAfter();

                filePath = saveFileDialog1.FileName;

                File1 = filePath;
                wordDoc.SaveAs2(ref File1);
                wordDoc.Close();
            }
            if (fromDatabaseIndex != -1)
            {
                tmp.documents[fromDatabaseIndex] = errorForm;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorForm.status = StatusComboBox.Text;
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
            NameCharactersRemaining.Text = (NameTextbox.MaxLength - errorForm.name.Length).ToString();
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}