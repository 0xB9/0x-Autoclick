using Autoclick.Tabs;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Autoclick
{
    public partial class Autoclick : Form
    {
        public Autoclick()
        {
            InitializeComponent();
            Home uc = new Home();
            addTabs(uc);
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

        private void addTabs(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void aboutTab_Click(object sender, EventArgs e)
        {
            About uc = new About();
            addTabs(uc);
        }

        private void homeTab_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addTabs(uc);
        }
    }
}
