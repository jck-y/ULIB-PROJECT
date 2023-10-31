using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U_LIB
{
    public partial class header : System.Windows.Forms.Form
    {
        public header()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Menutup aplikasi
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Maximize jendela
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Unmaximize jendela
                this.WindowState = FormWindowState.Normal;
            }
        }
//.

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlContent1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.Height = btnHome.Height;
            btnHome.Top = btnHome.Top;
            pnlProfile.Visible = false;
            pnlAbout.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.Height = btnProfile.Height;
            btnProfile.Top = btnProfile.Top;
            pnlProfile.Visible = true;
            pnlAbout.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            btnAbout.Height = btnProfile.Height;
            btnAbout.Top = btnProfile.Top;
            pnlProfile.Visible = false;
            pnlAbout.Visible = true;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnCategory.Height = btnCategory.Height;
            btnCategory.Top = btnCategory.Top;
            pnlProfile.Visible = false;
            pnlAbout.Visible = false;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            btnBorrow.Height = btnBorrow.Height;
            btnBorrow.Top = btnBorrow.Top;
            pnlProfile.Visible = false;
            pnlAbout.Visible = false;
        }
    }
}
