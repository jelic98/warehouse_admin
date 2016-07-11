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
    public partial class Prijava : Form {
        public static string pozicija, jmbg, sifra, ime, prezime;

        public Prijava() {
            InitializeComponent();
        } 

        private void prijavi_se_Click(object sender, EventArgs e) {
            sifra = tbSifra.Text;
            ime = tbIme.Text;
            prezime = tbPrezime.Text;

            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlCommand cmd;

                    cmd = new MySqlCommand("SELECT pozicija, jmbg FROM radnik WHERE sifra=@sifra AND ime=@ime AND prezime=@prezime;", konekcija);
                    cmd.Parameters.AddWithValue("@sifra", sifra);
                    cmd.Parameters.AddWithValue("@ime", ime);
                    cmd.Parameters.AddWithValue("@prezime", prezime);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            pozicija = reader["pozicija"].ToString();
                            jmbg = reader["jmbg"].ToString();
                        }
                    }

                    reader.Close();

                    cmd = new MySqlCommand("UPDATE radnik SET status=true WHERE jmbg=@jmbg;", konekcija);
                    cmd.Parameters.AddWithValue("@jmbg", jmbg);
                    cmd.ExecuteNonQuery();

                    konekcija.Close();
                }
                    

                if (pozicija == "administrator")
                {
                    Administracija administracija = new Administracija();
                    administracija.Show();
                }
                else if (pozicija == "magacioner")
                {
                    Magacin magacin = new Magacin();
                    magacin.Show();
                }
                else if (pozicija == "radnik")
                {
                    Sastavljanje sastavljanje = new Sastavljanje();
                    sastavljanje.Show();
                }

                MessageBox.Show("Prijavljeni ste kao " + pozicija.ToUpper());
            }
            catch (Exception)
            {
                MessageBox.Show("Prijava nije uspela");
            }
        }
    }            
}
