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

        }
    }
}
