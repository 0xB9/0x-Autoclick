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
            milliText = new TextBox();
            startButton = new Button();
            stopButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // milliText
            // 
            milliText.Location = new Point(12, 23);
            milliText.Name = "milliText";
            milliText.Size = new Size(173, 23);
            milliText.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 64);
            startButton.Name = "startButton";
            startButton.Size = new Size(173, 30);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(12, 102);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(173, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 163);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "v0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Milliseconds";
            // 
            // Autoclick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(197, 178);
            Controls.Add(milliText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Name = "Autoclick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autoclick";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox milliText;
        private Button startButton;
        private Button stopButton;
        private Label label1;
        private Label label2;
    }
}