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
    public partial class borrowingctrl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public borrowingctrl()
        {
            alamat = "server=localhost; database=dbulib; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void borrowingctrl_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from peminjaman");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                databorrowing.DataSource = ds.Tables[0];
                databorrowing.Columns[0].Width = 80;
                databorrowing.Columns[0].HeaderText = "NIM";
                databorrowing.Columns[1].Width = 150;
                databorrowing.Columns[1].HeaderText = "Nama";
                databorrowing.Columns[2].Width = 195;
                databorrowing.Columns[2].HeaderText = "Email";
                databorrowing.Columns[3].Width = 150;
                databorrowing.Columns[3].HeaderText = "Fakultas";
                databorrowing.Columns[4].Width = 195;
                databorrowing.Columns[4].HeaderText = "Email";
                databorrowing.Columns[5].Width = 150;
                databorrowing.Columns[5].HeaderText = "Fakultas";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }


        private void idpinjamtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("insert into `peminjaman` (`id_pinjam`, `id_buku`, `tgl_pinjam`, `tgl_kembali`,`student_nim`,`jumlah_buku`) VALUES ('{0}','{1}', '{2}','{3}','{4}','{5}')", idpinjamtxtbox.Text, idbukutxtbox.Text, tglpinjamtxtbox.Text, tglkembalitxtbox.Text, nimtxtbox.Text, jumlahtxtbox.Text);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                    borrowingctrl_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void idbukutxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nimtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tglpinjamtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jumlahtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from peminjaman where id_pinjam = '{0}'", idpinjamtxtbox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
