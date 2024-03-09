using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Autoclick
{
    public partial class Autoclick : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        private System.Windows.Forms.Timer autoclickTimer;

        public Autoclick()
        {
            InitializeComponent();
            autoclickTimer = new System.Windows.Forms.Timer();
            autoclickTimer.Tick += new EventHandler(AutoClick);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int delay;
            if (int.TryParse(milliText.Text, out delay))
            {
                // Start auto-clicking with the specified delay
                autoclickTimer.Interval = delay;
                autoclickTimer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid delay value.");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // Stop auto-clicking
            autoclickTimer.Stop();
        }

        private void AutoClick(object sender, EventArgs e)
        {
            // Simulate right mouse button down
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            // Simulate right mouse button up
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
