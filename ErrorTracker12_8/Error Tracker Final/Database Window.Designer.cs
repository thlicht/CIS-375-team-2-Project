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
            this.DatabaseNameLabel = new System.Windows.Forms.Label();
            this.GenerateMetricsDisplay = new System.Windows.Forms.TextBox();
            this.GenerateMetricsButton = new System.Windows.Forms.Button();
            this.IntegrityCheckbox = new System.Windows.Forms.CheckBox();
            this.DRECheckbox = new System.Windows.Forms.CheckBox();
            this.CorrectnessCheckbox = new System.Windows.Forms.CheckBox();
            this.MaintainabilityCheckbox = new System.Windows.Forms.CheckBox();
            this.MetricsLabel = new System.Windows.Forms.Label();
            this.KLOCTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReleaseDateBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TemplateButton
            // 
            this.TemplateButton.Location = new System.Drawing.Point(12, 243);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(117, 23);
            this.TemplateButton.TabIndex = 6;
            this.TemplateButton.Text = "Create New Error Log";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // OpenDatabaseButton
            // 
            this.OpenDatabaseButton.Location = new System.Drawing.Point(149, 243);
            this.OpenDatabaseButton.Name = "OpenDatabaseButton";
            this.OpenDatabaseButton.Size = new System.Drawing.Size(99, 23);
            this.OpenDatabaseButton.TabIndex = 7;
            this.OpenDatabaseButton.Text = "Open a Database";
            this.OpenDatabaseButton.UseVisualStyleBackColor = true;
            this.OpenDatabaseButton.Click += new System.EventHandler(this.OpenDatabaseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File (*.txt)|*.txt*";
            this.openFileDialog1.Multiselect = true;
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.AutoSize = true;
            this.DatabaseNameLabel.Location = new System.Drawing.Point(39, 9);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(188, 13);
            this.DatabaseNameLabel.TabIndex = 8;
            this.DatabaseNameLabel.Text = "Database Path Will be Displayed Here";
            // 
            // GenerateMetricsDisplay
            // 
            this.GenerateMetricsDisplay.Location = new System.Drawing.Point(12, 175);
            this.GenerateMetricsDisplay.Multiline = true;
            this.GenerateMetricsDisplay.Name = "GenerateMetricsDisplay";
            this.GenerateMetricsDisplay.ReadOnly = true;
            this.GenerateMetricsDisplay.Size = new System.Drawing.Size(236, 62);
            this.GenerateMetricsDisplay.TabIndex = 10;
            this.GenerateMetricsDisplay.Text = "Defect Removal Efficiency: \r\nCorrectness: \r\nMaintainability: \r\nIntegrity: ";
            // 
            // GenerateMetricsButton
            // 
            this.GenerateMetricsButton.Location = new System.Drawing.Point(78, 146);
            this.GenerateMetricsButton.Name = "GenerateMetricsButton";
            this.GenerateMetricsButton.Size = new System.Drawing.Size(106, 23);
            this.GenerateMetricsButton.TabIndex = 5;
            this.GenerateMetricsButton.Text = "Calculate Metrics";
            this.GenerateMetricsButton.UseVisualStyleBackColor = true;
            this.GenerateMetricsButton.Click += new System.EventHandler(this.GenerateMetricsButton_Click);
            // 
            // IntegrityCheckbox
            // 
            this.IntegrityCheckbox.AutoSize = true;
            this.IntegrityCheckbox.Location = new System.Drawing.Point(55, 123);
            this.IntegrityCheckbox.Name = "IntegrityCheckbox";
            this.IntegrityCheckbox.Size = new System.Drawing.Size(63, 17);
            this.IntegrityCheckbox.TabIndex = 4;
            this.IntegrityCheckbox.Text = "Integrity";
            this.IntegrityCheckbox.UseVisualStyleBackColor = true;
            // 
            // DRECheckbox
            // 
            this.DRECheckbox.AutoSize = true;
            this.DRECheckbox.Location = new System.Drawing.Point(55, 54);
            this.DRECheckbox.Name = "DRECheckbox";
            this.DRECheckbox.Size = new System.Drawing.Size(152, 17);
            this.DRECheckbox.TabIndex = 1;
            this.DRECheckbox.Text = "Defect Removal Efficiency";
            this.DRECheckbox.UseVisualStyleBackColor = true;
            // 
            // CorrectnessCheckbox
            // 
            this.CorrectnessCheckbox.AutoSize = true;
            this.CorrectnessCheckbox.Location = new System.Drawing.Point(55, 77);
            this.CorrectnessCheckbox.Name = "CorrectnessCheckbox";
            this.CorrectnessCheckbox.Size = new System.Drawing.Size(82, 17);
            this.CorrectnessCheckbox.TabIndex = 2;
            this.CorrectnessCheckbox.Text = "Correctness";
            this.CorrectnessCheckbox.UseVisualStyleBackColor = true;
            // 
            // MaintainabilityCheckbox
            // 
            this.MaintainabilityCheckbox.AutoSize = true;
            this.MaintainabilityCheckbox.Location = new System.Drawing.Point(55, 100);
            this.MaintainabilityCheckbox.Name = "MaintainabilityCheckbox";
            this.MaintainabilityCheckbox.Size = new System.Drawing.Size(92, 17);
            this.MaintainabilityCheckbox.TabIndex = 3;
            this.MaintainabilityCheckbox.Text = "Maintainability";
            this.MaintainabilityCheckbox.UseVisualStyleBackColor = true;
            // 
            // MetricsLabel
            // 
            this.MetricsLabel.AutoSize = true;
            this.MetricsLabel.Location = new System.Drawing.Point(52, 38);
            this.MetricsLabel.Name = "MetricsLabel";
            this.MetricsLabel.Size = new System.Drawing.Size(133, 13);
            this.MetricsLabel.TabIndex = 9;
            this.MetricsLabel.Text = "Select Metrics to Calculate";
            // 
            // KLOCTextbox
            // 
            this.KLOCTextbox.Location = new System.Drawing.Point(333, 100);
            this.KLOCTextbox.Name = "KLOCTextbox";
            this.KLOCTextbox.Size = new System.Drawing.Size(100, 20);
            this.KLOCTextbox.TabIndex = 12;
            this.KLOCTextbox.TextChanged += new System.EventHandler(this.KLOCTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Release Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "KLOC:";
            // 
            // ReleaseDateBox
            // 
            this.ReleaseDateBox.Location = new System.Drawing.Point(334, 54);
            this.ReleaseDateBox.Name = "ReleaseDateBox";
            this.ReleaseDateBox.Size = new System.Drawing.Size(200, 20);
            this.ReleaseDateBox.TabIndex = 15;
            this.ReleaseDateBox.ValueChanged += new System.EventHandler(this.ReleaseDateBox_ValueChanged);
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 274);
            this.Controls.Add(this.ReleaseDateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KLOCTextbox);
            this.Controls.Add(this.MetricsLabel);
            this.Controls.Add(this.MaintainabilityCheckbox);
            this.Controls.Add(this.CorrectnessCheckbox);
            this.Controls.Add(this.DRECheckbox);
            this.Controls.Add(this.IntegrityCheckbox);
            this.Controls.Add(this.GenerateMetricsDisplay);
            this.Controls.Add(this.GenerateMetricsButton);
            this.Controls.Add(this.DatabaseNameLabel);
            this.Controls.Add(this.OpenDatabaseButton);
            this.Controls.Add(this.TemplateButton);
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
        private System.Windows.Forms.Label DatabaseNameLabel;
        private System.Windows.Forms.TextBox GenerateMetricsDisplay;
        private System.Windows.Forms.Button GenerateMetricsButton;
        private System.Windows.Forms.CheckBox IntegrityCheckbox;
        private System.Windows.Forms.CheckBox DRECheckbox;
        private System.Windows.Forms.CheckBox CorrectnessCheckbox;
        private System.Windows.Forms.CheckBox MaintainabilityCheckbox;
        private System.Windows.Forms.Label MetricsLabel;
        private System.Windows.Forms.TextBox KLOCTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ReleaseDateBox;
    }
}