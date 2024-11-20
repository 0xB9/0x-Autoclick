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
            label1 = new Label();
            checkUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(155, 90);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 0;
            label1.Text = "About";
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
            checkUpdateButton.Location = new Point(104, 152);
            checkUpdateButton.Name = "checkUpdateButton";
            checkUpdateButton.PressedColor = Color.FromArgb(66, 16, 130);
            checkUpdateButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            checkUpdateButton.Size = new Size(150, 40);
            checkUpdateButton.TabIndex = 1;
            checkUpdateButton.Text = "Check for Update";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            Controls.Add(checkUpdateButton);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "About";
            Size = new Size(379, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button checkUpdateButton;
    }
}
