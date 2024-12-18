namespace Autoclick.Tabs
{
    partial class About
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            howToLabel = new Label();
            checkUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            howToLink = new LinkLabel();
            updateLabel = new Label();
            downloadButton = new Guna.UI2.WinForms.Guna2Button();
            openGithubLabel = new LinkLabel();
            sourceCodeLabel = new Label();
            reportLabel = new LinkLabel();
            feedbackLabel = new Label();
            SuspendLayout();
            // 
            // howToLabel
            // 
            howToLabel.AutoSize = true;
            howToLabel.ForeColor = Color.White;
            howToLabel.Location = new Point(9, 11);
            howToLabel.Name = "howToLabel";
            howToLabel.Size = new Size(80, 16);
            howToLabel.TabIndex = 0;
            howToLabel.Text = "How to use:";
            // 
            // checkUpdateButton
            // 
            checkUpdateButton.BackColor = Color.FromArgb(40, 9, 79);
            checkUpdateButton.BorderColor = Color.FromArgb(143, 71, 233);
            checkUpdateButton.BorderRadius = 7;
            checkUpdateButton.BorderThickness = 1;
            checkUpdateButton.CheckedState.FillColor = Color.FromArgb(66, 16, 130);
            checkUpdateButton.CustomizableEdges = customizableEdges1;
            checkUpdateButton.DisabledState.BorderColor = Color.DarkGray;
            checkUpdateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            checkUpdateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            checkUpdateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            checkUpdateButton.FillColor = Color.FromArgb(40, 9, 79);
            checkUpdateButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkUpdateButton.ForeColor = Color.White;
            checkUpdateButton.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            checkUpdateButton.HoverState.FillColor = Color.FromArgb(40, 9, 79);
            checkUpdateButton.Location = new Point(11, 153);
            checkUpdateButton.Name = "checkUpdateButton";
            checkUpdateButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            checkUpdateButton.Size = new Size(141, 30);
            checkUpdateButton.TabIndex = 1;
            checkUpdateButton.Text = "Check for Update";
            checkUpdateButton.Click += checkUpdateButton_Click;
            // 
            // howToLink
            // 
            howToLink.ActiveLinkColor = Color.Teal;
            howToLink.AutoSize = true;
            howToLink.LinkBehavior = LinkBehavior.NeverUnderline;
            howToLink.LinkColor = Color.FromArgb(0, 192, 192);
            howToLink.Location = new Point(88, 11);
            howToLink.Name = "howToLink";
            howToLink.Size = new Size(95, 16);
            howToLink.TabIndex = 2;
            howToLink.TabStop = true;
            howToLink.Text = "View README";
            howToLink.LinkClicked += howToLink_LinkClicked;
            // 
            // updateLabel
            // 
            updateLabel.AutoSize = true;
            updateLabel.ForeColor = Color.White;
            updateLabel.Location = new Point(9, 130);
            updateLabel.Name = "updateLabel";
            updateLabel.Size = new Size(154, 16);
            updateLabel.TabIndex = 3;
            updateLabel.Text = "Checking for update...";
            updateLabel.Visible = false;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.FromArgb(40, 9, 79);
            downloadButton.BorderColor = Color.FromArgb(143, 71, 233);
            downloadButton.BorderRadius = 7;
            downloadButton.BorderThickness = 1;
            downloadButton.CheckedState.FillColor = Color.FromArgb(66, 16, 130);
            downloadButton.CustomizableEdges = customizableEdges3;
            downloadButton.DisabledState.BorderColor = Color.DarkGray;
            downloadButton.DisabledState.CustomBorderColor = Color.DarkGray;
            downloadButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            downloadButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            downloadButton.FillColor = Color.FromArgb(40, 9, 79);
            downloadButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            downloadButton.ForeColor = Color.White;
            downloadButton.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            downloadButton.HoverState.FillColor = Color.FromArgb(40, 9, 79);
            downloadButton.Location = new Point(168, 153);
            downloadButton.Name = "downloadButton";
            downloadButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            downloadButton.Size = new Size(140, 30);
            downloadButton.TabIndex = 4;
            downloadButton.Text = "Download v0.0.0";
            downloadButton.Visible = false;
            downloadButton.Click += downloadButton_Click;
            // 
            // openGithubLabel
            // 
            openGithubLabel.ActiveLinkColor = Color.Teal;
            openGithubLabel.AutoSize = true;
            openGithubLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            openGithubLabel.LinkColor = Color.FromArgb(0, 192, 192);
            openGithubLabel.Location = new Point(99, 30);
            openGithubLabel.Name = "openGithubLabel";
            openGithubLabel.Size = new Size(86, 16);
            openGithubLabel.TabIndex = 6;
            openGithubLabel.TabStop = true;
            openGithubLabel.Text = "View Github";
            openGithubLabel.LinkClicked += openGithubLabel_LinkClicked;
            // 
            // sourceCodeLabel
            // 
            sourceCodeLabel.AutoSize = true;
            sourceCodeLabel.ForeColor = Color.White;
            sourceCodeLabel.Location = new Point(9, 30);
            sourceCodeLabel.Name = "sourceCodeLabel";
            sourceCodeLabel.Size = new Size(92, 16);
            sourceCodeLabel.TabIndex = 5;
            sourceCodeLabel.Text = "Source code:";
            // 
            // reportLabel
            // 
            reportLabel.ActiveLinkColor = Color.Teal;
            reportLabel.AutoSize = true;
            reportLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            reportLabel.LinkColor = Color.FromArgb(0, 192, 192);
            reportLabel.Location = new Point(122, 49);
            reportLabel.Name = "reportLabel";
            reportLabel.Size = new Size(94, 16);
            reportLabel.TabIndex = 8;
            reportLabel.TabStop = true;
            reportLabel.Text = "Create report";
            reportLabel.LinkClicked += reportLabel_LinkClicked;
            // 
            // feedbackLabel
            // 
            feedbackLabel.AutoSize = true;
            feedbackLabel.ForeColor = Color.White;
            feedbackLabel.Location = new Point(9, 49);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(115, 16);
            feedbackLabel.TabIndex = 7;
            feedbackLabel.Text = "Share feedback:";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            Controls.Add(howToLabel);
            Controls.Add(feedbackLabel);
            Controls.Add(sourceCodeLabel);
            Controls.Add(reportLabel);
            Controls.Add(openGithubLabel);
            Controls.Add(downloadButton);
            Controls.Add(updateLabel);
            Controls.Add(howToLink);
            Controls.Add(checkUpdateButton);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "About";
            Size = new Size(379, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label howToLabel;
        private Guna.UI2.WinForms.Guna2Button checkUpdateButton;
        private LinkLabel howToLink;
        private Label updateLabel;
        private Guna.UI2.WinForms.Guna2Button downloadButton;
        private LinkLabel openGithubLabel;
        private Label sourceCodeLabel;
        private LinkLabel reportLabel;
        private Label feedbackLabel;
    }
}
