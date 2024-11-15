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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            milliText = new TextBox();
            startButton = new Button();
            stopButton = new Button();
            versionLabel = new Label();
            millisecondLabel = new Label();
            topBorder = new Panel();
            titleLabel = new Label();
            closeButton = new Button();
            noValueLabel = new Label();
            panelSidebar = new Panel();
            aboutTab = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            homeTab = new Guna.UI2.WinForms.Guna2Button();
            leftMouseButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            labelLMB = new Label();
            labelRMB = new Label();
            rightMouseButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            homeStatusLabel = new Label();
            homeStatus = new Label();
            topBorder.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // milliText
            // 
            milliText.BackColor = Color.FromArgb(66, 16, 130);
            milliText.BorderStyle = BorderStyle.None;
            milliText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            milliText.ForeColor = Color.White;
            milliText.Location = new Point(167, 57);
            milliText.Multiline = true;
            milliText.Name = "milliText";
            milliText.PlaceholderText = "3000";
            milliText.Size = new Size(173, 21);
            milliText.TabIndex = 2;
            milliText.KeyPress += milliText_KeyPress;
            // 
            // startButton
            // 
            startButton.FlatAppearance.BorderColor = Color.FromArgb(27, 8, 51);
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(352, 53);
            startButton.Name = "startButton";
            startButton.Size = new Size(129, 30);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.FlatAppearance.BorderColor = Color.FromArgb(27, 8, 51);
            stopButton.FlatAppearance.BorderSize = 2;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stopButton.ForeColor = Color.White;
            stopButton.Location = new Point(352, 91);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(129, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "STOP";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Century Gothic", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.White;
            versionLabel.Location = new Point(445, 215);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(43, 13);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "v2.0.0-b";
            // 
            // millisecondLabel
            // 
            millisecondLabel.AutoSize = true;
            millisecondLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            millisecondLabel.ForeColor = Color.White;
            millisecondLabel.Location = new Point(167, 39);
            millisecondLabel.Name = "millisecondLabel";
            millisecondLabel.Size = new Size(88, 16);
            millisecondLabel.TabIndex = 1;
            millisecondLabel.Text = "Milliseconds";
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
            titleLabel.Size = new Size(82, 19);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Autoclick";
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
            // noValueLabel
            // 
            noValueLabel.AutoSize = true;
            noValueLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            noValueLabel.ForeColor = Color.FromArgb(177, 14, 18);
            noValueLabel.Location = new Point(168, 80);
            noValueLabel.Name = "noValueLabel";
            noValueLabel.Size = new Size(85, 16);
            noValueLabel.TabIndex = 8;
            noValueLabel.Text = "Enter a value!";
            noValueLabel.Visible = false;
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
            // 
            // leftMouseButton
            // 
            leftMouseButton.Checked = true;
            leftMouseButton.CheckedState.BorderColor = Color.FromArgb(66, 16, 130);
            leftMouseButton.CheckedState.BorderThickness = 0;
            leftMouseButton.CheckedState.FillColor = Color.FromArgb(96, 32, 176);
            leftMouseButton.CheckedState.InnerColor = Color.FromArgb(178, 120, 250);
            leftMouseButton.Location = new Point(165, 101);
            leftMouseButton.Name = "leftMouseButton";
            leftMouseButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            leftMouseButton.Size = new Size(15, 15);
            leftMouseButton.TabIndex = 10;
            leftMouseButton.Text = "Some text";
            leftMouseButton.UncheckedState.BorderColor = Color.DarkGray;
            leftMouseButton.UncheckedState.BorderThickness = 1;
            leftMouseButton.UncheckedState.FillColor = Color.Transparent;
            leftMouseButton.UncheckedState.InnerColor = Color.Transparent;
            // 
            // labelLMB
            // 
            labelLMB.AutoSize = true;
            labelLMB.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLMB.ForeColor = Color.White;
            labelLMB.Location = new Point(181, 100);
            labelLMB.Name = "labelLMB";
            labelLMB.Size = new Size(68, 16);
            labelLMB.TabIndex = 11;
            labelLMB.Text = "Left Mouse";
            // 
            // labelRMB
            // 
            labelRMB.AutoSize = true;
            labelRMB.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelRMB.ForeColor = Color.White;
            labelRMB.Location = new Point(268, 100);
            labelRMB.Name = "labelRMB";
            labelRMB.Size = new Size(77, 16);
            labelRMB.TabIndex = 13;
            labelRMB.Text = "Right Mouse";
            // 
            // rightMouseButton
            // 
            rightMouseButton.CheckedState.BorderColor = Color.FromArgb(66, 16, 130);
            rightMouseButton.CheckedState.BorderThickness = 0;
            rightMouseButton.CheckedState.FillColor = Color.FromArgb(96, 32, 176);
            rightMouseButton.CheckedState.InnerColor = Color.FromArgb(178, 120, 250);
            rightMouseButton.Location = new Point(252, 101);
            rightMouseButton.Name = "rightMouseButton";
            rightMouseButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            rightMouseButton.Size = new Size(15, 15);
            rightMouseButton.TabIndex = 12;
            rightMouseButton.Text = "Some text";
            rightMouseButton.UncheckedState.BorderColor = Color.DarkGray;
            rightMouseButton.UncheckedState.BorderThickness = 1;
            rightMouseButton.UncheckedState.FillColor = Color.Transparent;
            rightMouseButton.UncheckedState.InnerColor = Color.Transparent;
            // 
            // homeStatusLabel
            // 
            homeStatusLabel.AutoSize = true;
            homeStatusLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeStatusLabel.ForeColor = Color.White;
            homeStatusLabel.Location = new Point(165, 212);
            homeStatusLabel.Name = "homeStatusLabel";
            homeStatusLabel.Size = new Size(55, 16);
            homeStatusLabel.TabIndex = 14;
            homeStatusLabel.Text = "STATUS:";
            // 
            // homeStatus
            // 
            homeStatus.AutoSize = true;
            homeStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeStatus.ForeColor = Color.FromArgb(177, 14, 18);
            homeStatus.Location = new Point(216, 212);
            homeStatus.Name = "homeStatus";
            homeStatus.Size = new Size(61, 16);
            homeStatus.TabIndex = 15;
            homeStatus.Text = "STOPPED";
            // 
            // Autoclick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            ClientSize = new Size(490, 230);
            Controls.Add(homeStatusLabel);
            Controls.Add(homeStatus);
            Controls.Add(labelRMB);
            Controls.Add(rightMouseButton);
            Controls.Add(labelLMB);
            Controls.Add(leftMouseButton);
            Controls.Add(panelSidebar);
            Controls.Add(noValueLabel);
            Controls.Add(topBorder);
            Controls.Add(milliText);
            Controls.Add(millisecondLabel);
            Controls.Add(versionLabel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
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

        private TextBox milliText;
        private Button startButton;
        private Button stopButton;
        private Label versionLabel;
        private Label millisecondLabel;
        private Panel topBorder;
        private Button closeButton;
        private Label titleLabel;
        private Label noValueLabel;
        private Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button homeTab;
        private Guna.UI2.WinForms.Guna2Button aboutTab;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton leftMouseButton;
        private Label labelLMB;
        private Label labelRMB;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rightMouseButton;
        private Label homeStatusLabel;
        private Label homeStatus;
    }
}