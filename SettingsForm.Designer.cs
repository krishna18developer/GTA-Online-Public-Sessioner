namespace GTA_Online_Public_Sessioner
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processLabel = new System.Windows.Forms.Label();
            this.processNameBox = new System.Windows.Forms.TextBox();
            this.suspensionDurationBox = new System.Windows.Forms.TextBox();
            this.suspensionLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(12, 44);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(82, 13);
            this.processLabel.TabIndex = 1;
            this.processLabel.Text = "Process Name :";
            // 
            // processNameBox
            // 
            this.processNameBox.Location = new System.Drawing.Point(100, 41);
            this.processNameBox.Name = "processNameBox";
            this.processNameBox.Size = new System.Drawing.Size(100, 20);
            this.processNameBox.TabIndex = 2;
            // 
            // suspensionDurationBox
            // 
            this.suspensionDurationBox.Location = new System.Drawing.Point(326, 41);
            this.suspensionDurationBox.Name = "suspensionDurationBox";
            this.suspensionDurationBox.Size = new System.Drawing.Size(100, 20);
            this.suspensionDurationBox.TabIndex = 4;
            // 
            // suspensionLabel
            // 
            this.suspensionLabel.AutoSize = true;
            this.suspensionLabel.Location = new System.Drawing.Point(209, 44);
            this.suspensionLabel.Name = "suspensionLabel";
            this.suspensionLabel.Size = new System.Drawing.Size(111, 13);
            this.suspensionLabel.TabIndex = 3;
            this.suspensionLabel.Text = "Suspension Duration :";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(451, 41);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 5;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 93);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.suspensionDurationBox);
            this.Controls.Add(this.suspensionLabel);
            this.Controls.Add(this.processNameBox);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.TextBox suspensionDurationBox;
        private System.Windows.Forms.Label suspensionLabel;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox processNameBox;
    }
}