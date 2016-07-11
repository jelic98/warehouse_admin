using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1 {
    public partial class Radnici : Form {
        public Radnici()
        {
            InitializeComponent();
            osveziListu();
        }

        private void osveziListu() { 
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlDataAdapter ada = new MySqlDataAdapter("SELECT * FROM radnik;", konekcija);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    spisak_radnika.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem radnik = new ListViewItem(dr["sifra"].ToString());
                        radnik.SubItems.Add(dr["ime"].ToString());
                        radnik.SubItems.Add(dr["prezime"].ToString());
                        radnik.SubItems.Add(dr["jmbg"].ToString()); 
                        radnik.SubItems.Add(dr["pozicija"].ToString());
                        radnik.SubItems.Add(dr["status"].ToString());
                        spisak_radnika.Items.Add(radnik);
                    }

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void novi_radnik_Click(object sender, EventArgs e) {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO radnik(sifra, ime, prezime, jmbg, pozicija, status) VALUES(@sifra, @ime, @prezime, @jmbg, @pozicija, @status);", konekcija);
                    
                    cmd.Parameters.AddWithValue("@sifra", this.tbSifra.Text);
                    cmd.Parameters.AddWithValue("@ime", this.tbIme.Text);
                    cmd.Parameters.AddWithValue("@prezime", this.tbPrezime.Text);
                    cmd.Parameters.AddWithValue("@jmbg", int.Parse(this.tbJmbg.Text));
                    cmd.Parameters.AddWithValue("@pozicija", this.tbPozicija.Text);
                    cmd.Parameters.AddWithValue("@status", this.tbStatus.Text);

                    cmd.ExecuteNonQuery();

                    konekcija.Close();

                    osveziListu();

                    MessageBox.Show("Uspesno dodat novi radnik");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void potvrdi_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selektovano = this.spisak_radnika.SelectedItems;

            foreach (ListViewItem radnik in selektovano)
            {
                this.tbSifra.Text = radnik.SubItems[0].Text;
                this.tbIme.Text = radnik.SubItems[1].Text;
                this.tbPrezime.Text = radnik.SubItems[2].Text;
                this.tbJmbg.Text = radnik.SubItems[3].Text;
                this.tbPozicija.Text = radnik.SubItems[4].Text;
                this.tbStatus.Text = radnik.SubItems[5].Text;
            }
        }

        private void kraj_rada_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    string jmbg = this.tbJmbg.Text;

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM radnik WHERE jmbg=@jmbg;", konekcija);

                    cmd.Parameters.AddWithValue("@jmbg", jmbg);

                    cmd.ExecuteNonQuery();

                    konekcija.Close();

                    osveziListu();

                    MessageBox.Show("Uspesno obrisan radnik");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void izmeni_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    string sStatus = this.tbStatus.Text;
                    int status;

                    if (sStatus == "True")
                    {
                        status = 1;
                    }
                    else 
                    {
                        status = 0;
                    }

                    MySqlCommand cmd = new MySqlCommand("UPDATE radnik SET sifra=@sifra, ime=@ime, prezime=@prezime, pozicija=@pozicija, status=@status WHERE jmbg=@jmbg;", konekcija);

                    cmd.Parameters.AddWithValue("@sifra", this.tbSifra.Text);
                    cmd.Parameters.AddWithValue("@ime", this.tbIme.Text);
                    cmd.Parameters.AddWithValue("@prezime", this.tbPrezime.Text);
                    cmd.Parameters.AddWithValue("@jmbg", this.tbJmbg.Text);
                    cmd.Parameters.AddWithValue("@pozicija", this.tbPozicija.Text);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();

                    konekcija.Close();

                    osveziListu();

                    MessageBox.Show("Uspesna izmena podataka radnika");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }
    }
}
