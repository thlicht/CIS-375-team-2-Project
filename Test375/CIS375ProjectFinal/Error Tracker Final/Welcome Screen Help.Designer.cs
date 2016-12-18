namespace Error_Tracker_Final
{
    partial class WelcomeScreenHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreenHelp));
            this.BackButton = new System.Windows.Forms.Button();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(185, 157);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 39);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Go Back to Welcome Screen";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(12, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(447, 143);
            this.HelpLabel.TabIndex = 1;
            this.HelpLabel.Text = resources.GetString("HelpLabel.Text");
            // 
            // WelcomeScreenHelp
            // 
            this.AcceptButton = this.BackButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 201);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeScreenHelp";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label HelpLabel;
    }
}