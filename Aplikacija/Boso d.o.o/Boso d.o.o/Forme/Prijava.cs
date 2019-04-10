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

namespace Boso_d.o.o
{
    public partial class Prijava : Form
    {
        korisnik korisnik1;
        public Prijava()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Klikom na gumb "Prijava" vrši se provjera upisanih podataka. Tek kada su svi podaci ispravno upisani
        /// prelazi se na provjeru zanimanja korisnika. Ukoliko je zanimanje korisnika admin otvara se admin način rada.
        /// U svim drugim slučajevima otvara se korisnički način rada.
        /// </summary>
        private void potvrdaPrijave_Click(object sender, EventArgs e)
        {
            
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT id, ime, prezime, zanimanje, korime, lozinka, e_mail  from zaposlenik where korime= '" + korImeUnos.Text + "' and lozinka= '" + lozinkaUnos.Text + "'; ");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            baza.Instanca.zatvoriVezu();
            try
            {   
                korisnik1 = new korisnik(int.Parse(tablica.Rows[0][0].ToString()), tablica.Rows[0][1].ToString(), tablica.Rows[0][2].ToString(), int.Parse(tablica.Rows[0][3].ToString()), tablica.Rows[0][4].ToString(), tablica.Rows[0][5].ToString(), tablica.Rows[0][6].ToString());
                
                    if (korisnik1.zanimanje == 1)
                    {
                        MessageBox.Show("Dobrodošao " + korImeUnos.Text + " ");
                        Admin forma = new Admin(korisnik1);
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dobrodošao " + korImeUnos.Text + " ");
                        Zaposlenik forma = new Zaposlenik(korisnik1);
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                    }                            
            }
            catch
            {
                MessageBox.Show("Netočno upisani podaci!");
            }
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
