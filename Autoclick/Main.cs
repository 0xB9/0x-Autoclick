using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Autoclick
{
    public partial class Autoclick : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        private System.Windows.Forms.Timer autoclickTimer;

        public Autoclick()
        {
            InitializeComponent();
            autoclickTimer = new System.Windows.Forms.Timer();
            autoclickTimer.Tick += new EventHandler(AutoClick);
        }

        // Start auto-clicking
        private void startButton_Click(object sender, EventArgs e)
        {
            int delay;
            if (int.TryParse(milliText.Text, out delay) && delay > 0)
            {
                autoclickTimer.Interval = delay;
                autoclickTimer.Start();

                // Hide label after value is added
                noValueLabel.Visible = false;
                // Move radio buttons back to original location
                leftMouseButton.Location = new Point(165, 86);
                rightMouseButton.Location = new Point(252, 86);
                labelLMB.Location = new Point(181, 85);
                labelRMB.Location = new Point(268, 85);
                // Change status
                homeStatus.ForeColor = Color.FromArgb(13, 92, 25);
                homeStatus.Text = "RUNNING...";
            }
            else
            {
                // Show error label when there is no value
                noValueLabel.Visible = true;
                // Move radio buttons below error label
                leftMouseButton.Location = new Point(165, 101);
                rightMouseButton.Location = new Point(252, 101);
                labelLMB.Location = new Point(181, 100);
                labelRMB.Location = new Point(268, 100);
            }
        }
        // Stop auto-clicking
        private void stopButton_Click(object sender, EventArgs e)
        {
            autoclickTimer.Stop();
            // Change status
            homeStatus.ForeColor = Color.FromArgb(177, 14, 18);
            homeStatus.Text = "STOPPED";
        }
        // Use F7/F8 keys to start/stop auto-clicking
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F7)
            {
                startButton_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.F8)
            {
                stopButton_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AutoClick(object? sender, EventArgs e)
        {
            if (leftMouseButton.Checked)
            {
                // Simulate left mouse clicks
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
            else if (rightMouseButton.Checked)
            {
                // Simulate right mouse clicks
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            }
        }

        // Only allow numbers and backspace
        private void milliText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Move application
        private bool mouseDown;
        private Point lastLocation;
        private void topBorder_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void topBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void topBorder_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Close application
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
