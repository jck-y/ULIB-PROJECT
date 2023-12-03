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
            alamat = "server=localhost; database=dbulib; username=root; password=;";
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
            try
            {
                query = "SELECT * FROM staff WHERE staff_id = @staff_id AND staff_pass = @staff_pass";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@staff_id", emailtxtbox.Text);
                perintah.Parameters.AddWithValue("@staff_pass", passtxtbox.Text);
                ds.Clear();
                koneksi.Open();
                adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["staff_pass"].ToString();
                        if (sandi == passtxtbox.Text)
                        {
                            header form1 = new header();
                            form1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Login gagal. Periksa username dan password Anda.", "Login Gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan koneksi database: " + ex.Message, "Kesalahan");
            }
            finally
            {
                koneksi.Close();
            }

        }
        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void passtxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            passtxtbox.UseSystemPasswordChar = true;
        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {
    
        }




    }
}