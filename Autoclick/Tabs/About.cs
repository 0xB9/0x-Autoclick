using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Autoclick.Tabs
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void howToLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/0xB9/Autoclick",
                    UseShellExecute = true // Ensures URL is opened in default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkUpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
