namespace WindowsFormsApplication1
{
    partial class Radnici
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
            this.label1 = new System.Windows.Forms.Label();
            this.obrisi = new System.Windows.Forms.Button();
            this.potvrdi = new System.Windows.Forms.Button();
            this.izmeni = new System.Windows.Forms.Button();
            this.novi_radnik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.tbPozicija = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.kraj_rada = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.spisak_radnika = new System.Windows.Forms.ListView();
            this.sifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pozicija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spisak zaposljenih radnika";
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(255, 129);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(75, 39);
            this.obrisi.TabIndex = 9;
            this.obrisi.Text = "Obrisi";
            this.obrisi.UseVisualStyleBackColor = true;
            this.obrisi.Click += new System.EventHandler(this.obrisi_Click);
            // 
            // potvrdi
            // 
            this.potvrdi.Location = new System.Drawing.Point(15, 129);
            this.potvrdi.Name = "potvrdi";
            this.potvrdi.Size = new System.Drawing.Size(75, 39);
            this.potvrdi.TabIndex = 6;
            this.potvrdi.Text = "Potvrdi";
            this.potvrdi.UseVisualStyleBackColor = true;
            this.potvrdi.Click += new System.EventHandler(this.potvrdi_Click);
            // 
            // izmeni
            // 
            this.izmeni.Location = new System.Drawing.Point(93, 129);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(75, 39);
            this.izmeni.TabIndex = 7;
            this.izmeni.Text = "Izmeni";
            this.izmeni.UseVisualStyleBackColor = true;
            this.izmeni.Click += new System.EventHandler(this.izmeni_Click);
            // 
            // novi_radnik
            // 
            this.novi_radnik.Location = new System.Drawing.Point(174, 128);
            this.novi_radnik.Name = "novi_radnik";
            this.novi_radnik.Size = new System.Drawing.Size(75, 39);
            this.novi_radnik.TabIndex = 8;
            this.novi_radnik.Text = "Novi radnik";
            this.novi_radnik.UseVisualStyleBackColor = true;
            this.novi_radnik.Click += new System.EventHandler(this.novi_radnik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "JMBG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sifra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pozicija";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(536, 43);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 1;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(536, 69);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 2;
            // 
            // tbJmbg
            // 
            this.tbJmbg.Location = new System.Drawing.Point(536, 95);
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(100, 20);
            this.tbJmbg.TabIndex = 3;
            // 
            // tbPozicija
            // 
            this.tbPozicija.Location = new System.Drawing.Point(536, 121);
            this.tbPozicija.Name = "tbPozicija";
            this.tbPozicija.Size = new System.Drawing.Size(100, 20);
            this.tbPozicija.TabIndex = 4;
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(536, 17);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(100, 20);
            this.tbSifra.TabIndex = 0;
            // 
            // kraj_rada
            // 
            this.kraj_rada.Location = new System.Drawing.Point(336, 129);
            this.kraj_rada.Name = "kraj_rada";
            this.kraj_rada.Size = new System.Drawing.Size(75, 39);
            this.kraj_rada.TabIndex = 10;
            this.kraj_rada.Text = "Kraj rada";
            this.kraj_rada.UseVisualStyleBackColor = true;
            this.kraj_rada.Click += new System.EventHandler(this.kraj_rada_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(536, 148);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 20);
            this.tbStatus.TabIndex = 5;
            // 
            // spisak_radnika
            // 
            this.spisak_radnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sifra,
            this.ime,
            this.prezime,
            this.jmbg,
            this.pozicija,
            this.status});
            this.spisak_radnika.Location = new System.Drawing.Point(15, 26);
            this.spisak_radnika.Name = "spisak_radnika";
            this.spisak_radnika.Size = new System.Drawing.Size(462, 97);
            this.spisak_radnika.TabIndex = 11;
            this.spisak_radnika.UseCompatibleStateImageBehavior = false;
            this.spisak_radnika.View = System.Windows.Forms.View.Details;
            // 
            // sifra
            // 
            this.sifra.Text = "Sifra";
            this.sifra.Width = 71;
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            this.ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ime.Width = 78;
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            this.prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prezime.Width = 77;
            // 
            // jmbg
            // 
            this.jmbg.Text = "JMBG";
            this.jmbg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jmbg.Width = 83;
            // 
            // pozicija
            // 
            this.pozicija.Text = "Pozicija";
            this.pozicija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pozicija.Width = 80;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 69;
            // 
            // Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 176);
            this.Controls.Add(this.spisak_radnika);
            this.Controls.Add(this.kraj_rada);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbPozicija);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbJmbg);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.novi_radnik);
            this.Controls.Add(this.izmeni);
            this.Controls.Add(this.potvrdi);
            this.Controls.Add(this.obrisi);
            this.Controls.Add(this.label1);
            this.Name = "Radnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radnici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.Button potvrdi;
        private System.Windows.Forms.Button izmeni;
        private System.Windows.Forms.Button kraj_rada;
        private System.Windows.Forms.Button novi_radnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.TextBox tbPozicija;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.ListView spisak_radnika;
        private System.Windows.Forms.ColumnHeader sifra;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ColumnHeader jmbg;
        private System.Windows.Forms.ColumnHeader pozicija;
        private System.Windows.Forms.ColumnHeader status;
    }
}