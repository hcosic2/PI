using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobavljaci
{
    public partial class PrijavaDobavljaci : Form
    {
        public PrijavaDobavljaci()
        {
            InitializeComponent();
        }
        public int dobavljacId { get; set; }
        dobavljac dobavljac1;
        private void potvrdiPrijavu_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT id, naziv, adresa, korime, lozinka from dobavljaci where korime= '" + korImeUnos.Text + "' and lozinka= '" + lozinkaUnos.Text + "'; ");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            baza.Instanca.zatvoriVezu();

            try
            {
                dobavljac1 = new dobavljac(int.Parse(tablica.Rows[0][0].ToString()), tablica.Rows[0][1].ToString(), tablica.Rows[0][2].ToString(), tablica.Rows[0][3].ToString(), tablica.Rows[0][4].ToString());
                MessageBox.Show("Dobrodošao " + korImeUnos.Text + " ");
                Dobavljaci forma = new Dobavljaci(dobavljac1);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
            catch
            {

                MessageBox.Show("Netočno upisani podaci!");
            }

            //if (provjera != 0)
            //{
            //    if (korImeUnos.Text == "" && lozinkaUnos.Text == "")
            //    {
            //        MessageBox.Show("Upišite korisničke podatke");
            //    }
            //    else
            //    {
            //        dobavljacId = baza.Instanca.dohvatiBroj("SELECT id from dobavljaci where korime= '" + korImeUnos.Text + "' and lozinka= '" + lozinkaUnos.Text + "'; ");
            //        MessageBox.Show("Dobrodošao " + korImeUnos.Text + " ");
            //        Dobavljaci forma = new Dobavljaci(dobavljacId);
            //        this.Hide();
            //        forma.ShowDialog();
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Korisnik ne postoji. Pokušajte ponovo.");
            //}
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izlaz_MouseMove(object sender, MouseEventArgs e)
        {
            izlaz.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void izlaz_MouseLeave(object sender, EventArgs e)
        {
            izlaz.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
