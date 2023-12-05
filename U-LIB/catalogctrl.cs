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
    public partial class catalogctrl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public catalogctrl()
        {

            alamat = "server=localhost; database=dbulib; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void catalogctrl_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from buku");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                DataGridView1.DataSource = ds.Tables[0];
                DataGridView1.Columns[0].Width = 100;
                DataGridView1.Columns[0].HeaderText = "ID Buku";
                DataGridView1.Columns[1].Width = 100;
                DataGridView1.Columns[1].HeaderText = "Judul Buku";
                DataGridView1.Columns[2].Width = 100;
                DataGridView1.Columns[2].HeaderText = "Penulis";
                DataGridView1.Columns[3].Width = 70;
                DataGridView1.Columns[3].HeaderText = "Tahun Terbit";
                DataGridView1.Columns[4].Width = 80;
                DataGridView1.Columns[4].HeaderText = "Harga";
                DataGridView1.Columns[5].Width = 90;
                DataGridView1.Columns[5].HeaderText = "Kategori";
                DataGridView1.Columns[5].Width = 50;
                DataGridView1.Columns[5].HeaderText = "Stock";

                txt_idbuku.Clear();
                txt_harga.Clear();
                txt_judul.Clear();
                txt_penulis.Clear();
                txt_stok.Clear();
                txt_tahun.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("insert into `buku` (`id_buku`, `judul_buku`, `penulis_buku`, `thn_terbit`,`harga_buku`,`stok`) VALUES ('{0}','{1}', '{2}','{3}','{4}','{5}')", txt_idbuku.Text, txt_judul.Text, txt_penulis.Text, txt_tahun.Text,txt_harga.Text, txt_stok.Text);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                    catalogctrl_Load(null, null);
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from buku where id_buku = '{0}'", txt_idbuku.Text);
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

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("UPDATE `buku` SET `id_buku`='[value-1]',`judul_buku`='[value-2]',`penulis_buku`='[value-3]',`thn_terbit`='[value-4]',`harga_buku`='[value-5]',`stok`='[value-7]'", txt_idbuku,txt_judul,txt_penulis,txt_tahun,txt_harga,txt_stok);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();

                catalogctrl_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("SELECT * FROM buku WHERE id_buku = @idBuku"); 
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@idBuku", txt_idbuku.Text); 
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);

                koneksi.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        txt_idbuku.Text = kolom["id_buku"].ToString();
                        txt_judul.Text = kolom["judul_buku"].ToString();
                        txt_penulis.Text = kolom["penulis_buku"].ToString();
                        txt_tahun.Text = kolom["thn_terbit"].ToString();
                        txt_harga.Text = kolom["harga_buku"].ToString();
                        txt_stok.Text = kolom["stok"].ToString();

                        editbtn.Enabled = true;
                        delbtn.Enabled = true;
                    }
                }
                else
                {
                    // Tidak ada hasil ditemukan, mungkin tampilkan pesan ke pengguna
                    MessageBox.Show("Buku tidak ditemukan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_idbuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
