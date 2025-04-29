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
using Guna.UI2.WinForms;
using spacey.Auth;
using elite.Properties;

namespace spacey
{
    public partial class Dashboard : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

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

        // Two example methods can be used to hide other pages and show one ( you can add more by adding more UserControls )
        public void hs(UserControl a, UserControl b, UserControl c, UserControl d)
        {
            a.Show();
            b.Hide();
            c.Hide();
            d.Hide();

        }

        // Quickly Hide all forms ( you can add more by adding more UserControls )
        public void ha(UserControl a, UserControl b, UserControl c, UserControl d)
        {
            a.Hide();
            b.Hide();
            c.Hide();
            d.Hide();
        }

        public void cm2(Guna2Button a, Guna2Button b, Guna2Button c, Guna2Button d)
        {
            // A is made checked, the rest are made unchecked (Dynamic Toggling)
            a.Checked = true;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
        }

        public Dashboard()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
            this.Opacity = 0.9;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
