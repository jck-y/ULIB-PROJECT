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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        private void submitbutton_Click(object sender, EventArgs e)
        {
            string username = emailtxtbox.Text;
            string password = passtxtbox.Text;

            if (username == "user" && password == "user")
            {
                // Jika username dan password benar, buka halaman home
                header form1 = new header();
                form1.Show();
                this.Hide();
            }
            else
            {
                // Jika username atau password salah, tampilkan pesan kesalahan
                MessageBox.Show("Username atau password salah. Silakan coba lagi.", "Kesalahan");
            }
        }

        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            passtxtbox.PasswordChar = "X"
        }

        private void unklabloginpict_Click(object sender, EventArgs e)
        {

        }

        private void loginsubpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
    }
}
