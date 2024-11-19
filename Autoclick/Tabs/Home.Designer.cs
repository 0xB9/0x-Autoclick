﻿namespace Autoclick.Tabs
{
    partial class Home
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            homeStatusLabel = new Label();
            homeStatus = new Label();
            labelRMB = new Label();
            rightMouseButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            labelLMB = new Label();
            leftMouseButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            noValueLabel = new Label();
            milliText = new TextBox();
            millisecondLabel = new Label();
            stopButton = new Button();
            startButton = new Button();
            SuspendLayout();
            // 
            // homeStatusLabel
            // 
            homeStatusLabel.AutoSize = true;
            homeStatusLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeStatusLabel.ForeColor = Color.White;
            homeStatusLabel.Location = new Point(8, 177);
            homeStatusLabel.Name = "homeStatusLabel";
            homeStatusLabel.Size = new Size(55, 16);
            homeStatusLabel.TabIndex = 25;
            homeStatusLabel.Text = "STATUS:";
            // 
            // homeStatus
            // 
            homeStatus.AutoSize = true;
            homeStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeStatus.ForeColor = Color.FromArgb(177, 14, 18);
            homeStatus.Location = new Point(59, 177);
            homeStatus.Name = "homeStatus";
            homeStatus.Size = new Size(61, 16);
            homeStatus.TabIndex = 26;
            homeStatus.Text = "STOPPED";
            // 
            // labelRMB
            // 
            labelRMB.AutoSize = true;
            labelRMB.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelRMB.ForeColor = Color.White;
            labelRMB.Location = new Point(111, 54);
            labelRMB.Name = "labelRMB";
            labelRMB.Size = new Size(77, 16);
            labelRMB.TabIndex = 24;
            labelRMB.Text = "Right Mouse";
            // 
            // rightMouseButton
            // 
            rightMouseButton.CheckedState.BorderColor = Color.FromArgb(66, 16, 130);
            rightMouseButton.CheckedState.BorderThickness = 0;
            rightMouseButton.CheckedState.FillColor = Color.FromArgb(96, 32, 176);
            rightMouseButton.CheckedState.InnerColor = Color.FromArgb(178, 120, 250);
            rightMouseButton.Location = new Point(95, 55);
            rightMouseButton.Name = "rightMouseButton";
            rightMouseButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            rightMouseButton.Size = new Size(15, 15);
            rightMouseButton.TabIndex = 23;
            rightMouseButton.Text = "Some text";
            rightMouseButton.UncheckedState.BorderColor = Color.DarkGray;
            rightMouseButton.UncheckedState.BorderThickness = 1;
            rightMouseButton.UncheckedState.FillColor = Color.Transparent;
            rightMouseButton.UncheckedState.InnerColor = Color.Transparent;
            // 
            // labelLMB
            // 
            labelLMB.AutoSize = true;
            labelLMB.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLMB.ForeColor = Color.White;
            labelLMB.Location = new Point(24, 54);
            labelLMB.Name = "labelLMB";
            labelLMB.Size = new Size(68, 16);
            labelLMB.TabIndex = 22;
            labelLMB.Text = "Left Mouse";
            // 
            // leftMouseButton
            // 
            leftMouseButton.Checked = true;
            leftMouseButton.CheckedState.BorderColor = Color.FromArgb(66, 16, 130);
            leftMouseButton.CheckedState.BorderThickness = 0;
            leftMouseButton.CheckedState.FillColor = Color.FromArgb(96, 32, 176);
            leftMouseButton.CheckedState.InnerColor = Color.FromArgb(178, 120, 250);
            leftMouseButton.Location = new Point(8, 55);
            leftMouseButton.Name = "leftMouseButton";
            leftMouseButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            leftMouseButton.Size = new Size(15, 15);
            leftMouseButton.TabIndex = 21;
            leftMouseButton.Text = "Some text";
            leftMouseButton.UncheckedState.BorderColor = Color.DarkGray;
            leftMouseButton.UncheckedState.BorderThickness = 1;
            leftMouseButton.UncheckedState.FillColor = Color.Transparent;
            leftMouseButton.UncheckedState.InnerColor = Color.Transparent;
            // 
            // noValueLabel
            // 
            noValueLabel.AutoSize = true;
            noValueLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            noValueLabel.ForeColor = Color.FromArgb(177, 14, 18);
            noValueLabel.Location = new Point(11, 49);
            noValueLabel.Name = "noValueLabel";
            noValueLabel.Size = new Size(169, 16);
            noValueLabel.TabIndex = 20;
            noValueLabel.Text = "Enter a value greater than 0!";
            noValueLabel.Visible = false;
            // 
            // milliText
            // 
            milliText.BackColor = Color.FromArgb(66, 16, 130);
            milliText.BorderStyle = BorderStyle.None;
            milliText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            milliText.ForeColor = Color.White;
            milliText.Location = new Point(10, 26);
            milliText.Multiline = true;
            milliText.Name = "milliText";
            milliText.PlaceholderText = "3000";
            milliText.Size = new Size(173, 21);
            milliText.TabIndex = 18;
            // 
            // millisecondLabel
            // 
            millisecondLabel.AutoSize = true;
            millisecondLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            millisecondLabel.ForeColor = Color.White;
            millisecondLabel.Location = new Point(10, 8);
            millisecondLabel.Name = "millisecondLabel";
            millisecondLabel.Size = new Size(88, 16);
            millisecondLabel.TabIndex = 16;
            millisecondLabel.Text = "Milliseconds";
            // 
            // stopButton
            // 
            stopButton.FlatAppearance.BorderColor = Color.FromArgb(27, 8, 51);
            stopButton.FlatAppearance.BorderSize = 2;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stopButton.ForeColor = Color.White;
            stopButton.Location = new Point(195, 49);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(129, 30);
            stopButton.TabIndex = 19;
            stopButton.Text = "STOP (F8)";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += new System.EventHandler(stopButton_Click);
            // 
            // startButton
            // 
            startButton.FlatAppearance.BorderColor = Color.FromArgb(27, 8, 51);
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(195, 11);
            startButton.Name = "startButton";
            startButton.Size = new Size(129, 30);
            startButton.TabIndex = 17;
            startButton.Text = "START (F7)";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += new System.EventHandler(startButton_Click);
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(40, 9, 79);
            Controls.Add(homeStatusLabel);
            Controls.Add(homeStatus);
            Controls.Add(labelRMB);
            Controls.Add(rightMouseButton);
            Controls.Add(labelLMB);
            Controls.Add(leftMouseButton);
            Controls.Add(noValueLabel);
            Controls.Add(milliText);
            Controls.Add(millisecondLabel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Name = "Home";
            Size = new Size(332, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label homeStatusLabel;
        private Label homeStatus;
        private Label labelRMB;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rightMouseButton;
        private Label labelLMB;
        private Guna.UI2.WinForms.Guna2CustomRadioButton leftMouseButton;
        private Label noValueLabel;
        private TextBox milliText;
        private Label millisecondLabel;
        private Button stopButton;
        private Button startButton;
    }
}
