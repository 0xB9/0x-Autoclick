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
            howToLabel = new Label();
            checkUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            howToLink = new LinkLabel();
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
            checkUpdateButton.BackColor = Color.FromArgb(66, 16, 130);
            checkUpdateButton.CheckedState.FillColor = Color.FromArgb(66, 16, 130);
            checkUpdateButton.CustomizableEdges = customizableEdges1;
            checkUpdateButton.DisabledState.BorderColor = Color.DarkGray;
            checkUpdateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            checkUpdateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            checkUpdateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            checkUpdateButton.FillColor = Color.FromArgb(66, 16, 130);
            checkUpdateButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkUpdateButton.ForeColor = Color.White;
            checkUpdateButton.HoverState.FillColor = Color.FromArgb(27, 8, 51);
            checkUpdateButton.Location = new Point(86, 161);
            checkUpdateButton.Name = "checkUpdateButton";
            checkUpdateButton.PressedColor = Color.FromArgb(66, 16, 130);
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
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            Controls.Add(howToLink);
            Controls.Add(checkUpdateButton);
            Controls.Add(howToLabel);
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
    }
}
