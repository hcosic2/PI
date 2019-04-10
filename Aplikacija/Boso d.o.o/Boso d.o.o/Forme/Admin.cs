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
    public partial class Admin : Form
    {
        korisnik korisnik1;
        public Admin(korisnik korisnik1)
        {
            InitializeComponent();
            this.korisnik1 = korisnik1;
            kIme.Text = korisnik1.korIme;
        }

        private void stanjeSkladista_Click(object sender, EventArgs e)
        {
            Stanje forma = new Stanje(korisnik1);
            this.Hide();
            forma.ShowDialog();
            this.Close();
        }

        private void narudzbaRobe_Click(object sender, EventArgs e)
        {
            Narudzba forma = new Narudzba(korisnik1);
            this.Hide();
            forma.ShowDialog();
            this.Close();
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
