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

namespace spacey
{
    public partial class Reg : Form
    {

        public static api KeyAuthApp = new api(
            name: "FiveM1", // Application Name
            ownerid: "PwBTV43ofz", // Owner ID
            secret: "226b407f71d9c16679b3c42401bcb21a2f651375df726c7f247b6b325fd21272", // Application Secret
            version: "1.0"
        );

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
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


        public Reg()
        {
            InitializeComponent();
            KeyAuthApp.init();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
            this.Opacity = 0.9;
            erTxt.Text = "";
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Thread regThread = new Thread(() =>
            {
                Form1 frm = new Form1();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.ShowDialog();
            });
            regThread.Start();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regB_Click(object sender, EventArgs e)
        {
            if (usregTxt.Text == "" || psRegTxt.Text ==  "" || keyregTxt.Text == "")
            {
               erTxt.Text = "Please fill out all fields.";
            }
            if (usregTxt.Text != "" || psRegTxt.Text != "" || keyregTxt.Text != "")
            {
                Task.Run(() =>
                {
                    KeyAuthApp.register(usregTxt.Text, psRegTxt.Text, keyregTxt.Text);
                }).ContinueWith((task) =>
                {
                    if (KeyAuthApp.response.success)
                    {
                        MessageBox.Show($"Welcome, {usregTxt.Text} \nSuccessfully Registered!\nReload The App to Login", "Registered");
                        Thread.Sleep(1500);
                        Application.Exit();
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            erTxt.Text = KeyAuthApp.response.message;
                        }));
                    }
                });
            }
        }
    }
}
