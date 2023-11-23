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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace U_LIB
{
    public partial class header : System.Windows.Forms.Form
    {
        public header()
        {
            InitializeComponent();

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ucpanel.Controls.Clear();
            ucpanel.Controls.Add(userControl);
            userControl.BringToFront();
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


        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            borrowingctrl uc = new borrowingctrl();
            addUserControl(uc);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profilectrl uc = new profilectrl();
            addUserControl(uc);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutctrl uc = new aboutctrl();
            addUserControl(uc);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            catalogctrl uc = new catalogctrl();
            addUserControl(uc);
        }

        private void pnlOnBtnAbout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAbout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void recomendation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recomendation_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ucpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
