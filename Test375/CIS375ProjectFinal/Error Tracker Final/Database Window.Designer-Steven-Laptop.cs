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
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.KLOCLabel = new System.Windows.Forms.Label();
            this.ReleaseDateBox = new System.Windows.Forms.DateTimePicker();
            this.RepelTextbox = new System.Windows.Forms.TextBox();
            this.AttackTextbox = new System.Windows.Forms.TextBox();
            this.RepelLabel = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TemplateButton
            // 
            this.TemplateButton.Location = new System.Drawing.Point(75, 354);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(117, 23);
            this.TemplateButton.TabIndex = 6;
            this.TemplateButton.Text = "Create New Error Log";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // OpenDatabaseButton
            // 
            this.OpenDatabaseButton.Location = new System.Drawing.Point(212, 354);
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
            this.DatabaseNameLabel.Location = new System.Drawing.Point(384, 9);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(188, 13);
            this.DatabaseNameLabel.TabIndex = 8;
            this.DatabaseNameLabel.Text = "Database Path Will be Displayed Here";
            // 
            // GenerateMetricsDisplay
            // 
            this.GenerateMetricsDisplay.Location = new System.Drawing.Point(75, 286);
            this.GenerateMetricsDisplay.Multiline = true;
            this.GenerateMetricsDisplay.Name = "GenerateMetricsDisplay";
            this.GenerateMetricsDisplay.ReadOnly = true;
            this.GenerateMetricsDisplay.Size = new System.Drawing.Size(236, 62);
            this.GenerateMetricsDisplay.TabIndex = 10;
            this.GenerateMetricsDisplay.Text = "Defect Removal Efficiency: \r\nCorrectness: \r\nMaintainability: \r\nIntegrity: ";
            // 
            // GenerateMetricsButton
            // 
            this.GenerateMetricsButton.Location = new System.Drawing.Point(141, 257);
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
            this.IntegrityCheckbox.Location = new System.Drawing.Point(135, 165);
            this.IntegrityCheckbox.Name = "IntegrityCheckbox";
            this.IntegrityCheckbox.Size = new System.Drawing.Size(63, 17);
            this.IntegrityCheckbox.TabIndex = 4;
            this.IntegrityCheckbox.Text = "Integrity";
            this.IntegrityCheckbox.UseVisualStyleBackColor = true;
            // 
            // DRECheckbox
            // 
            this.DRECheckbox.AutoSize = true;
            this.DRECheckbox.Location = new System.Drawing.Point(133, 23);
            this.DRECheckbox.Name = "DRECheckbox";
            this.DRECheckbox.Size = new System.Drawing.Size(152, 17);
            this.DRECheckbox.TabIndex = 1;
            this.DRECheckbox.Text = "Defect Removal Efficiency";
            this.DRECheckbox.UseVisualStyleBackColor = true;
            // 
            // CorrectnessCheckbox
            // 
            this.CorrectnessCheckbox.AutoSize = true;
            this.CorrectnessCheckbox.Location = new System.Drawing.Point(133, 46);
            this.CorrectnessCheckbox.Name = "CorrectnessCheckbox";
            this.CorrectnessCheckbox.Size = new System.Drawing.Size(82, 17);
            this.CorrectnessCheckbox.TabIndex = 2;
            this.CorrectnessCheckbox.Text = "Correctness";
            this.CorrectnessCheckbox.UseVisualStyleBackColor = true;
            // 
            // MaintainabilityCheckbox
            // 
            this.MaintainabilityCheckbox.AutoSize = true;
            this.MaintainabilityCheckbox.Location = new System.Drawing.Point(133, 103);
            this.MaintainabilityCheckbox.Name = "MaintainabilityCheckbox";
            this.MaintainabilityCheckbox.Size = new System.Drawing.Size(92, 17);
            this.MaintainabilityCheckbox.TabIndex = 3;
            this.MaintainabilityCheckbox.Text = "Maintainability";
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
            this.KLOCTextbox.Location = new System.Drawing.Point(164, 69);
            this.KLOCTextbox.Name = "KLOCTextbox";
            this.KLOCTextbox.Size = new System.Drawing.Size(201, 20);
            this.KLOCTextbox.TabIndex = 12;
            this.KLOCTextbox.TextChanged += new System.EventHandler(this.KLOCTextbox_TextChanged);
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(83, 127);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(75, 13);
            this.ReleaseDateLabel.TabIndex = 13;
            this.ReleaseDateLabel.Text = "Release Date:";
            // 
            // KLOCLabel
            // 
            this.KLOCLabel.AutoSize = true;
            this.KLOCLabel.Location = new System.Drawing.Point(16, 73);
            this.KLOCLabel.Name = "KLOCLabel";
            this.KLOCLabel.Size = new System.Drawing.Size(143, 13);
            this.KLOCLabel.TabIndex = 14;
            this.KLOCLabel.Text = "Thousands of Lines of Code:";
            // 
            // ReleaseDateBox
            // 
            this.ReleaseDateBox.Location = new System.Drawing.Point(164, 126);
            this.ReleaseDateBox.Name = "ReleaseDateBox";
            this.ReleaseDateBox.Size = new System.Drawing.Size(200, 20);
            this.ReleaseDateBox.TabIndex = 15;
            // 
            // RepelTextbox
            // 
            this.RepelTextbox.Location = new System.Drawing.Point(163, 225);
            this.RepelTextbox.Name = "RepelTextbox";
            this.RepelTextbox.Size = new System.Drawing.Size(201, 20);
            this.RepelTextbox.TabIndex = 16;
            // 
            // AttackTextbox
            // 
            this.AttackTextbox.Location = new System.Drawing.Point(164, 189);
            this.AttackTextbox.Name = "AttackTextbox";
            this.AttackTextbox.Size = new System.Drawing.Size(201, 20);
            this.AttackTextbox.TabIndex = 17;
            this.AttackTextbox.TextChanged += new System.EventHandler(this.AttackTextbox_TextChanged);
            // 
            // RepelLabel
            // 
            this.RepelLabel.AutoSize = true;
            this.RepelLabel.Location = new System.Drawing.Point(9, 232);
            this.RepelLabel.Name = "RepelLabel";
            this.RepelLabel.Size = new System.Drawing.Size(149, 13);
            this.RepelLabel.TabIndex = 18;
            this.RepelLabel.Text = "Probability of Repeling Attack:";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(55, 196);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(104, 13);
            this.AttackLabel.TabIndex = 19;
            this.AttackLabel.Text = "Probability of Attack:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fields below each checkbox are required if the box is selected.";
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AttackLabel);
            this.Controls.Add(this.RepelLabel);
            this.Controls.Add(this.AttackTextbox);
            this.Controls.Add(this.RepelTextbox);
            this.Controls.Add(this.ReleaseDateBox);
            this.Controls.Add(this.KLOCLabel);
            this.Controls.Add(this.ReleaseDateLabel);
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
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label KLOCLabel;
        private System.Windows.Forms.DateTimePicker ReleaseDateBox;
        private System.Windows.Forms.TextBox RepelTextbox;
        private System.Windows.Forms.TextBox AttackTextbox;
        private System.Windows.Forms.Label RepelLabel;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Label label5;
    }
}