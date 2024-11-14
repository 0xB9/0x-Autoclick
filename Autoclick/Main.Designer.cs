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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            milliText = new TextBox();
            startButton = new Button();
            stopButton = new Button();
            versionLabel = new Label();
            millisecondLabel = new Label();
            topBorder = new Panel();
            titleLabel = new Label();
            closeButton = new Button();
            leftMouseButton = new RadioButton();
            rightMouseButton = new RadioButton();
            noValueLabel = new Label();
            panelSidebar = new Panel();
            aboutTab = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            homeTab = new Guna.UI2.WinForms.Guna2Button();
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
            // leftMouseButton
            // 
            leftMouseButton.AutoSize = true;
            leftMouseButton.Checked = true;
            leftMouseButton.FlatStyle = FlatStyle.Flat;
            leftMouseButton.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            leftMouseButton.ForeColor = Color.White;
            leftMouseButton.Location = new Point(167, 100);
            leftMouseButton.Name = "leftMouseButton";
            leftMouseButton.Size = new Size(81, 19);
            leftMouseButton.TabIndex = 6;
            leftMouseButton.TabStop = true;
            leftMouseButton.Text = "Left Mouse";
            leftMouseButton.UseVisualStyleBackColor = true;
            // 
            // rightMouseButton
            // 
            rightMouseButton.AutoSize = true;
            rightMouseButton.FlatStyle = FlatStyle.Flat;
            rightMouseButton.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rightMouseButton.ForeColor = Color.White;
            rightMouseButton.Location = new Point(256, 100);
            rightMouseButton.Name = "rightMouseButton";
            rightMouseButton.Size = new Size(90, 19);
            rightMouseButton.TabIndex = 7;
            rightMouseButton.Text = "Right Mouse";
            rightMouseButton.UseVisualStyleBackColor = true;
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
            aboutTab.CustomizableEdges = customizableEdges7;
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
            aboutTab.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            guna2Button2.CustomizableEdges = customizableEdges9;
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
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button2.Size = new Size(159, 40);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Tab 2";
            // 
            // homeTab
            // 
            homeTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            homeTab.CheckedState.CustomBorderColor = Color.FromArgb(66, 16, 130);
            homeTab.CheckedState.FillColor = Color.FromArgb(40, 9, 79);
            homeTab.CustomBorderThickness = new Padding(8, 0, 0, 0);
            homeTab.CustomizableEdges = customizableEdges11;
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
            homeTab.ShadowDecoration.CustomizableEdges = customizableEdges12;
            homeTab.Size = new Size(159, 40);
            homeTab.TabIndex = 0;
            homeTab.Text = "Home";
            // 
            // Autoclick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            ClientSize = new Size(490, 230);
            Controls.Add(panelSidebar);
            Controls.Add(noValueLabel);
            Controls.Add(rightMouseButton);
            Controls.Add(leftMouseButton);
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
        private RadioButton leftMouseButton;
        private RadioButton rightMouseButton;
        private Label noValueLabel;
        private Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button homeTab;
        private Guna.UI2.WinForms.Guna2Button aboutTab;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}