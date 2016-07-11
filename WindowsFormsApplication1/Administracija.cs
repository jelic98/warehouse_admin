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
    public partial class Administracija : Form {

        public Administracija() {
            InitializeComponent();
        }

        private void magacin_Click(object sender, EventArgs e) {
            Magacin magacin = new Magacin();
            magacin.ShowDialog();
        }

        private void radnici_Click(object sender, EventArgs e) {
            Radnici radnici = new Radnici();
            radnici.ShowDialog();
        }

        private void kraj_rada_Click(object sender, EventArgs e) {
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
    }
}
