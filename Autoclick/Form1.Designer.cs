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
            label1 = new Label();
            label2 = new Label();
            topBorder = new Panel();
            closeButton = new Button();
            topBorder.SuspendLayout();
            SuspendLayout();
            // 
            // milliText
            // 
            milliText.Location = new Point(12, 50);
            milliText.Name = "milliText";
            milliText.PlaceholderText = "3000";
            milliText.Size = new Size(173, 23);
            milliText.TabIndex = 0;
            milliText.Text = "800";
            // 
            // startButton
            // 
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
            stopButton.Location = new Point(12, 129);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(173, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 164);
            label1.Name = "label1";
            label1.Size = new Size(36, 13);
            label1.TabIndex = 3;
            label1.Text = "v0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Milliseconds";
            // 
            // topBorder
            // 
            topBorder.BackColor = Color.FromArgb(27, 8, 51);
            topBorder.Controls.Add(closeButton);
            topBorder.Dock = DockStyle.Top;
            topBorder.Location = new Point(0, 0);
            topBorder.Name = "topBorder";
            topBorder.Size = new Size(197, 30);
            topBorder.TabIndex = 5;
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Autoclick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autoclick";
            topBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox milliText;
        private Button startButton;
        private Button stopButton;
        private Label label1;
        private Label label2;
        private Panel topBorder;
        private Button closeButton;
    }
}