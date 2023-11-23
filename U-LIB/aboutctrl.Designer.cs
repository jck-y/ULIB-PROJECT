namespace U_LIB
{
    partial class aboutctrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutctrl));
            this.abouttxt = new System.Windows.Forms.Label();
            this.rulestxt1 = new System.Windows.Forms.Label();
            this.rulestxt2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abouttxt
            // 
            this.abouttxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abouttxt.Location = new System.Drawing.Point(0, 12);
            this.abouttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.abouttxt.Name = "abouttxt";
            this.abouttxt.Size = new System.Drawing.Size(561, 117);
            this.abouttxt.TabIndex = 1;
            this.abouttxt.Text = resources.GetString("abouttxt.Text");
            this.abouttxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rulestxt1
            // 
            this.rulestxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulestxt1.Location = new System.Drawing.Point(170, 137);
            this.rulestxt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rulestxt1.Name = "rulestxt1";
            this.rulestxt1.Size = new System.Drawing.Size(209, 24);
            this.rulestxt1.TabIndex = 2;
            this.rulestxt1.Text = "Aturan Peminjaman U-LIB :";
            this.rulestxt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rulestxt2
            // 
            this.rulestxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rulestxt2.Location = new System.Drawing.Point(13, 170);
            this.rulestxt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rulestxt2.Name = "rulestxt2";
            this.rulestxt2.Size = new System.Drawing.Size(531, 129);
            this.rulestxt2.TabIndex = 3;
            this.rulestxt2.Text = resources.GetString("rulestxt2.Text");
            // 
            // aboutctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rulestxt2);
            this.Controls.Add(this.rulestxt1);
            this.Controls.Add(this.abouttxt);
            this.Name = "aboutctrl";
            this.Size = new System.Drawing.Size(561, 323);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label abouttxt;
        private System.Windows.Forms.Label rulestxt1;
        private System.Windows.Forms.Label rulestxt2;
    }
}
