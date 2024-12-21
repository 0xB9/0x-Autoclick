using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclick.Tabs
{
    public partial class Home : UserControl
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int WM_HOTKEY = 0x0312;
        private const int HOTKEY_START = 1;
        private const int HOTKEY_STOP = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        private System.Windows.Forms.Timer autoclickTimer;
        public Home()
        {
            InitializeComponent();
            autoclickTimer = new System.Windows.Forms.Timer();
            autoclickTimer.Tick += new EventHandler(AutoClick);

            // Register hotkeys
            this.Load += Home_Load;
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
                leftMouseButton.Location = new Point(8, 55);
                rightMouseButton.Location = new Point(95, 55);
                labelLMB.Location = new Point(24, 54);
                labelRMB.Location = new Point(111, 54);

                // Change status
                homeStatus.ForeColor = Color.FromArgb(13, 92, 25);
                homeStatus.Text = "RUNNING...";
            }
            else
            {
                // Show error label when there is no value
                noValueLabel.Visible = true;

                // Move radio buttons below error label
                leftMouseButton.Location = new Point(8, 67);
                rightMouseButton.Location = new Point(95, 67);
                labelLMB.Location = new Point(24, 66);
                labelRMB.Location = new Point(111, 66);
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

        // Register hotkeys
        private void Home_Load(object? sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, HOTKEY_START, 0, (uint)Keys.F7);
            RegisterHotKey(this.Handle, HOTKEY_STOP, 0, (uint)Keys.F8);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (this.ParentForm != null)
            {
                this.ParentForm.FormClosing += ParentForm_FormClosing;
            }
        }

        // Use F7/F8 keys to start/stop auto-clicking
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                if (id == HOTKEY_START)
                {
                    startButton_Click(this, EventArgs.Empty);
                }
                else if (id == HOTKEY_STOP)
                {
                    stopButton_Click(this, EventArgs.Empty);
                }
            }
        }

        // Unregister hotkeys
        private void ParentForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_START);
            UnregisterHotKey(this.Handle, HOTKEY_STOP);

            if (this.ParentForm != null)
            {
                this.ParentForm.FormClosing -= ParentForm_FormClosing;
            }
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
    }
}
