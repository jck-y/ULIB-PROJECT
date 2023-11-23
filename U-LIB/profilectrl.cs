using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace U_LIB
{
    public partial class profilectrl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public profilectrl()
        {
            alamat = "server=localhost; database=dbulib; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void profilectrl_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select student_nim, student_name, student_email, faculty from student");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataprofile.DataSource = ds.Tables[0];
                dataprofile.Columns[0].Width = 80;
                dataprofile.Columns[0].HeaderText = "NIM";
                dataprofile.Columns[1].Width = 150;
                dataprofile.Columns[1].HeaderText = "Nama";
                dataprofile.Columns[2].Width = 195;
                dataprofile.Columns[2].HeaderText = "Email";
                dataprofile.Columns[3].Width = 150;
                dataprofile.Columns[3].HeaderText = "Fakultas";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nimtxt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataprofile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
