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

        // Start auto-clicking with the specified delay
        private void startButton_Click(object sender, EventArgs e)
        {
            int delay;
            if (int.TryParse(milliText.Text, out delay))
            {
                autoclickTimer.Interval = delay;
                autoclickTimer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid delay value.");
            }
        }

        // Stop auto-clicking
        private void stopButton_Click(object sender, EventArgs e)
        {
            autoclickTimer.Stop();
        }

        private void AutoClick(object sender, EventArgs e)
        {
            if (leftMouseButton.Checked)
            {
                // Simulate left mouse button down
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                // Simulate left mouse button up
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
            else if (rightMouseButton.Checked)
            {
                // Simulate right mouse button down
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                // Simulate right mouse button up
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
