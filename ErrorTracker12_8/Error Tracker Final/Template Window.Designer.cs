﻿namespace Error_Tracker_Final
{
    partial class TemplateWindow
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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Reporter = new System.Windows.Forms.Label();
            this.ReporterTextbox = new System.Windows.Forms.TextBox();
            this.AffectedComponents = new System.Windows.Forms.Label();
            this.AffectedComponentsTextbox = new System.Windows.Forms.TextBox();
            this.StepsToReproduce = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ResolveDate = new System.Windows.Forms.Label();
            this.StepsToReproduceTextbox = new System.Windows.Forms.TextBox();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.RequirementsLabel = new System.Windows.Forms.Label();
            this.ACCharactersRemaining = new System.Windows.Forms.TextBox();
            this.CharactersRemainingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StRCharactersRemaining = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DCharactersRemaining = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReportDateBox = new System.Windows.Forms.DateTimePicker();
            this.ResolveDateBox = new System.Windows.Forms.DateTimePicker();
            this.ReleaseDateBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(86, 12);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(200, 20);
            this.NameTextbox.TabIndex = 0;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(38, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 13);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name*:";
            // 
            // Reporter
            // 
            this.Reporter.AutoSize = true;
            this.Reporter.Location = new System.Drawing.Point(29, 58);
            this.Reporter.Name = "Reporter";
            this.Reporter.Size = new System.Drawing.Size(51, 13);
            this.Reporter.TabIndex = 15;
            this.Reporter.Text = "Reporter:";
            // 
            // ReporterTextbox
            // 
            this.ReporterTextbox.Location = new System.Drawing.Point(86, 58);
            this.ReporterTextbox.Name = "ReporterTextbox";
            this.ReporterTextbox.Size = new System.Drawing.Size(200, 20);
            this.ReporterTextbox.TabIndex = 1;
            this.ReporterTextbox.TextChanged += new System.EventHandler(this.ReporterTextbox_TextChanged);
            // 
            // AffectedComponents
            // 
            this.AffectedComponents.AutoSize = true;
            this.AffectedComponents.Location = new System.Drawing.Point(324, 8);
            this.AffectedComponents.Name = "AffectedComponents";
            this.AffectedComponents.Size = new System.Drawing.Size(116, 13);
            this.AffectedComponents.TabIndex = 23;
            this.AffectedComponents.Text = "Affected Components*:";
            // 
            // AffectedComponentsTextbox
            // 
            this.AffectedComponentsTextbox.Location = new System.Drawing.Point(327, 24);
            this.AffectedComponentsTextbox.MaxLength = 2000;
            this.AffectedComponentsTextbox.Multiline = true;
            this.AffectedComponentsTextbox.Name = "AffectedComponentsTextbox";
            this.AffectedComponentsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AffectedComponentsTextbox.Size = new System.Drawing.Size(336, 228);
            this.AffectedComponentsTextbox.TabIndex = 7;
            this.AffectedComponentsTextbox.TextChanged += new System.EventHandler(this.AffectedComponentsTextbox_TextChanged);
            // 
            // StepsToReproduce
            // 
            this.StepsToReproduce.AutoSize = true;
            this.StepsToReproduce.Location = new System.Drawing.Point(324, 272);
            this.StepsToReproduce.Name = "StepsToReproduce";
            this.StepsToReproduce.Size = new System.Drawing.Size(109, 13);
            this.StepsToReproduce.TabIndex = 26;
            this.StepsToReproduce.Text = "Steps to Reproduce*:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(36, 292);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 13);
            this.Status.TabIndex = 20;
            this.Status.Text = "Status*:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Open",
            "Resolved",
            "Duplicate"});
            this.StatusComboBox.Location = new System.Drawing.Point(86, 289);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(200, 21);
            this.StatusComboBox.TabIndex = 6;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(55, 110);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 13);
            this.ID.TabIndex = 16;
            this.ID.Text = "ID*:";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(86, 107);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(200, 20);
            this.IDTextbox.TabIndex = 2;
            this.IDTextbox.TextChanged += new System.EventHandler(this.IDTextbox_TextChanged);
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(6, 202);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.ReleaseDate.TabIndex = 18;
            this.ReleaseDate.Text = "Release Date:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(13, 162);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(68, 13);
            this.Date.TabIndex = 17;
            this.Date.Text = "Report Date:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(693, 7);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(67, 13);
            this.Description.TabIndex = 29;
            this.Description.Text = "Description*:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(696, 24);
            this.DescriptionTextbox.MaxLength = 32000;
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextbox.Size = new System.Drawing.Size(464, 492);
            this.DescriptionTextbox.TabIndex = 9;
            this.DescriptionTextbox.TextChanged += new System.EventHandler(this.DescriptionTextbox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(8, 330);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save Error Log";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(8, 392);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(122, 23);
            this.OpenButton.TabIndex = 12;
            this.OpenButton.Text = "Open Error Log";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ResolveDate
            // 
            this.ResolveDate.AutoSize = true;
            this.ResolveDate.Location = new System.Drawing.Point(5, 249);
            this.ResolveDate.Name = "ResolveDate";
            this.ResolveDate.Size = new System.Drawing.Size(75, 13);
            this.ResolveDate.TabIndex = 19;
            this.ResolveDate.Text = "Resolve Date:";
            // 
            // StepsToReproduceTextbox
            // 
            this.StepsToReproduceTextbox.Location = new System.Drawing.Point(327, 288);
            this.StepsToReproduceTextbox.MaxLength = 2000;
            this.StepsToReproduceTextbox.Multiline = true;
            this.StepsToReproduceTextbox.Name = "StepsToReproduceTextbox";
            this.StepsToReproduceTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StepsToReproduceTextbox.Size = new System.Drawing.Size(336, 228);
            this.StepsToReproduceTextbox.TabIndex = 8;
            this.StepsToReproduceTextbox.TextChanged += new System.EventHandler(this.StepsToReproduceTextbox_TextChanged);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Location = new System.Drawing.Point(165, 392);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(122, 23);
            this.DatabaseButton.TabIndex = 13;
            this.DatabaseButton.Text = "Open Database";
            this.DatabaseButton.UseVisualStyleBackColor = true;
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
            // 
            // RequirementsLabel
            // 
            this.RequirementsLabel.AutoSize = true;
            this.RequirementsLabel.Location = new System.Drawing.Point(6, 506);
            this.RequirementsLabel.Name = "RequirementsLabel";
            this.RequirementsLabel.Size = new System.Drawing.Size(83, 13);
            this.RequirementsLabel.TabIndex = 22;
            this.RequirementsLabel.Text = "* = required field";
            // 
            // ACCharactersRemaining
            // 
            this.ACCharactersRemaining.Location = new System.Drawing.Point(631, 4);
            this.ACCharactersRemaining.Name = "ACCharactersRemaining";
            this.ACCharactersRemaining.ReadOnly = true;
            this.ACCharactersRemaining.Size = new System.Drawing.Size(32, 20);
            this.ACCharactersRemaining.TabIndex = 25;
            this.ACCharactersRemaining.WordWrap = false;
            // 
            // CharactersRemainingLabel
            // 
            this.CharactersRemainingLabel.AutoSize = true;
            this.CharactersRemainingLabel.Location = new System.Drawing.Point(511, 7);
            this.CharactersRemainingLabel.Name = "CharactersRemainingLabel";
            this.CharactersRemainingLabel.Size = new System.Drawing.Size(114, 13);
            this.CharactersRemainingLabel.TabIndex = 24;
            this.CharactersRemainingLabel.Text = "Characters Remaining:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Characters Remaining:";
            // 
            // StRCharactersRemaining
            // 
            this.StRCharactersRemaining.Location = new System.Drawing.Point(631, 269);
            this.StRCharactersRemaining.Name = "StRCharactersRemaining";
            this.StRCharactersRemaining.ReadOnly = true;
            this.StRCharactersRemaining.Size = new System.Drawing.Size(32, 20);
            this.StRCharactersRemaining.TabIndex = 28;
            this.StRCharactersRemaining.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(998, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Characters Remaining:";
            // 
            // DCharactersRemaining
            // 
            this.DCharactersRemaining.Location = new System.Drawing.Point(1118, 5);
            this.DCharactersRemaining.Name = "DCharactersRemaining";
            this.DCharactersRemaining.ReadOnly = true;
            this.DCharactersRemaining.Size = new System.Drawing.Size(42, 20);
            this.DCharactersRemaining.TabIndex = 31;
            this.DCharactersRemaining.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File (*.txt)|*.txt*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text File (*.txt)|*.txt*";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(165, 330);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(122, 23);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Reset All Fields";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ReportDateBox
            // 
            this.ReportDateBox.Location = new System.Drawing.Point(87, 156);
            this.ReportDateBox.Name = "ReportDateBox";
            this.ReportDateBox.Size = new System.Drawing.Size(199, 20);
            this.ReportDateBox.TabIndex = 3;
            // 
            // ResolveDateBox
            // 
            this.ResolveDateBox.Location = new System.Drawing.Point(86, 243);
            this.ResolveDateBox.Name = "ResolveDateBox";
            this.ResolveDateBox.Size = new System.Drawing.Size(200, 20);
            this.ResolveDateBox.TabIndex = 5;
            // 
            // ReleaseDateBox
            // 
            this.ReleaseDateBox.Location = new System.Drawing.Point(87, 202);
            this.ReleaseDateBox.Name = "ReleaseDateBox";
            this.ReleaseDateBox.Size = new System.Drawing.Size(200, 20);
            this.ReleaseDateBox.TabIndex = 4;
            // 
            // TemplateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1174, 528);
            this.Controls.Add(this.ReleaseDateBox);
            this.Controls.Add(this.ResolveDateBox);
            this.Controls.Add(this.ReportDateBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DCharactersRemaining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StRCharactersRemaining);
            this.Controls.Add(this.CharactersRemainingLabel);
            this.Controls.Add(this.ACCharactersRemaining);
            this.Controls.Add(this.RequirementsLabel);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.StepsToReproduceTextbox);
            this.Controls.Add(this.ResolveDate);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StepsToReproduce);
            this.Controls.Add(this.AffectedComponents);
            this.Controls.Add(this.AffectedComponentsTextbox);
            this.Controls.Add(this.Reporter);
            this.Controls.Add(this.ReporterTextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextbox);
            this.Name = "TemplateWindow";
            this.Text = "Error Log Template";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TemplateWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Reporter;
        private System.Windows.Forms.TextBox ReporterTextbox;
        private System.Windows.Forms.Label AffectedComponents;
        private System.Windows.Forms.TextBox AffectedComponentsTextbox;
        private System.Windows.Forms.Label StepsToReproduce;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label ResolveDate;
        private System.Windows.Forms.TextBox StepsToReproduceTextbox;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Label RequirementsLabel;
        private System.Windows.Forms.TextBox ACCharactersRemaining;
        private System.Windows.Forms.Label CharactersRemainingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StRCharactersRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DCharactersRemaining;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DateTimePicker ReportDateBox;
        private System.Windows.Forms.DateTimePicker ResolveDateBox;
        private System.Windows.Forms.DateTimePicker ReleaseDateBox;
    }
}

