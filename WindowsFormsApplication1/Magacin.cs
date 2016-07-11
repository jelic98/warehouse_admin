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
    public partial class Magacin : Form {

        public Magacin() {
            InitializeComponent();

            osveziDelove();
            osveziRacunare();
        }

        private void osveziDelove()
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlDataAdapter ada = new MySqlDataAdapter("SELECT * FROM delovi;", konekcija);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    delovi.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem deo = new ListViewItem(dr["naziv"].ToString());
                        deo.SubItems.Add(dr["kolicina"].ToString());
                        deo.SubItems.Add(dr["cena"].ToString());
                        deo.SubItems.Add(dr["ukupno"].ToString());
                        delovi.Items.Add(deo);
                    }

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void osveziRacunare()
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlDataAdapter ada = new MySqlDataAdapter("SELECT * FROM racunari;", konekcija);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    racunari.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem racunar = new ListViewItem(dr["naziv"].ToString());
                        racunar.SubItems.Add(dr["kolicina"].ToString());
                        racunar.SubItems.Add(dr["cena"].ToString());
                        racunar.SubItems.Add(dr["ukupno"].ToString());
                        racunari.Items.Add(racunar);
                    }

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void kraj_rada_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    if (Prijava.pozicija != "administrator") {
                        MySqlCommand cmd = new MySqlCommand("UPDATE radnik SET status=false WHERE jmbg=@jmbg;", konekcija);
                        cmd.Parameters.AddWithValue("@jmbg", Prijava.jmbg);
                        cmd.ExecuteNonQuery();
                    }
                    
                    konekcija.Close();

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void potvrdi_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selektovano = this.delovi.SelectedItems;

            foreach (ListViewItem deo in selektovano)
            {
                this.tbNaziv.Text = deo.SubItems[0].Text;
                this.tbKolicina.Text = deo.SubItems[1].Text;
                this.tbCena.Text = deo.SubItems[2].Text;
                this.tbUkupno.Text = deo.SubItems[3].Text;
            }
        }

        private void izmeni_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    int cena = Convert.ToInt16(this.tbCena.Text);
                    int kolicina = Convert.ToInt16(this.tbKolicina.Text);

                    int ukupno = cena * kolicina;

                    MySqlCommand cmd = new MySqlCommand("UPDATE delovi SET kolicina=@kolicina, cena=@cena, ukupno=@ukupno WHERE naziv=@naziv;", konekcija);

                    cmd.Parameters.AddWithValue("@kolicina", this.tbKolicina.Text);
                    cmd.Parameters.AddWithValue("@cena", this.tbCena.Text);
                    cmd.Parameters.AddWithValue("@ukupno", ukupno);
                    cmd.Parameters.AddWithValue("@naziv", this.tbNaziv.Text);

                    cmd.ExecuteNonQuery();

                    konekcija.Close();

                    osveziDelove();

                    MessageBox.Show("Uspesna izmena podataka dela");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }
    }
}
