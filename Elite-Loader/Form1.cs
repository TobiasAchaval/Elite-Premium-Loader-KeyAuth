using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using spacey.Auth;
using System.IO;
using static Guna.UI2.WinForms.Suite.Descriptions;


namespace spacey
{
    public partial class Form1 : Form


    {

        public static api KeyAuthApp = new api(
            name: "FiveM1", // Application Name
            ownerid: "PwBTV43ofz", // Owner ID
            secret: "226b407f71d9c16679b3c42401bcb21a2f651375df726c7f247b6b325fd21272", // Application Secret
            version: "1.0" // Application Version /*
                           //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
        );


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }


        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private const string LoginDetailsFilePath = "C:\\ElitePremiumExternal\\login.txt";

        private void LoadLoginDetails()
        {
            if (File.Exists(LoginDetailsFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(LoginDetailsFilePath);
                    if (lines.Length == 2)
                    {
                        userTxt.Text = lines[0];
                        psdTxt.Text = lines[1];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading login details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
            this.Opacity = 0.9;
            erTxt.Text = ""; // Hides Error Text
            LoadLoginDetails();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regB_Click(object sender, EventArgs e)
        {
            Thread regThread = new Thread(() =>
            {
                Reg rg = new Reg();
                rg.Location = this.Location;
                rg.StartPosition = FormStartPosition.Manual;
                rg.ShowDialog();
            });

            regThread.Start();
            this.Hide();
        }

        private void SaveLoginDetails(string username, string password)
        {
            try
            {
                // Check if the checkbox is checked
                if (guna2CheckBox1.Checked)
                {
                    File.WriteAllText(LoginDetailsFilePath, $"{username}\n{password}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving login details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TryLogin(string username, string password)
        {
            Task.Run(() =>
            {
                KeyAuthApp.login(username, password);
            }).ContinueWith((task) =>
            {
                if (KeyAuthApp.response.success)
                {
                    // Save login details
                    SaveLoginDetails(username, password);

                    // Update UI controls on the UI thread
                    this.Invoke(new Action(() =>
                    {
                        Dashboard dhb = new Dashboard();
                        dhb.Show();
                        this.Hide();
                    }));
                }
                else
                {
                    // Update UI controls on the UI thread
                    this.Invoke(new Action(() =>
                    {
                        erTxt.Text = KeyAuthApp.response.message;
                    }));
                }
            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text == "" || psdTxt.Text == "")
            {
                erTxt.Text = "Please fill out all fields.";
            }

            if (userTxt.Text != "" || psdTxt.Text != "")
            {
                Task.Run(() =>
                {
                    KeyAuthApp.login(userTxt.Text, psdTxt.Text);
                }).ContinueWith((task) =>
                {
                    if (KeyAuthApp.response.success)
                    {
                        // Save login details
                        SaveLoginDetails(userTxt.Text, psdTxt.Text);

                        // Update UI controls on the UI thread
                        this.Invoke(new Action(() =>
                        {
                            Dashboard dhb = new Dashboard();
                            dhb.Show();
                            this.Hide();
                        }));
                    }
                    else
                    {
                        // Update UI controls on the UI thread
                        this.Invoke(new Action(() =>
                        {
                            erTxt.Text = KeyAuthApp.response.message;
                        }));
                    }
                });
            }

        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (erTxt.Text != "")
            {
                erTxt.Text = "";
            }
        }
    }
}
