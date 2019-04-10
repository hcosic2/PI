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

namespace Boso_d.o.o.Forme
{
    public partial class FrmNarudzba : Form
    {
        public int korisnikId { get; set; }
        public string korIme { get; set; }
        public int korisnikZanimanje { get; set; }
        public float ukupnaCijena { get; set; }
        public int idNarudzba { get; set; }
        public int stanjeNarudzbe { get; set; }

        List<stavke> lista = new List<stavke>();
        //Potrebno za mrežno slanje
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[10240]; 

        public FrmNarudzba(int korisnikId)
        {
            InitializeComponent();
            //Mrežno slanje
            netSocket.ExclusiveAddressUse = false;
            //netClientServerArgs.Completed += netClientServerArgs_Completed;
            netClientServerArgs.SetBuffer(netSocketBuffer, 0, 1024);
            //Punjenje combobox-a dobavljači
            this.korisnikId = korisnikId;
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT naziv FROM dobavljaci");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            foreach (DataRow dr in tablica.Rows)
            {
                comBoxDobavljac.Items.Add(dr[0].ToString());
            }
            //Ispis ulogiranog korisnika
            baza.Instanca.zatvoriVezu();
            MySqlDataReader reader2 = baza.Instanca.dohvatiDataReader("SELECT korime FROM zaposlenik where id= '" + korisnikId + "';");
            DataTable tablica2 = new DataTable();
            tablica2.Load(reader2);
            korIme = tablica2.Rows[0][0].ToString();
            lblKIme.Text = korIme;
            baza.Instanca.zatvoriVezu();
        }
        private void comBoxDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Punjenje combobox-a artikli
            comBoxArtikl.Items.Clear();
            int id = baza.Instanca.dohvatiBroj("SELECT id FROM dobavljaci where naziv= '" + comBoxDobavljac.Text + "';");
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT naziv FROM artikli where dobavljac= '" + id + "';");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            foreach (DataRow dr in tablica.Rows)
            {
                comBoxArtikl.Items.Add(dr[0].ToString());
            }
            baza.Instanca.zatvoriVezu();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int provjera = 0;
            if (int.TryParse(txtBoxKolicina.Text, out provjera) && int.Parse(txtBoxKolicina.Text) > 0 && comBoxArtikl.Text != "")
            {
                //Ispis cijene u dgv-u
                string cijena;
                MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT cijena FROM artikli where naziv= '" + comBoxArtikl.Text + "';");
                DataTable tablica = new DataTable();
                tablica.Load(reader);
                cijena = tablica.Rows[0][0].ToString();
                baza.Instanca.zatvoriVezu();
                float ukupno = float.Parse(txtBoxKolicina.Text) * float.Parse(cijena);
                ukupnaCijena += ukupno;
                txtBoxUkupnaCijena.Text = ukupnaCijena.ToString("0.00 kn");
                //Punjenje dgv-a stavkama narudžbe
                comBoxDobavljac.Enabled = false;
                int idArtikla = baza.Instanca.dohvatiBroj("SELECT id FROM artikli where naziv= '" + comBoxArtikl.Text + "';");
                stavke stavka = new stavke(idArtikla, comBoxArtikl.Text, int.Parse(txtBoxKolicina.Text), cijena + " kn", ukupno.ToString("0.00"));
                lista.Add(stavka);
                BindingSource bs = new BindingSource();
                bs.DataSource = lista;
                dgvNarudzba.DataSource = bs;
                txtBoxKolicina.Text = "";
                comBoxArtikl.Items.Remove(comBoxArtikl.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nepotpuno uneseni podaci. Pokušajte opet.");
            }
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            if (dgvNarudzba.DataSource == null)
            {
                MessageBox.Show("Narudžba je prazna. Dodajte stavke narudžbe.");
            }
            else
            {
                int dobavljacId = baza.Instanca.dohvatiBroj("SELECT id FROM dobavljaci where naziv= '" + comBoxDobavljac.Text + "';");
                baza.Instanca.izvrsiUpit("INSERT INTO narudzba values (default, NOW(), '" + korisnikId + "', '" + ukupnaCijena.ToString("0.00") + "')");

                foreach (var element in lista)
                {
                    baza.Instanca.izvrsiUpit("UPDATE artikli SET kolicina_na_skladistu = kolicina_na_skladistu+'" + element.Količina + "' WHERE id='" + element.Šifra + "';");
                    idNarudzba = baza.Instanca.dohvatiBroj("SELECT MAX(id) FROM narudzba");
                    baza.Instanca.izvrsiUpit("INSERT INTO stavke_narudzbe VALUES(default, '" + element.Šifra + "','" + idNarudzba + "','" + element.Količina + "','" + element.Ukupno.ToString() + "');");
                }
                MessageBox.Show("Narudžba je uspješno kreirana!");
                postaviDestinaciju();
                posaljiPoruku(idNarudzba.ToString());
                dgvNarudzba.Rows.Clear();
                dgvNarudzba.Refresh();
                dgvNarudzba.DataSource = null;
                comBoxDobavljac.Enabled = true;
                txtBoxUkupnaCijena.Text = "";
                comBoxDobavljac.SelectedIndex = 0;
            }
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

        private void lblNatrag_MouseMove(object sender, MouseEventArgs e)
        {
            lblNatrag.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void lblNatrag_MouseLeave(object sender, EventArgs e)
        {
            lblNatrag.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            lista.Clear();
            dgvNarudzba.DataSource = null;
            comBoxDobavljac.Enabled = true;
            comBoxDobavljac.SelectedIndex = 0;
            txtBoxUkupnaCijena.Text = "";
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
        //Mrežno slanje
        private void postaviDestinaciju()
        {
            string adresa = "127.000.000.001";
            netClientServerArgs.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(adresa.Replace(" ", "")), 8087);
        }
        private void posaljiPoruku(string message)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netClientServerArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendToAsync(netClientServerArgs);
        }
        //private void zaprimiStanjeNarudzbe(string poruka)
        //{
        //    dgvNarudzba.Invoke((MethodInvoker)delegate
        //    {
        //        stanjeNarudzbe = int.Parse(poruka);
        //        textBox1.Text = stanjeNarudzbe.ToString();
        //    });
        //}
        //void netClientServerArgs_Completed(object sender, SocketAsyncEventArgs e)
        //{
        //    if (netClientServerArgs.LastOperation == SocketAsyncOperation.Receive)
        //    {
        //        zaprimiStanjeNarudzbe(UTF8Encoding.UTF8.GetString(netClientServerArgs.Buffer, 0, e.BytesTransferred));
        //        netSocket.ReceiveAsync(netClientServerArgs);
        //    }
        //}
        //private void osluskivanje()
        //{
        //    netSocket.Bind(new IPEndPoint(IPAddress.Any, 8087));
        //    netSocket.ReceiveAsync(netClientServerArgs);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
           // osluskivanje();
        }
    }
}
