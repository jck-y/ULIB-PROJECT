using System;

namespace U_LIB
{
    partial class header
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(header));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.catalogbtn = new System.Windows.Forms.Button();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.pnlOnBtnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlOnBtnAbout = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlOnBtnBorrowing = new System.Windows.Forms.Panel();
            this.btnBorrowing = new System.Windows.Forms.Button();
            this.pnlOnBtnProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtuLib = new System.Windows.Forms.Label();
            this.pnlBtnTop = new System.Windows.Forms.Panel();
            this.ucpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.ukLogo = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.pnlOnBtnAbout.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBtnTop.SuspendLayout();
            this.ucpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ukLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DarkMagenta;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.panel8);
            this.pnlLeft.Controls.Add(this.ukLogo);
            this.pnlLeft.Controls.Add(this.catalogbtn);
            this.pnlLeft.Controls.Add(this.pnlLogout);
            this.pnlLeft.Controls.Add(this.pnlOnBtnAbout);
            this.pnlLeft.Controls.Add(this.btnAbout);
            this.pnlLeft.Controls.Add(this.pnlOnBtnBorrowing);
            this.pnlLeft.Controls.Add(this.btnBorrowing);
            this.pnlLeft.Controls.Add(this.pnlOnBtnProfile);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(133, 370);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Yellow;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(-2, 196);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 31);
            this.panel8.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Yellow;
            this.panel9.Location = new System.Drawing.Point(-63, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 31);
            this.panel9.TabIndex = 12;
            // 
            // catalogbtn
            // 
            this.catalogbtn.FlatAppearance.BorderSize = 0;
            this.catalogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogbtn.ForeColor = System.Drawing.Color.White;
            this.catalogbtn.Location = new System.Drawing.Point(-1, 191);
            this.catalogbtn.Name = "catalogbtn";
            this.catalogbtn.Size = new System.Drawing.Size(133, 41);
            this.catalogbtn.TabIndex = 11;
            this.catalogbtn.Text = "Catalogue";
            this.catalogbtn.UseVisualStyleBackColor = true;
            this.catalogbtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.Yellow;
            this.pnlLogout.Controls.Add(this.pnlOnBtnLogout);
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Location = new System.Drawing.Point(0, 321);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(133, 48);
            this.pnlLogout.TabIndex = 2;
            // 
            // pnlOnBtnLogout
            // 
            this.pnlOnBtnLogout.BackColor = System.Drawing.Color.Black;
            this.pnlOnBtnLogout.Location = new System.Drawing.Point(-4, 9);
            this.pnlOnBtnLogout.Name = "pnlOnBtnLogout";
            this.pnlOnBtnLogout.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnLogout.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(0, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 39);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlOnBtnAbout
            // 
            this.pnlOnBtnAbout.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnAbout.Controls.Add(this.panel7);
            this.pnlOnBtnAbout.Location = new System.Drawing.Point(-2, 156);
            this.pnlOnBtnAbout.Name = "pnlOnBtnAbout";
            this.pnlOnBtnAbout.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnAbout.TabIndex = 10;
            this.pnlOnBtnAbout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOnBtnAbout_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(-63, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 31);
            this.panel7.TabIndex = 12;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(-2, 156);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(133, 31);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlOnBtnBorrowing
            // 
            this.pnlOnBtnBorrowing.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnBorrowing.Location = new System.Drawing.Point(-3, 117);
            this.pnlOnBtnBorrowing.Name = "pnlOnBtnBorrowing";
            this.pnlOnBtnBorrowing.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnBorrowing.TabIndex = 8;
            // 
            // btnBorrowing
            // 
            this.btnBorrowing.FlatAppearance.BorderSize = 0;
            this.btnBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowing.ForeColor = System.Drawing.Color.White;
            this.btnBorrowing.Location = new System.Drawing.Point(0, 116);
            this.btnBorrowing.Name = "btnBorrowing";
            this.btnBorrowing.Size = new System.Drawing.Size(133, 34);
            this.btnBorrowing.TabIndex = 7;
            this.btnBorrowing.Text = "Borrowing";
            this.btnBorrowing.UseVisualStyleBackColor = true;
            this.btnBorrowing.Click += new System.EventHandler(this.btnBorrowing_Click);
            // 
            // pnlOnBtnProfile
            // 
            this.pnlOnBtnProfile.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnProfile.Location = new System.Drawing.Point(-3, 77);
            this.pnlOnBtnProfile.Name = "pnlOnBtnProfile";
            this.pnlOnBtnProfile.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnProfile.TabIndex = 6;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(3, 77);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(133, 31);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Student Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Yellow;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.txtuLib);
            this.pnlTop.Controls.Add(this.pnlBtnTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(133, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(562, 43);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // txtuLib
            // 
            this.txtuLib.AutoSize = true;
            this.txtuLib.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuLib.Location = new System.Drawing.Point(8, 8);
            this.txtuLib.Name = "txtuLib";
            this.txtuLib.Size = new System.Drawing.Size(74, 29);
            this.txtuLib.TabIndex = 1;
            this.txtuLib.Text = "U-LIB";
            // 
            // pnlBtnTop
            // 
            this.pnlBtnTop.Controls.Add(this.btnClose);
            this.pnlBtnTop.Controls.Add(this.btnMaximize);
            this.pnlBtnTop.Controls.Add(this.btnMinimize);
            this.pnlBtnTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtnTop.Location = new System.Drawing.Point(481, 0);
            this.pnlBtnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBtnTop.Name = "pnlBtnTop";
            this.pnlBtnTop.Size = new System.Drawing.Size(79, 41);
            this.pnlBtnTop.TabIndex = 0;
            // 
            // ucpanel
            // 
            this.ucpanel.Controls.Add(this.label2);
            this.ucpanel.Controls.Add(this.label1);
            this.ucpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucpanel.Location = new System.Drawing.Point(133, 43);
            this.ucpanel.Name = "ucpanel";
            this.ucpanel.Size = new System.Drawing.Size(562, 327);
            this.ucpanel.TabIndex = 2;
            this.ucpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ucpanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label2.Location = new System.Drawing.Point(92, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please arrange the borrowing of student books.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have successfully logged in!\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(54, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(14, 12);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(34, 15);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(14, 12);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(13, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(14, 12);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ukLogo
            // 
            this.ukLogo.Image = global::U_LIB.Properties.Resources.LOGO_UNIVERSITAS_KLABAT;
            this.ukLogo.Location = new System.Drawing.Point(38, 3);
            this.ukLogo.Name = "ukLogo";
            this.ukLogo.Size = new System.Drawing.Size(49, 42);
            this.ukLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ukLogo.TabIndex = 11;
            this.ukLogo.TabStop = false;
            // 
            // header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 370);
            this.Controls.Add(this.ucpanel);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "header";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.header_Load);
            this.pnlLeft.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.pnlOnBtnAbout.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBtnTop.ResumeLayout(false);
            this.ucpanel.ResumeLayout(false);
            this.ucpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ukLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBtnTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnlOnBtnBorrowing;
        private System.Windows.Forms.Button btnBorrowing;
        private System.Windows.Forms.Panel pnlOnBtnProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlOnBtnAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Panel pnlOnBtnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox ukLogo;
        private System.Windows.Forms.Label txtuLib;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button catalogbtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel ucpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

