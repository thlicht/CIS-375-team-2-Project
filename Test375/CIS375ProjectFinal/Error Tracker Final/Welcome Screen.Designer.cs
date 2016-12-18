namespace Error_Tracker_Final
{
    partial class WelcomeWindow
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(38, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(380, 62);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome to the Error Tracking\r\nDatabase";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 112);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(118, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create New Error Log";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Location = new System.Drawing.Point(300, 112);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(118, 23);
            this.DatabaseButton.TabIndex = 1;
            this.DatabaseButton.Text = "Go to Database";
            this.DatabaseButton.UseVisualStyleBackColor = true;
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(154, 158);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(118, 23);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 190);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "WelcomeWindow";
            this.Text = "Error Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Button HelpButton;
    }
}