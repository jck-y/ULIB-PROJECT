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
            this.pnlOnBtnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBtnTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlOnBtnCategory = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.pnlOnBtnProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlOnBtnBorrowing = new System.Windows.Forms.Panel();
            this.btnBorrowing = new System.Windows.Forms.Button();
            this.pnlOnBtnAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBtnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DarkMagenta;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.pnlOnBtnAbout);
            this.pnlLeft.Controls.Add(this.btnAbout);
            this.pnlLeft.Controls.Add(this.pnlOnBtnBorrowing);
            this.pnlLeft.Controls.Add(this.btnBorrowing);
            this.pnlLeft.Controls.Add(this.pnlOnBtnProfile);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Controls.Add(this.pnlOnBtnCategory);
            this.pnlLeft.Controls.Add(this.btnCategory);
            this.pnlLeft.Controls.Add(this.pnlOnBtnHome);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(133, 370);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlOnBtnHome
            // 
            this.pnlOnBtnHome.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnHome.Location = new System.Drawing.Point(-3, 46);
            this.pnlOnBtnHome.Name = "pnlOnBtnHome";
            this.pnlOnBtnHome.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnHome.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 46);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(133, 31);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Yellow;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlBtnTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(133, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(562, 43);
            this.pnlTop.TabIndex = 1;
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
            // pnlOnBtnCategory
            // 
            this.pnlOnBtnCategory.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnCategory.Location = new System.Drawing.Point(-3, 129);
            this.pnlOnBtnCategory.Name = "pnlOnBtnCategory";
            this.pnlOnBtnCategory.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnCategory.TabIndex = 4;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(0, 129);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(133, 31);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pnlOnBtnProfile
            // 
            this.pnlOnBtnProfile.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnProfile.Location = new System.Drawing.Point(-3, 87);
            this.pnlOnBtnProfile.Name = "pnlOnBtnProfile";
            this.pnlOnBtnProfile.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnProfile.TabIndex = 6;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 87);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(133, 31);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlOnBtnBorrowing
            // 
            this.pnlOnBtnBorrowing.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnBorrowing.Location = new System.Drawing.Point(-3, 170);
            this.pnlOnBtnBorrowing.Name = "pnlOnBtnBorrowing";
            this.pnlOnBtnBorrowing.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnBorrowing.TabIndex = 8;
            // 
            // btnBorrowing
            // 
            this.btnBorrowing.FlatAppearance.BorderSize = 0;
            this.btnBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowing.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowing.ForeColor = System.Drawing.Color.White;
            this.btnBorrowing.Location = new System.Drawing.Point(0, 170);
            this.btnBorrowing.Name = "btnBorrowing";
            this.btnBorrowing.Size = new System.Drawing.Size(133, 31);
            this.btnBorrowing.TabIndex = 7;
            this.btnBorrowing.Text = "Borrowing";
            this.btnBorrowing.UseVisualStyleBackColor = true;
            this.btnBorrowing.Click += new System.EventHandler(this.btnBorrowing_Click);
            // 
            // pnlOnBtnAbout
            // 
            this.pnlOnBtnAbout.BackColor = System.Drawing.Color.Yellow;
            this.pnlOnBtnAbout.Location = new System.Drawing.Point(-3, 210);
            this.pnlOnBtnAbout.Name = "pnlOnBtnAbout";
            this.pnlOnBtnAbout.Size = new System.Drawing.Size(10, 31);
            this.pnlOnBtnAbout.TabIndex = 10;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 210);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(133, 31);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 370);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "header";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.header_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlBtnTop.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlOnBtnHome;
        private System.Windows.Forms.Panel pnlOnBtnBorrowing;
        private System.Windows.Forms.Button btnBorrowing;
        private System.Windows.Forms.Panel pnlOnBtnProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlOnBtnCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel pnlOnBtnAbout;
        private System.Windows.Forms.Button btnAbout;
    }
}

