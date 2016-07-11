namespace WindowsFormsApplication1
{
    partial class Magacin
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
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delovi = new System.Windows.Forms.ListView();
            this.ukupno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.racunari = new System.Windows.Forms.ListView();
            this.pc_naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pc_kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pc_cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pc_ukupno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.potvrdi = new System.Windows.Forms.Button();
            this.izmeni = new System.Windows.Forms.Button();
            this.kraj_rada = new System.Windows.Forms.Button();
            this.tbUkupno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.Width = 121;
            // 
            // kolicina
            // 
            this.kolicina.Text = "Kolicina";
            this.kolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kolicina.Width = 49;
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            this.cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cena.Width = 73;
            // 
            // delovi
            // 
            this.delovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naziv,
            this.kolicina,
            this.cena,
            this.ukupno});
            this.delovi.Location = new System.Drawing.Point(15, 27);
            this.delovi.Name = "delovi";
            this.delovi.Size = new System.Drawing.Size(316, 87);
            this.delovi.TabIndex = 7;
            this.delovi.UseCompatibleStateImageBehavior = false;
            this.delovi.View = System.Windows.Forms.View.Details;
            // 
            // ukupno
            // 
            this.ukupno.Text = "Ukupno";
            this.ukupno.Width = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stanje delova u magacinu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stanje racunara u magacinu";
            // 
            // racunari
            // 
            this.racunari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pc_naziv,
            this.pc_kolicina,
            this.pc_cena,
            this.pc_ukupno});
            this.racunari.Location = new System.Drawing.Point(15, 133);
            this.racunari.Name = "racunari";
            this.racunari.Size = new System.Drawing.Size(316, 87);
            this.racunari.TabIndex = 8;
            this.racunari.UseCompatibleStateImageBehavior = false;
            this.racunari.View = System.Windows.Forms.View.Details;
            // 
            // pc_naziv
            // 
            this.pc_naziv.Text = "Naziv";
            this.pc_naziv.Width = 120;
            // 
            // pc_kolicina
            // 
            this.pc_kolicina.Text = "Kolicina";
            this.pc_kolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pc_kolicina.Width = 49;
            // 
            // pc_cena
            // 
            this.pc_cena.Text = "Cena";
            this.pc_cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pc_cena.Width = 77;
            // 
            // pc_ukupno
            // 
            this.pc_ukupno.Text = "Ukupno";
            this.pc_ukupno.Width = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kolicina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cena:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(398, 16);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 0;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(398, 42);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(100, 20);
            this.tbKolicina.TabIndex = 1;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(398, 68);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(100, 20);
            this.tbCena.TabIndex = 2;
            // 
            // potvrdi
            // 
            this.potvrdi.Location = new System.Drawing.Point(342, 139);
            this.potvrdi.Name = "potvrdi";
            this.potvrdi.Size = new System.Drawing.Size(156, 23);
            this.potvrdi.TabIndex = 4;
            this.potvrdi.Text = "Potvrdi";
            this.potvrdi.UseVisualStyleBackColor = true;
            this.potvrdi.Click += new System.EventHandler(this.potvrdi_Click);
            // 
            // izmeni
            // 
            this.izmeni.Location = new System.Drawing.Point(342, 168);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(156, 23);
            this.izmeni.TabIndex = 5;
            this.izmeni.Text = "Izmeni";
            this.izmeni.UseVisualStyleBackColor = true;
            this.izmeni.Click += new System.EventHandler(this.izmeni_Click);
            // 
            // kraj_rada
            // 
            this.kraj_rada.Location = new System.Drawing.Point(342, 197);
            this.kraj_rada.Name = "kraj_rada";
            this.kraj_rada.Size = new System.Drawing.Size(156, 23);
            this.kraj_rada.TabIndex = 6;
            this.kraj_rada.Text = "Kraj rada";
            this.kraj_rada.UseVisualStyleBackColor = true;
            this.kraj_rada.Click += new System.EventHandler(this.kraj_rada_Click);
            // 
            // tbUkupno
            // 
            this.tbUkupno.Location = new System.Drawing.Point(398, 94);
            this.tbUkupno.Name = "tbUkupno";
            this.tbUkupno.Size = new System.Drawing.Size(100, 20);
            this.tbUkupno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ukupno:";
            // 
            // Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 234);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUkupno);
            this.Controls.Add(this.kraj_rada);
            this.Controls.Add(this.izmeni);
            this.Controls.Add(this.potvrdi);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.racunari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delovi);
            this.Name = "Magacin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magacin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader kolicina;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.ListView delovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView racunari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Button potvrdi;
        private System.Windows.Forms.Button izmeni;
        private System.Windows.Forms.Button kraj_rada;
        private System.Windows.Forms.ColumnHeader pc_naziv;
        private System.Windows.Forms.ColumnHeader pc_kolicina;
        private System.Windows.Forms.ColumnHeader pc_cena;
        private System.Windows.Forms.TextBox tbUkupno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader ukupno;
        private System.Windows.Forms.ColumnHeader pc_ukupno;


    }
}