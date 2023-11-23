namespace U_LIB
{
    partial class catalogctrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idbuku = new System.Windows.Forms.TextBox();
            this.txt_judul = new System.Windows.Forms.TextBox();
            this.txt_penulis = new System.Windows.Forms.TextBox();
            this.txt_tahun = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(44, 118);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(475, 132);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(122, 270);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(76, 35);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(368, 270);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(76, 35);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(286, 270);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(76, 35);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(204, 270);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(76, 35);
            this.editbtn.TabIndex = 4;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Penulis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tahun Terbit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stok";
            // 
            // txt_idbuku
            // 
            this.txt_idbuku.Location = new System.Drawing.Point(107, 20);
            this.txt_idbuku.Name = "txt_idbuku";
            this.txt_idbuku.Size = new System.Drawing.Size(178, 20);
            this.txt_idbuku.TabIndex = 11;
            // 
            // txt_judul
            // 
            this.txt_judul.Location = new System.Drawing.Point(107, 54);
            this.txt_judul.Name = "txt_judul";
            this.txt_judul.Size = new System.Drawing.Size(178, 20);
            this.txt_judul.TabIndex = 12;
            // 
            // txt_penulis
            // 
            this.txt_penulis.Location = new System.Drawing.Point(107, 83);
            this.txt_penulis.Name = "txt_penulis";
            this.txt_penulis.Size = new System.Drawing.Size(178, 20);
            this.txt_penulis.TabIndex = 13;
            // 
            // txt_tahun
            // 
            this.txt_tahun.Location = new System.Drawing.Point(405, 20);
            this.txt_tahun.Name = "txt_tahun";
            this.txt_tahun.Size = new System.Drawing.Size(93, 20);
            this.txt_tahun.TabIndex = 14;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(405, 54);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(93, 20);
            this.txt_harga.TabIndex = 15;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(405, 83);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(93, 20);
            this.txt_stok.TabIndex = 16;
            // 
            // catalogctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_tahun);
            this.Controls.Add(this.txt_penulis);
            this.Controls.Add(this.txt_judul);
            this.Controls.Add(this.txt_idbuku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.DataGridView1);
            this.Name = "catalogctrl";
            this.Size = new System.Drawing.Size(561, 323);
            this.Load += new System.EventHandler(this.catalogctrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idbuku;
        private System.Windows.Forms.TextBox txt_judul;
        private System.Windows.Forms.TextBox txt_penulis;
        private System.Windows.Forms.TextBox txt_tahun;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_stok;
    }
}
