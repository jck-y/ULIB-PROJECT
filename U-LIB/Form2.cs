using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace U_LIB
{
    public partial class loginForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public loginForm()
        {
            alamat = "server=localhost; database=ulib_login; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passcekbox.Checked)
            {
                passtxtbox.UseSystemPasswordChar = false;
                // Tampilkan karakter password
            }
            else
            {
                passtxtbox.UseSystemPasswordChar = true; // Sembunyikan karakter password (gunakan simbol bintik)
            }
        }



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
            //try
            //{
            //query = "SELECT * FROM users WHERE username = @username AND password = @password";
            //perintah = new MySqlCommand(query, koneksi);
            //perintah.Parameters.AddWithValue("@username", emailtxtbox.Text);
            //perintah.Parameters.AddWithValue("@password", passtxtbox.Text);
            //ds.Clear();
            //koneksi.Open();
            //adapter = new MySqlDataAdapter(perintah);
            //adapter.Fill(ds);
            //koneksi.Close();

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //foreach (DataRow kolom in ds.Tables[0].Rows)
            //{
            //string sandi = kolom["password"].ToString();
            //if (sandi == passtxtbox.Text)
            //{
            //header header = new header();
            //header.Show();
            //this.Hide();
            //}
            //else
            //{
            //MessageBox.Show("Anda salah memasukkan password");
            //}
            //}
            //}
            //else
            //{
            //MessageBox.Show("Login gagal. Periksa username dan password Anda.", "Login Gagal");
            //}
            //}
            //catch (Exception ex)
            //{
            //MessageBox.Show("Kesalahan koneksi database: " + ex.Message, "Kesalahan");
            //}
            //finally
            //{
            //koneksi.Close();
            //}

        }
        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void passtxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {
    
        }




    }
}