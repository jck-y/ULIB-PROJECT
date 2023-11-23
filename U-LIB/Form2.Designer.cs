namespace U_LIB
{
    partial class loginForm
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.submitbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.passcekbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.Label();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.loginsubpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.unklabloginpict = new System.Windows.Forms.PictureBox();
            this.welcometxt = new System.Windows.Forms.Label();
            this.loginpanel.SuspendLayout();
            this.loginsubpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unklabloginpict)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Window;
            this.loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginpanel.Controls.Add(this.submitbutton);
            this.loginpanel.Controls.Add(this.cancelbutton);
            this.loginpanel.Controls.Add(this.passcekbox);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Controls.Add(this.emailtxt);
            this.loginpanel.Controls.Add(this.passtxtbox);
            this.loginpanel.Controls.Add(this.emailtxtbox);
            this.loginpanel.Controls.Add(this.loginsubpanel);
            this.loginpanel.Location = new System.Drawing.Point(267, 106);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(640, 531);
            this.loginpanel.TabIndex = 0;
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(435, 420);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(124, 63);
            this.submitbutton.TabIndex = 7;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(302, 420);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(124, 63);
            this.cancelbutton.TabIndex = 6;
            this.cancelbutton.Text = "Close";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click_1);
            // 
            // passcekbox
            // 
            this.passcekbox.AutoSize = true;
            this.passcekbox.Location = new System.Drawing.Point(207, 318);
            this.passcekbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passcekbox.Name = "passcekbox";
            this.passcekbox.Size = new System.Drawing.Size(137, 24);
            this.passcekbox.TabIndex = 5;
            this.passcekbox.Text = "See Password";
            this.passcekbox.UseVisualStyleBackColor = true;
            this.passcekbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // emailtxt
            // 
            this.emailtxt.AutoSize = true;
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(82, 191);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(31, 25);
            this.emailtxt.TabIndex = 3;
            this.emailtxt.Text = "ID";
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(207, 265);
            this.passtxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(271, 26);
            this.passtxtbox.TabIndex = 2;
            this.passtxtbox.TextChanged += new System.EventHandler(this.passtxtbox_TextChanged_1);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(206, 189);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(271, 26);
            this.emailtxtbox.TabIndex = 1;
            this.emailtxtbox.TextChanged += new System.EventHandler(this.emailtxtbox_TextChanged);
            // 
            // loginsubpanel
            // 
            this.loginsubpanel.BackColor = System.Drawing.Color.Yellow;
            this.loginsubpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginsubpanel.Controls.Add(this.label2);
            this.loginsubpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginsubpanel.Location = new System.Drawing.Point(0, 0);
            this.loginsubpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginsubpanel.Name = "loginsubpanel";
            this.loginsubpanel.Size = new System.Drawing.Size(638, 84);
            this.loginsubpanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "U-LIB LOGIN";
            // 
            // unklabloginpict
            // 
            this.unklabloginpict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unklabloginpict.Image = global::U_LIB.Properties.Resources.LOGO_UNIVERSITAS_KLABAT;
            this.unklabloginpict.Location = new System.Drawing.Point(297, 17);
            this.unklabloginpict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unklabloginpict.Name = "unklabloginpict";
            this.unklabloginpict.Size = new System.Drawing.Size(86, 80);
            this.unklabloginpict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unklabloginpict.TabIndex = 1;
            this.unklabloginpict.TabStop = false;
            // 
            // welcometxt
            // 
            this.welcometxt.AutoSize = true;
            this.welcometxt.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcometxt.Location = new System.Drawing.Point(384, 29);
            this.welcometxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcometxt.Name = "welcometxt";
            this.welcometxt.Size = new System.Drawing.Size(434, 60);
            this.welcometxt.TabIndex = 2;
            this.welcometxt.Text = "WELCOME TO U-LIB";
            this.welcometxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1119, 689);
            this.Controls.Add(this.welcometxt);
            this.Controls.Add(this.unklabloginpict);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.loginsubpanel.ResumeLayout(false);
            this.loginsubpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unklabloginpict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel loginsubpanel;
        private System.Windows.Forms.PictureBox unklabloginpict;
        private System.Windows.Forms.Label welcometxt;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailtxt;
        private System.Windows.Forms.CheckBox passcekbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}