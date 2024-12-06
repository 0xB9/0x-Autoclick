namespace Autoclick
{
    partial class Autoclick
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autoclick));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            versionLabel = new Label();
            topBorder = new Panel();
            titleLabel = new Label();
            closeButton = new Button();
            panelSidebar = new Panel();
            aboutTab = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            homeTab = new Guna.UI2.WinForms.Guna2Button();
            mainPanel = new Panel();
            topBorder.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Century Gothic", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.White;
            versionLabel.Location = new Point(454, 215);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(33, 13);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "v2.0.0";
            // 
            // topBorder
            // 
            topBorder.BackColor = Color.FromArgb(27, 8, 51);
            topBorder.Controls.Add(titleLabel);
            topBorder.Controls.Add(closeButton);
            topBorder.Dock = DockStyle.Top;
            topBorder.Location = new Point(0, 0);
            topBorder.Name = "topBorder";
            topBorder.Size = new Size(490, 30);
            topBorder.TabIndex = 0;
            topBorder.MouseDown += topBorder_MouseDown;
            topBorder.MouseMove += topBorder_MouseMove;
            topBorder.MouseUp += topBorder_MouseUp;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(4, 5);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(104, 19);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "0x Autoclick";
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.Location = new Point(464, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(26, 30);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 8, 51);
            panelSidebar.Controls.Add(aboutTab);
            panelSidebar.Controls.Add(guna2Button2);
            panelSidebar.Controls.Add(homeTab);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 30);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(159, 200);
            panelSidebar.TabIndex = 9;
            // 
            // aboutTab
            // 
            aboutTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            aboutTab.CheckedState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            aboutTab.CheckedState.FillColor = Color.FromArgb(40, 9, 79);
            aboutTab.CustomBorderThickness = new Padding(8, 0, 0, 0);
            aboutTab.CustomizableEdges = customizableEdges1;
            aboutTab.DisabledState.BorderColor = Color.DarkGray;
            aboutTab.DisabledState.CustomBorderColor = Color.DarkGray;
            aboutTab.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            aboutTab.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            aboutTab.FillColor = Color.FromArgb(27, 8, 51);
            aboutTab.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            aboutTab.ForeColor = Color.White;
            aboutTab.HoverState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            aboutTab.HoverState.FillColor = Color.FromArgb(40, 9, 79);
            aboutTab.Location = new Point(0, 160);
            aboutTab.Name = "aboutTab";
            aboutTab.ShadowDecoration.CustomizableEdges = customizableEdges2;
            aboutTab.Size = new Size(159, 40);
            aboutTab.TabIndex = 2;
            aboutTab.Text = "About";
            aboutTab.Click += aboutTab_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button2.CheckedState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            guna2Button2.CheckedState.FillColor = Color.FromArgb(40, 9, 79);
            guna2Button2.CustomBorderThickness = new Padding(8, 0, 0, 0);
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(27, 8, 51);
            guna2Button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.HoverState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            guna2Button2.HoverState.FillColor = Color.FromArgb(40, 9, 79);
            guna2Button2.Location = new Point(0, 40);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(159, 40);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Tab 2";
            // 
            // homeTab
            // 
            homeTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            homeTab.Checked = true;
            homeTab.CheckedState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            homeTab.CheckedState.FillColor = Color.FromArgb(40, 9, 79);
            homeTab.CustomBorderThickness = new Padding(8, 0, 0, 0);
            homeTab.CustomizableEdges = customizableEdges5;
            homeTab.DisabledState.BorderColor = Color.DarkGray;
            homeTab.DisabledState.CustomBorderColor = Color.DarkGray;
            homeTab.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            homeTab.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            homeTab.FillColor = Color.FromArgb(27, 8, 51);
            homeTab.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeTab.ForeColor = Color.White;
            homeTab.HoverState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            homeTab.HoverState.FillColor = Color.FromArgb(40, 9, 79);
            homeTab.Location = new Point(0, 0);
            homeTab.Name = "homeTab";
            homeTab.ShadowDecoration.CustomizableEdges = customizableEdges6;
            homeTab.Size = new Size(159, 40);
            homeTab.TabIndex = 0;
            homeTab.Text = "Home";
            homeTab.Click += homeTab_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(40, 9, 79);
            mainPanel.Location = new Point(158, 30);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(332, 200);
            mainPanel.TabIndex = 16;
            // 
            // Autoclick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            ClientSize = new Size(490, 230);
            Controls.Add(panelSidebar);
            Controls.Add(topBorder);
            Controls.Add(versionLabel);
            Controls.Add(mainPanel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Autoclick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autoclick";
            topBorder.ResumeLayout(false);
            topBorder.PerformLayout();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label versionLabel;
        private Panel topBorder;
        private Button closeButton;
        private Label titleLabel;
        private Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button homeTab;
        private Guna.UI2.WinForms.Guna2Button aboutTab;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Panel mainPanel;
    }
}