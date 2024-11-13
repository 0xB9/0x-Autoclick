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
            topBorder.SuspendLayout();
            SuspendLayout();
            // 
            // milliText
            // 
            milliText.BackColor = Color.FromArgb(66, 16, 130);
            milliText.BorderStyle = BorderStyle.None;
            milliText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            milliText.ForeColor = Color.White;
            milliText.Location = new Point(296, 57);
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
            startButton.Font = new Font("Antraste", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(296, 120);
            startButton.Name = "startButton";
            startButton.Size = new Size(173, 30);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.FlatAppearance.BorderColor = Color.FromArgb(27, 8, 51);
            stopButton.FlatAppearance.BorderSize = 2;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Antraste", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            stopButton.ForeColor = Color.White;
            stopButton.Location = new Point(296, 158);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(173, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Century Gothic", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.White;
            versionLabel.Location = new Point(161, 215);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(43, 13);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "v2.0.0-b";
            // 
            // millisecondLabel
            // 
            millisecondLabel.AutoSize = true;
            millisecondLabel.Font = new Font("Antraste", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            millisecondLabel.ForeColor = Color.White;
            millisecondLabel.Location = new Point(296, 42);
            millisecondLabel.Name = "millisecondLabel";
            millisecondLabel.Size = new Size(98, 14);
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
            titleLabel.Font = new Font("Antraste", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(3, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(96, 17);
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
            leftMouseButton.Font = new Font("Antraste", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            leftMouseButton.ForeColor = Color.White;
            leftMouseButton.Location = new Point(296, 95);
            leftMouseButton.Name = "leftMouseButton";
            leftMouseButton.Size = new Size(83, 16);
            leftMouseButton.TabIndex = 6;
            leftMouseButton.TabStop = true;
            leftMouseButton.Text = "Left Mouse";
            leftMouseButton.UseVisualStyleBackColor = true;
            // 
            // rightMouseButton
            // 
            rightMouseButton.AutoSize = true;
            rightMouseButton.FlatStyle = FlatStyle.Flat;
            rightMouseButton.Font = new Font("Antraste", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            rightMouseButton.ForeColor = Color.White;
            rightMouseButton.Location = new Point(385, 95);
            rightMouseButton.Name = "rightMouseButton";
            rightMouseButton.Size = new Size(88, 16);
            rightMouseButton.TabIndex = 7;
            rightMouseButton.Text = "Right Mouse";
            rightMouseButton.UseVisualStyleBackColor = true;
            // 
            // noValueLabel
            // 
            noValueLabel.AutoSize = true;
            noValueLabel.Font = new Font("Antraste", 8F, FontStyle.Regular, GraphicsUnit.Point);
            noValueLabel.ForeColor = Color.FromArgb(177, 14, 18);
            noValueLabel.Location = new Point(297, 79);
            noValueLabel.Name = "noValueLabel";
            noValueLabel.Size = new Size(109, 14);
            noValueLabel.TabIndex = 8;
            noValueLabel.Text = "Enter a value!";
            noValueLabel.Visible = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 8, 51);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 30);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(159, 200);
            panelSidebar.TabIndex = 9;
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
    }
}