using System;
using System.IO;
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
        private string? latestVersion;
        private const string currentVersion = "v2.0.0";
        private const string repoUrl = "https://api.github.com/repos/0xB9/0x-Autoclick/releases/latest";

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
                    FileName = "https://github.com/0xB9/0x-Autoclick",
                    UseShellExecute = true // Ensures URL is opened in default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void openGithubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/0xB9/0x-Autoclick",
                    UseShellExecute = true // Ensures URL is opened in default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reportLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/0xB9/0x-Autoclick/issues",
                    UseShellExecute = true // Ensures URL is opened in default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void checkUpdateButton_Click(object sender, EventArgs e)
        {
            updateLabel.Visible = true;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Add User-Agent required by GitHub API
                    client.DefaultRequestHeaders.Add("User-Agent", "Autoclick App");

                    HttpResponseMessage response = await client.GetAsync(repoUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Parse JSON
                        JsonDocument jsonDocument = JsonDocument.Parse(responseBody);
                        latestVersion = jsonDocument.RootElement.GetProperty("tag_name").GetString();

                        if (latestVersion == currentVersion)
                        {
                            updateLabel.ForeColor = Color.FromArgb(13, 92, 25);
                            updateLabel.Text = "You are up to date!";
                        }
                        else
                        {
                            updateLabel.ForeColor = Color.FromArgb(177, 14, 18);
                            updateLabel.Text = "Autoclick is out of date.";

                            downloadButton.Visible = true;
                            downloadButton.Text = $"Download {latestVersion}";
                        }
                    }
                    else
                    {
                        updateLabel.ForeColor = Color.White;
                        updateLabel.Text = "Failed to check for updates, try again later.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message} \n\nPlease create a bug report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void downloadButton_Click(object sender, EventArgs e)
        {

            string fileUrl = $"https://github.com/0xB9/0x-Autoclick/releases/download/{latestVersion}/0x-Autoclick-{latestVersion}.zip";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Zip Files (*.zip)|*.zip";
                saveFileDialog.FileName = $"0x-Autoclick-{latestVersion}.zip";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;

                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            // Download the file as a byte array
                            byte[] fileBytes = await client.GetByteArrayAsync(fileUrl);
                            // Save the file to the selected location
                            await File.WriteAllBytesAsync(savePath, fileBytes);

                            MessageBox.Show($"Successfully downloaded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
