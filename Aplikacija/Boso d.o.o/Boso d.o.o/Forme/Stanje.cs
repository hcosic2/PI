using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boso_d.o.o.Forme
{
    public partial class Stanje : Form
    {
        korisnik korisnik1;
        public Stanje(korisnik korisnik1)
        {
            //Ispis stanja na skladištu u dgv
            InitializeComponent();
            this.korisnik1 = korisnik1;
            MySqlDataReader rezultati = baza.Instanca.dohvatiDataReader("SELECT naziv as Naziv, cijena as Cijena, kolicina_na_skladistu as Količina FROM artikli");
            DataTable tablica = new DataTable();
            tablica.Load(rezultati);
            prikazStanja.DataSource = tablica;
            baza.Instanca.zatvoriVezu();
            //Ulogirani korisnik
            kIme.Text = korisnik1.korIme;
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            Prijava forma = new Prijava();
            this.Hide();
            forma.ShowDialog();
            this.Close();
        }

        private void odjava_MouseMove(object sender, MouseEventArgs e)
        {
            odjava.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void odjava_MouseLeave(object sender, EventArgs e)
        {
            odjava.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void natrag_Click(object sender, EventArgs e)
        {
            if (korisnik1.zanimanje == 1)
            {
                Admin forma = new Admin(korisnik1);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                Zaposlenik forma = new Zaposlenik(korisnik1);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }

        private void natrag_MouseMove_1(object sender, MouseEventArgs e)
        {
            natrag.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void natrag_MouseLeave(object sender, EventArgs e)
        {
            natrag.ForeColor = Color.FromArgb(0, 0, 0);
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
