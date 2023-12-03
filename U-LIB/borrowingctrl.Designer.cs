namespace U_LIB
{
    partial class borrowingctrl
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
            this.nimtxtbox = new System.Windows.Forms.TextBox();
            this.nimtxt = new System.Windows.Forms.Label();
            this.tglpinjamtxtbox = new System.Windows.Forms.TextBox();
            this.idbukutxtbox = new System.Windows.Forms.TextBox();
            this.idpinjamtxtbox = new System.Windows.Forms.TextBox();
            this.bukutxt = new System.Windows.Forms.Label();
            this.tglpinjamtxt = new System.Windows.Forms.Label();
            this.peminjamantxt = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.tglkembalitxt = new System.Windows.Forms.Label();
            this.tglkembalitxtbox = new System.Windows.Forms.TextBox();
            this.jumlahtxtbox = new System.Windows.Forms.TextBox();
            this.jumlahtxt = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.databorrowing = new System.Windows.Forms.DataGridView();
            this.searchtbn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databorrowing)).BeginInit();
            this.SuspendLayout();
            // 
            // nimtxtbox
            // 
            this.nimtxtbox.Location = new System.Drawing.Point(438, 52);
            this.nimtxtbox.Name = "nimtxtbox";
            this.nimtxtbox.Size = new System.Drawing.Size(151, 26);
            this.nimtxtbox.TabIndex = 21;
            this.nimtxtbox.TextChanged += new System.EventHandler(this.nimtxtbox_TextChanged);
            // 
            // nimtxt
            // 
            this.nimtxt.AutoSize = true;
            this.nimtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimtxt.Location = new System.Drawing.Point(484, 22);
            this.nimtxt.Name = "nimtxt";
            this.nimtxt.Size = new System.Drawing.Size(50, 25);
            this.nimtxt.TabIndex = 20;
            this.nimtxt.Text = "NIM";
            // 
            // tglpinjamtxtbox
            // 
            this.tglpinjamtxtbox.Location = new System.Drawing.Point(36, 131);
            this.tglpinjamtxtbox.Name = "tglpinjamtxtbox";
            this.tglpinjamtxtbox.Size = new System.Drawing.Size(162, 26);
            this.tglpinjamtxtbox.TabIndex = 18;
            this.tglpinjamtxtbox.TextChanged += new System.EventHandler(this.tglpinjamtxtbox_TextChanged);
            // 
            // idbukutxtbox
            // 
            this.idbukutxtbox.Location = new System.Drawing.Point(242, 52);
            this.idbukutxtbox.Name = "idbukutxtbox";
            this.idbukutxtbox.Size = new System.Drawing.Size(158, 26);
            this.idbukutxtbox.TabIndex = 17;
            this.idbukutxtbox.TextChanged += new System.EventHandler(this.idbukutxtbox_TextChanged);
            // 
            // idpinjamtxtbox
            // 
            this.idpinjamtxtbox.Location = new System.Drawing.Point(38, 52);
            this.idpinjamtxtbox.Name = "idpinjamtxtbox";
            this.idpinjamtxtbox.Size = new System.Drawing.Size(160, 26);
            this.idpinjamtxtbox.TabIndex = 16;
            this.idpinjamtxtbox.TextChanged += new System.EventHandler(this.idpinjamtxtbox_TextChanged);
            // 
            // bukutxt
            // 
            this.bukutxt.AutoSize = true;
            this.bukutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bukutxt.Location = new System.Drawing.Point(276, 20);
            this.bukutxt.Name = "bukutxt";
            this.bukutxt.Size = new System.Drawing.Size(87, 25);
            this.bukutxt.TabIndex = 15;
            this.bukutxt.Text = "ID Buku";
            // 
            // tglpinjamtxt
            // 
            this.tglpinjamtxt.AutoSize = true;
            this.tglpinjamtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglpinjamtxt.Location = new System.Drawing.Point(33, 102);
            this.tglpinjamtxt.Name = "tglpinjamtxt";
            this.tglpinjamtxt.Size = new System.Drawing.Size(161, 25);
            this.tglpinjamtxt.TabIndex = 13;
            this.tglpinjamtxt.Text = "Tanggal Pinjam";
            // 
            // peminjamantxt
            // 
            this.peminjamantxt.AutoSize = true;
            this.peminjamantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peminjamantxt.Location = new System.Drawing.Point(39, 22);
            this.peminjamantxt.Name = "peminjamantxt";
            this.peminjamantxt.Size = new System.Drawing.Size(156, 25);
            this.peminjamantxt.TabIndex = 12;
            this.peminjamantxt.Text = "ID Peminjaman";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Yellow;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Save.Location = new System.Drawing.Point(234, 425);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 49);
            this.Save.TabIndex = 24;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tglkembalitxt
            // 
            this.tglkembalitxt.AutoSize = true;
            this.tglkembalitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglkembalitxt.Location = new System.Drawing.Point(237, 102);
            this.tglkembalitxt.Name = "tglkembalitxt";
            this.tglkembalitxt.Size = new System.Drawing.Size(173, 25);
            this.tglkembalitxt.TabIndex = 14;
            this.tglkembalitxt.Text = "Tanggal Kembali";
            // 
            // tglkembalitxtbox
            // 
            this.tglkembalitxtbox.Location = new System.Drawing.Point(242, 131);
            this.tglkembalitxtbox.Name = "tglkembalitxtbox";
            this.tglkembalitxtbox.Size = new System.Drawing.Size(158, 26);
            this.tglkembalitxtbox.TabIndex = 19;
            this.tglkembalitxtbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // jumlahtxtbox
            // 
            this.jumlahtxtbox.Location = new System.Drawing.Point(438, 131);
            this.jumlahtxtbox.Name = "jumlahtxtbox";
            this.jumlahtxtbox.Size = new System.Drawing.Size(158, 26);
            this.jumlahtxtbox.TabIndex = 27;
            this.jumlahtxtbox.TextChanged += new System.EventHandler(this.jumlahtxtbox_TextChanged);
            // 
            // jumlahtxt
            // 
            this.jumlahtxt.AutoSize = true;
            this.jumlahtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahtxt.Location = new System.Drawing.Point(416, 98);
            this.jumlahtxt.Name = "jumlahtxt";
            this.jumlahtxt.Size = new System.Drawing.Size(205, 25);
            this.jumlahtxt.TabIndex = 26;
            this.jumlahtxt.Text = "Jumlah Peminjaman";
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(350, 425);
            this.delbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(118, 49);
            this.delbtn.TabIndex = 32;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // databorrowing
            // 
            this.databorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databorrowing.Location = new System.Drawing.Point(36, 197);
            this.databorrowing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databorrowing.Name = "databorrowing";
            this.databorrowing.RowHeadersWidth = 62;
            this.databorrowing.Size = new System.Drawing.Size(738, 203);
            this.databorrowing.TabIndex = 33;
            // 
            // searchtbn
            // 
            this.searchtbn.Location = new System.Drawing.Point(480, 425);
            this.searchtbn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtbn.Name = "searchtbn";
            this.searchtbn.Size = new System.Drawing.Size(118, 49);
            this.searchtbn.TabIndex = 34;
            this.searchtbn.Text = "Search";
            this.searchtbn.UseVisualStyleBackColor = true;
            this.searchtbn.Click += new System.EventHandler(this.searchtbn_Click);
            // 
            // borrowingctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchtbn);
            this.Controls.Add(this.databorrowing);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.jumlahtxtbox);
            this.Controls.Add(this.jumlahtxt);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.nimtxtbox);
            this.Controls.Add(this.nimtxt);
            this.Controls.Add(this.tglkembalitxtbox);
            this.Controls.Add(this.tglpinjamtxtbox);
            this.Controls.Add(this.idbukutxtbox);
            this.Controls.Add(this.idpinjamtxtbox);
            this.Controls.Add(this.bukutxt);
            this.Controls.Add(this.tglkembalitxt);
            this.Controls.Add(this.tglpinjamtxt);
            this.Controls.Add(this.peminjamantxt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "borrowingctrl";
            this.Size = new System.Drawing.Size(842, 497);
            this.Load += new System.EventHandler(this.borrowingctrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databorrowing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nimtxtbox;
        private System.Windows.Forms.Label nimtxt;
        private System.Windows.Forms.TextBox tglpinjamtxtbox;
        private System.Windows.Forms.TextBox idbukutxtbox;
        private System.Windows.Forms.TextBox idpinjamtxtbox;
        private System.Windows.Forms.Label bukutxt;
        private System.Windows.Forms.Label tglpinjamtxt;
        private System.Windows.Forms.Label peminjamantxt;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label tglkembalitxt;
        private System.Windows.Forms.TextBox tglkembalitxtbox;
        private System.Windows.Forms.TextBox jumlahtxtbox;
        private System.Windows.Forms.Label jumlahtxt;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.DataGridView databorrowing;
        private System.Windows.Forms.Button searchtbn;
    }
}
