namespace Error_Tracker_Final
{
    partial class DatabaseWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TemplateButton = new System.Windows.Forms.Button();
            this.OpenDatabaseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GenerateMetricsDisplay = new System.Windows.Forms.TextBox();
            this.GenerateMetricsButton = new System.Windows.Forms.Button();
            this.DRECheckbox = new System.Windows.Forms.CheckBox();
            this.CorrectnessCheckbox = new System.Windows.Forms.CheckBox();
            this.MaintainabilityCheckbox = new System.Windows.Forms.CheckBox();
            this.MetricsLabel = new System.Windows.Forms.Label();
            this.KLOCTextbox = new System.Windows.Forms.TextBox();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.KLOCLabel = new System.Windows.Forms.Label();
            this.ReleaseDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DocumentBox = new System.Windows.Forms.ListBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TemplateButton
            // 
            this.TemplateButton.Location = new System.Drawing.Point(12, 259);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(130, 23);
            this.TemplateButton.TabIndex = 6;
            this.TemplateButton.Text = "Create New Error Log";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // OpenDatabaseButton
            // 
            this.OpenDatabaseButton.Location = new System.Drawing.Point(232, 259);
            this.OpenDatabaseButton.Name = "OpenDatabaseButton";
            this.OpenDatabaseButton.Size = new System.Drawing.Size(130, 23);
            this.OpenDatabaseButton.TabIndex = 7;
            this.OpenDatabaseButton.Text = "Open a Database";
            this.OpenDatabaseButton.UseVisualStyleBackColor = true;
            this.OpenDatabaseButton.Click += new System.EventHandler(this.OpenDatabaseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Files (*.*)|*";
            this.openFileDialog1.Multiselect = true;
            // 
            // GenerateMetricsDisplay
            // 
            this.GenerateMetricsDisplay.Location = new System.Drawing.Point(12, 204);
            this.GenerateMetricsDisplay.Multiline = true;
            this.GenerateMetricsDisplay.Name = "GenerateMetricsDisplay";
            this.GenerateMetricsDisplay.ReadOnly = true;
            this.GenerateMetricsDisplay.Size = new System.Drawing.Size(350, 49);
            this.GenerateMetricsDisplay.TabIndex = 12;
            this.GenerateMetricsDisplay.Text = "Defect Removal Efficiency: \r\nCorrectness: \r\nMean Time to Fix Error: ";
            // 
            // GenerateMetricsButton
            // 
            this.GenerateMetricsButton.Location = new System.Drawing.Point(121, 175);
            this.GenerateMetricsButton.Name = "GenerateMetricsButton";
            this.GenerateMetricsButton.Size = new System.Drawing.Size(130, 23);
            this.GenerateMetricsButton.TabIndex = 5;
            this.GenerateMetricsButton.Text = "Calculate Metrics";
            this.GenerateMetricsButton.UseVisualStyleBackColor = true;
            this.GenerateMetricsButton.Click += new System.EventHandler(this.GenerateMetricsButton_Click);
            // 
            // DRECheckbox
            // 
            this.DRECheckbox.AutoSize = true;
            this.DRECheckbox.Location = new System.Drawing.Point(198, 101);
            this.DRECheckbox.Name = "DRECheckbox";
            this.DRECheckbox.Size = new System.Drawing.Size(152, 17);
            this.DRECheckbox.TabIndex = 3;
            this.DRECheckbox.Text = "Defect Removal Efficiency";
            this.DRECheckbox.UseVisualStyleBackColor = true;
            // 
            // CorrectnessCheckbox
            // 
            this.CorrectnessCheckbox.AutoSize = true;
            this.CorrectnessCheckbox.Location = new System.Drawing.Point(61, 38);
            this.CorrectnessCheckbox.Name = "CorrectnessCheckbox";
            this.CorrectnessCheckbox.Size = new System.Drawing.Size(82, 17);
            this.CorrectnessCheckbox.TabIndex = 0;
            this.CorrectnessCheckbox.Text = "Correctness";
            this.CorrectnessCheckbox.UseVisualStyleBackColor = true;
            // 
            // MaintainabilityCheckbox
            // 
            this.MaintainabilityCheckbox.AutoSize = true;
            this.MaintainabilityCheckbox.Location = new System.Drawing.Point(61, 101);
            this.MaintainabilityCheckbox.Name = "MaintainabilityCheckbox";
            this.MaintainabilityCheckbox.Size = new System.Drawing.Size(107, 17);
            this.MaintainabilityCheckbox.TabIndex = 2;
            this.MaintainabilityCheckbox.Text = "Mean Time to Fix";
            this.MaintainabilityCheckbox.UseVisualStyleBackColor = true;
            // 
            // MetricsLabel
            // 
            this.MetricsLabel.AutoSize = true;
            this.MetricsLabel.Location = new System.Drawing.Point(9, 7);
            this.MetricsLabel.Name = "MetricsLabel";
            this.MetricsLabel.Size = new System.Drawing.Size(133, 13);
            this.MetricsLabel.TabIndex = 9;
            this.MetricsLabel.Text = "Select Metrics to Calculate";
            // 
            // KLOCTextbox
            // 
            this.KLOCTextbox.Location = new System.Drawing.Point(162, 54);
            this.KLOCTextbox.Name = "KLOCTextbox";
            this.KLOCTextbox.Size = new System.Drawing.Size(201, 20);
            this.KLOCTextbox.TabIndex = 1;
            this.KLOCTextbox.TextChanged += new System.EventHandler(this.KLOCTextbox_TextChanged);
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(24, 130);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(132, 13);
            this.ReleaseDateLabel.TabIndex = 11;
            this.ReleaseDateLabel.Text = "Release Date of Software:";
            // 
            // KLOCLabel
            // 
            this.KLOCLabel.AutoSize = true;
            this.KLOCLabel.Location = new System.Drawing.Point(14, 58);
            this.KLOCLabel.Name = "KLOCLabel";
            this.KLOCLabel.Size = new System.Drawing.Size(143, 13);
            this.KLOCLabel.TabIndex = 10;
            this.KLOCLabel.Text = "Thousands of Lines of Code:";
            // 
            // ReleaseDateBox
            // 
            this.ReleaseDateBox.Location = new System.Drawing.Point(162, 124);
            this.ReleaseDateBox.Name = "ReleaseDateBox";
            this.ReleaseDateBox.Size = new System.Drawing.Size(200, 20);
            this.ReleaseDateBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fields below each checkbox are required if the checkbox is selected.";
            // 
            // DocumentBox
            // 
            this.DocumentBox.FormattingEnabled = true;
            this.DocumentBox.Location = new System.Drawing.Point(383, 5);
            this.DocumentBox.Name = "DocumentBox";
            this.DocumentBox.Size = new System.Drawing.Size(466, 342);
            this.DocumentBox.TabIndex = 14;
            this.DocumentBox.Visible = false;
            this.DocumentBox.SelectedIndexChanged += new System.EventHandler(this.DocumentBox_SelectedIndexChanged);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(233, 299);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(130, 23);
            this.HelpButton.TabIndex = 8;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Edit Selected Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.DocumentBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReleaseDateBox);
            this.Controls.Add(this.KLOCLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.KLOCTextbox);
            this.Controls.Add(this.MetricsLabel);
            this.Controls.Add(this.MaintainabilityCheckbox);
            this.Controls.Add(this.CorrectnessCheckbox);
            this.Controls.Add(this.DRECheckbox);
            this.Controls.Add(this.GenerateMetricsDisplay);
            this.Controls.Add(this.GenerateMetricsButton);
            this.Controls.Add(this.OpenDatabaseButton);
            this.Controls.Add(this.TemplateButton);
            this.KeyPreview = true;
            this.Name = "DatabaseWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Database Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TemplateButton;
        private System.Windows.Forms.Button OpenDatabaseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox GenerateMetricsDisplay;
        private System.Windows.Forms.Button GenerateMetricsButton;
        private System.Windows.Forms.CheckBox DRECheckbox;
        private System.Windows.Forms.CheckBox CorrectnessCheckbox;
        private System.Windows.Forms.CheckBox MaintainabilityCheckbox;
        private System.Windows.Forms.Label MetricsLabel;
        private System.Windows.Forms.TextBox KLOCTextbox;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label KLOCLabel;
        private System.Windows.Forms.DateTimePicker ReleaseDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox DocumentBox;
        private new System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button button1;
    }
}