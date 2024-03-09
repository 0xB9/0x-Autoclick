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
            topBorder.SuspendLayout();
            SuspendLayout();
            // 
            // milliText
            // 
            milliText.BackColor = Color.FromArgb(66, 16, 130);
            milliText.BorderStyle = BorderStyle.None;
            milliText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            milliText.ForeColor = Color.White;
            milliText.Location = new Point(12, 50);
            milliText.Multiline = true;
            milliText.Name = "milliText";
            milliText.PlaceholderText = "3000";
            milliText.Size = new Size(173, 21);
            milliText.TabIndex = 0;
            milliText.Text = "800";
            // 
            // startButton
            // 
            startButton.FlatAppearance.BorderColor = Color.FromArgb(27, 8, 51);
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Antraste", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(12, 91);
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
            stopButton.Location = new Point(12, 129);
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
            versionLabel.Font = new Font("Agency FB", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.White;
            versionLabel.Location = new Point(2, 163);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(28, 13);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "v0.0.1";
            // 
            // millisecondLabel
            // 
            millisecondLabel.AutoSize = true;
            millisecondLabel.Font = new Font("Antraste", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            millisecondLabel.ForeColor = Color.White;
            millisecondLabel.Location = new Point(12, 35);
            millisecondLabel.Name = "millisecondLabel";
            millisecondLabel.Size = new Size(98, 14);
            millisecondLabel.TabIndex = 4;
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
            topBorder.Size = new Size(197, 30);
            topBorder.TabIndex = 5;
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
            closeButton.Location = new Point(170, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(26, 30);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Autoclick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 9, 79);
            ClientSize = new Size(197, 178);
            Controls.Add(topBorder);
            Controls.Add(milliText);
            Controls.Add(millisecondLabel);
            Controls.Add(versionLabel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
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
    }
}