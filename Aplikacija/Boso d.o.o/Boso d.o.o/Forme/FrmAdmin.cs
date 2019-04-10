using Boso_d.o.o.Forme;
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

namespace Boso_d.o.o
{
    public partial class FrmAdmin : Form
    {
        public int korisnikId { get; set; }
        public string korIme { get; set; }
        public FrmAdmin(int korisnikId)
        {
            InitializeComponent();
            this.korisnikId = korisnikId;
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT korime FROM zaposlenik where id= '" + korisnikId + "';");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            korIme = tablica.Rows[0][0].ToString();
            lblKIme.Text = korIme;
            baza.Instanca.zatvoriVezu();
        }

        private void btnStanje_Click(object sender, EventArgs e)
        {
            FrmStanje forma = new FrmStanje(korisnikId);
            this.Hide();
            forma.ShowDialog();
            this.Close();
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            FrmNarudzba forma = new FrmNarudzba(korisnikId);
            this.Hide();
            forma.ShowDialog();
            this.Close();
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
