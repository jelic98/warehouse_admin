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
    public partial class Sastavljanje : Form {
        int repeat, kolicina, ukupno, cena;
        int ram, cpu, hdd, cooler;
        int uRam, uCpu, uHdd, uCooler;
        int cRam, cCpu, cHdd, cCooler;
        string naziv;

        public Sastavljanje() {
            InitializeComponent();
        }

        private void kraj_rada_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE radnik SET status=false WHERE jmbg=@jmbg;", konekcija);

                    cmd.Parameters.AddWithValue("@jmbg", Prijava.jmbg);

                    cmd.ExecuteNonQuery();

                    konekcija.Close();

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void izdvojiRacunare() {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT kolicina, cena FROM racunari WHERE naziv=@naziv;", konekcija);

                    naziv = tbModel.Text;

                    cmd.Parameters.AddWithValue("@naziv", naziv);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            kolicina = Convert.ToInt16(reader["kolicina"].ToString());
                            cena = Convert.ToInt16(reader["cena"].ToString());
                        }
                    }

                    reader.Close();

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void izdvojiDelove() {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT kolicina, cena FROM delovi WHERE naziv=@naziv;", konekcija);

                    cmd.Parameters.AddWithValue("@naziv", "ram");

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ram = Convert.ToInt16(reader["kolicina"].ToString());
                            cRam = Convert.ToInt16(reader["cena"].ToString());
                        }
                    }

                    reader.Close();

                    cmd = new MySqlCommand("SELECT kolicina, cena FROM delovi WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "cpu");
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cpu = Convert.ToInt16(reader["kolicina"].ToString());
                            cCpu = Convert.ToInt16(reader["cena"].ToString());
                        }
                    }

                    reader.Close();

                    cmd = new MySqlCommand("SELECT kolicina, cena FROM delovi WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "hdd");
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            hdd = Convert.ToInt16(reader["kolicina"].ToString());
                            cHdd = Convert.ToInt16(reader["cena"].ToString());
                        }
                    }

                    reader.Close();

                    cmd = new MySqlCommand("SELECT kolicina, cena FROM delovi WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "cooler");
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cooler = Convert.ToInt16(reader["kolicina"].ToString());
                            cCooler = Convert.ToInt16(reader["cena"].ToString());
                        }
                    }

                    reader.Close();

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void azurirajRacunare() { 
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE racunari SET kolicina=@kolicina, ukupno=@ukupno WHERE naziv=@naziv;", konekcija);

                    cmd.Parameters.AddWithValue("@naziv", this.tbModel.Text);
                    cmd.Parameters.AddWithValue("@kolicina", kolicina);
                    cmd.Parameters.AddWithValue("@ukupno", ukupno);

                    cmd.ExecuteNonQuery();

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena"); 
            }
        }

        private void azurirajDelove()
        {
            try
            {
                using (MySqlConnection konekcija = new MySqlConnection("server=localhost;database=racunari;uid=root;pwd=root123;"))
                {

                    MySqlCommand cmd;

                    konekcija.Open();

                    cmd = new MySqlCommand("UPDATE delovi SET kolicina=@kolicina, ukupno=@ukupno WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "ram");
                    cmd.Parameters.AddWithValue("@kolicina", ram);
                    cmd.Parameters.AddWithValue("@ukupno", uRam);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("UPDATE delovi SET kolicina=@kolicina, ukupno=@ukupno WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "cpu");
                    cmd.Parameters.AddWithValue("@kolicina", cpu);
                    cmd.Parameters.AddWithValue("@ukupno", uCpu);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("UPDATE delovi SET kolicina=@kolicina, ukupno=@ukupno WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "hdd");
                    cmd.Parameters.AddWithValue("@kolicina", hdd);
                    cmd.Parameters.AddWithValue("@ukupno", uHdd);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("UPDATE delovi SET kolicina=@kolicina, ukupno=@ukupno WHERE naziv=@naziv;", konekcija);
                    cmd.Parameters.AddWithValue("@naziv", "cooler");
                    cmd.Parameters.AddWithValue("@kolicina", cooler);
                    cmd.Parameters.AddWithValue("@ukupno", uCooler);
                    cmd.ExecuteNonQuery();

                    konekcija.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veza sa bazom podataka nije uspostavljena");
            }
        }

        private void sastavi_Click(object sender, EventArgs e)
        {
            izdvojiDelove();
            izdvojiRacunare();

            if (String.IsNullOrEmpty(this.tbBrojSastavljanja.Text))
            {
                MessageBox.Show("Broj sastavljanja nije unet");
            }
            else
            {
                repeat = Convert.ToInt16(this.tbBrojSastavljanja.Text);

                if (naziv == "pc_lq") {
                    ram -= 2 * repeat;
                    cpu -= repeat;
                    hdd -= 250 * repeat;
                    cooler -= repeat;
                }
                else if (naziv == "pc_mq") {
                    ram -= 4 * repeat;
                    cpu -= 2 * repeat;
                    hdd -= 500 * repeat;
                    cooler -= 2 * repeat;
                }
                else if (naziv == "pc_hq") {
                    ram -= 8 * repeat;
                    cpu -= 4 * repeat;
                    hdd -= 1000 * repeat;
                    cooler -= 3 * repeat;
                }

                uRam = cRam * ram;
                uCpu = cCpu * cpu;
                uHdd = cHdd * hdd;
                uCooler = cCooler * cooler;

                kolicina += repeat;
                ukupno = cena * kolicina;

                azurirajRacunare();
                azurirajDelove();

                MessageBox.Show("Uspesno sastavljanje");
            }
        }
        
    }
}

