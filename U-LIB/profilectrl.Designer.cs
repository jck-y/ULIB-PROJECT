namespace U_LIB
{
    partial class profilectrl
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
            this.studenttxt = new System.Windows.Forms.Label();
            this.dataprofile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // studenttxt
            // 
            this.studenttxt.AutoSize = true;
            this.studenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studenttxt.Location = new System.Drawing.Point(11, 18);
            this.studenttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studenttxt.Name = "studenttxt";
            this.studenttxt.Size = new System.Drawing.Size(146, 24);
            this.studenttxt.TabIndex = 21;
            this.studenttxt.Text = "Student Profile";
            this.studenttxt.Click += new System.EventHandler(this.nimtxt_Click);
            // 
            // dataprofile
            // 
            this.dataprofile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataprofile.Location = new System.Drawing.Point(15, 59);
            this.dataprofile.Name = "dataprofile";
            this.dataprofile.Size = new System.Drawing.Size(528, 225);
            this.dataprofile.TabIndex = 23;
            this.dataprofile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataprofile_CellContentClick);
            // 
            // profilectrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataprofile);
            this.Controls.Add(this.studenttxt);
            this.Name = "profilectrl";
            this.Size = new System.Drawing.Size(561, 323);
            this.Load += new System.EventHandler(this.profilectrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataprofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label studenttxt;
        private System.Windows.Forms.DataGridView dataprofile;
    }
}
