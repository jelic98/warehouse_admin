namespace WindowsFormsApplication1
{
    partial class Administracija
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
            this.magacin = new System.Windows.Forms.Button();
            this.radnici = new System.Windows.Forms.Button();
            this.kraj_rada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // magacin
            // 
            this.magacin.Location = new System.Drawing.Point(12, 12);
            this.magacin.Name = "magacin";
            this.magacin.Size = new System.Drawing.Size(260, 37);
            this.magacin.TabIndex = 1;
            this.magacin.Text = "Magacin";
            this.magacin.UseVisualStyleBackColor = true;
            this.magacin.Click += new System.EventHandler(this.magacin_Click);
            // 
            // radnici
            // 
            this.radnici.Location = new System.Drawing.Point(12, 55);
            this.radnici.Name = "radnici";
            this.radnici.Size = new System.Drawing.Size(260, 37);
            this.radnici.TabIndex = 2;
            this.radnici.Text = "Radnici";
            this.radnici.UseVisualStyleBackColor = true;
            this.radnici.Click += new System.EventHandler(this.radnici_Click);
            // 
            // kraj_rada
            // 
            this.kraj_rada.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kraj_rada.Location = new System.Drawing.Point(105, 127);
            this.kraj_rada.Name = "kraj_rada";
            this.kraj_rada.Size = new System.Drawing.Size(75, 23);
            this.kraj_rada.TabIndex = 3;
            this.kraj_rada.Text = "Kraj rada";
            this.kraj_rada.UseVisualStyleBackColor = true;
            this.kraj_rada.Click += new System.EventHandler(this.kraj_rada_Click);
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.kraj_rada);
            this.Controls.Add(this.radnici);
            this.Controls.Add(this.magacin);
            this.Name = "Administracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button magacin;
        private System.Windows.Forms.Button radnici;
        private System.Windows.Forms.Button kraj_rada;
    }
}