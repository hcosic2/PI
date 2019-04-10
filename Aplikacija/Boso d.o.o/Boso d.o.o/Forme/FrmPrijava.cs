using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boso_d.o.o
{
    public partial class FrmPrijava : Form
    {
        public int korisnikId { get; set; }
        public FrmPrijava()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            int provjera = baza.Instanca.dohvatiBroj("SELECT count(*) from zaposlenik where korime= '" + txtBoxKorIme.Text + "' and lozinka= '" + txtBoxLozinka.Text + "'; ");

            if (provjera != 0)
            {
                if (txtBoxKorIme.Text == "" && txtBoxLozinka.Text == "")
                {
                    MessageBox.Show("Upišite korisničke podatke");
                }
                else
                {
                    korisnikId = baza.Instanca.dohvatiBroj("SELECT id from zaposlenik where korime= '" + txtBoxKorIme.Text + "' and lozinka= '" + txtBoxLozinka.Text + "'; ");
                    int zanimanje = baza.Instanca.dohvatiBroj("SELECT zanimanje from zaposlenik where korime= '" + txtBoxKorIme.Text + "' and lozinka= '" + txtBoxLozinka.Text + "'; ");

                    if (zanimanje == 1)
                    {
                        MessageBox.Show("Dobrodošao " + txtBoxKorIme.Text + " ");
                        FrmAdmin forma = new FrmAdmin(korisnikId);
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dobrodošao " + txtBoxKorIme.Text + " ");
                        FrmZaposlenik forma = new FrmZaposlenik(korisnikId);
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji. Pokušajte ponovo.");
            }
        }

        private void lblIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblIzlaz_MouseMove(object sender, MouseEventArgs e)
        {
            lblIzlaz.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void lblIzlaz_MouseLeave(object sender, EventArgs e)
        {
            lblIzlaz.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
