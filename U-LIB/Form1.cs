using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
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
        

        private void header_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlOnBtnHome.Height = btnHome.Height;
            pnlOnBtnHome.Top = btnHome.Top;
            pnlHome.Visible = true;
            pnlProfile.Visible = false;
            pnlCategory.Visible = false;
            pnlBorrowing.Visible = false;
            pnlAbout.Visible = false;
        }

        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            pnlOnBtnBorrowing.Height = btnBorrowing.Height;
            pnlOnBtnBorrowing.Top = btnBorrowing.Top;
            pnlHome.Visible = false;
            pnlProfile.Visible = false;
            pnlCategory.Visible = false;
            pnlBorrowing.Visible = true;
            pnlAbout.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlOnBtnProfile.Height = btnProfile.Height;
            pnlOnBtnProfile.Top = btnProfile.Top;
            pnlHome.Visible = false;
            pnlProfile.Visible = true;
            pnlCategory.Visible = false;
            pnlBorrowing.Visible = false;
            pnlAbout.Visible = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pnlOnBtnCategory.Height = btnCategory.Height;
            pnlOnBtnCategory.Top = btnCategory.Top;
            pnlHome.Visible = false;
            pnlProfile.Visible = false;
            pnlCategory.Visible = true;
            pnlBorrowing.Visible = false;
            pnlAbout.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlOnBtnAbout.Height = btnAbout.Height;
            pnlOnBtnAbout.Top = btnAbout.Top;
            pnlHome.Visible = false;
            pnlProfile.Visible = false;
            pnlCategory.Visible = false;
            pnlBorrowing.Visible = false;
            pnlAbout.Visible = true;
        }

        private void pnlOnBtnAbout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAbout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
