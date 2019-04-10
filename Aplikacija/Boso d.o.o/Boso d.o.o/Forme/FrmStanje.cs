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
    public partial class FrmStanje : Form
    {
        public int korisnikId { get; set; }
        public int korisnikZanimanje { get; set; }
        public string korIme { get; set; }
        public FrmStanje(int korisnikId)
        {
            //Ispis stanja na skladištu u dgv
            InitializeComponent();
            this.korisnikId = korisnikId;
            MySqlDataReader rezultati = baza.Instanca.dohvatiDataReader("SELECT naziv as Naziv, cijena as Cijena, kolicina_na_skladistu as Količina FROM artikli");
            DataTable tablica = new DataTable();
            tablica.Load(rezultati);
            dgvStanje.DataSource = tablica;
            baza.Instanca.zatvoriVezu();
            //Ulogirani korisnik
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT korime FROM zaposlenik where id= '" + korisnikId + "';");
            DataTable tablica2 = new DataTable();
            tablica2.Load(reader);
            korIme = tablica2.Rows[0][0].ToString();
            lblKIme.Text = korIme;
            baza.Instanca.zatvoriVezu();
        }

        private void lblOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava forma = new FrmPrijava();
            this.Hide();
            forma.ShowDialog();
            this.Close();
        }

        private void lblOdjava_MouseMove(object sender, MouseEventArgs e)
        {
            lblOdjava.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void lblOdjava_MouseLeave(object sender, EventArgs e)
        {
            lblOdjava.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void lblNatrag_Click(object sender, EventArgs e)
        {
            korisnikZanimanje = baza.Instanca.dohvatiBroj("SELECT zanimanje FROM zaposlenik where id= '" + korisnikId + "' ");
            if (korisnikZanimanje == 1)
            {
                FrmAdmin forma = new FrmAdmin(korisnikId);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                FrmZaposlenik forma = new FrmZaposlenik(korisnikId);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }

        private void lblNatrag_MouseMove_1(object sender, MouseEventArgs e)
        {
            lblNatrag.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void lblNatrag_MouseLeave(object sender, EventArgs e)
        {
            lblNatrag.ForeColor = Color.FromArgb(0, 0, 0);
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
