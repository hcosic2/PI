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
    public partial class Narudzba : Form
    {
        public float ukupnaCijena { get; set; }
        public int idNarudzba { get; set; }
        korisnik korisnik1;

        List<stavke> lista = new List<stavke>();
        //Potrebno za mrežno slanje
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];

        private Socket netSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgs2 = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer2 = new byte[1024];

        public Narudzba(korisnik korisnik1)
        {
            InitializeComponent();
            //Mrežno slanje
            netSocket.ExclusiveAddressUse = false;
            netSocket2.ExclusiveAddressUse = false;
            netClientServerArgs2.Completed += netClientServerArgs2Radnja;
            netClientServerArgs.SetBuffer(netSocketBuffer, 0, 1024);
            netClientServerArgs2.SetBuffer(netSocketBuffer2, 0, 1024);
            this.korisnik1 = korisnik1;
            //Punjenje combobox-a dobavljači
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT naziv FROM dobavljaci");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            foreach (DataRow dr in tablica.Rows)
            {
                odabirDobavljaca.Items.Add(dr[0].ToString());
            }
            baza.Instanca.zatvoriVezu();
            //Ispis ulogiranog korisnika
            kIme.Text = korisnik1.korIme;
        }
        /// <summary>
        /// Na događaj odabira ponuđenog dobavljača iz comboboxa
        /// puni se combobox s artiklima. Prikazuju se samo artikli koje dobavlja
        /// odabrani dobavljač.
        /// </summary>
        private void odabirDobavljaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Punjenje combobox-a artikli
            odabirArtikla.Items.Clear();
            int id = baza.Instanca.dohvatiBroj("SELECT id FROM dobavljaci where naziv= '" + odabirDobavljaca.Text + "';");
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT naziv FROM artikli where dobavljac= '" + id + "';");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            foreach (DataRow dr in tablica.Rows)
            {
                odabirArtikla.Items.Add(dr[0].ToString());
            }
            baza.Instanca.zatvoriVezu();
        }
        /// <summary>
        /// Klikom na gumb "Dodaj stavku" provjerava se točnost unesenih podataka.
        /// Ukoliko je sve ispravno kreira se novi objekt tipa stavke i sprema se u listu.
        /// Navedena lista se ispisuje u datagridview i tako vidimo podatke o naručenoj stavci.
        /// </summary>
        private void dodajStavku_Click(object sender, EventArgs e)
        {
            int provjera = 0;
            if (int.TryParse(unosKolicine.Text, out provjera) && int.Parse(unosKolicine.Text) > 0 && odabirArtikla.Text != "")
            {
                //Ispis cijene u dgv-u
                string cijena;
                MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT cijena FROM artikli where naziv= '" + odabirArtikla.Text + "';");
                DataTable tablica = new DataTable();
                tablica.Load(reader);
                cijena = tablica.Rows[0][0].ToString();
                baza.Instanca.zatvoriVezu();
                float ukupno = float.Parse(unosKolicine.Text) * float.Parse(cijena);
                ukupnaCijena += ukupno;
                ispisUkupneCijene.Text = ukupnaCijena.ToString("0.00 kn");
                //Punjenje dgv-a stavkama narudžbe
                odabirDobavljaca.Enabled = false;
                int idArtikla = baza.Instanca.dohvatiBroj("SELECT id FROM artikli where naziv= '" + odabirArtikla.Text + "';");
                stavke stavka = new stavke(idArtikla, odabirArtikla.Text, int.Parse(unosKolicine.Text), cijena + " kn", ukupno.ToString("0.00 kn"));
                lista.Add(stavka);
                BindingSource bs = new BindingSource();
                bs.DataSource = lista;
                ispisStavki.DataSource = bs;
                unosKolicine.Text = "";
                odabirArtikla.Items.Remove(odabirArtikla.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nepotpuno uneseni podaci. Pokušajte opet.");
            }
        }
        /// <summary>
        /// Klikom na gumb "Naruči" provjerava se ima li dodanih stavki odnosno ima li stavki prikazanih
        /// na datagridview-u. Ukoliko postoje dodane stavke kreira se nova narudžba te se podaci
        /// upisuju u bazu. 
        /// </summary>
        private void naruciRobu_Click(object sender, EventArgs e)
        {
            if (ispisStavki.DataSource == null)
            {
                MessageBox.Show("Narudžba je prazna. Dodajte stavke narudžbe.");
            }
            else
            {
                int dobavljacId = baza.Instanca.dohvatiBroj("SELECT id FROM dobavljaci where naziv= '" + odabirDobavljaca.Text + "';");
                baza.Instanca.izvrsiUpit("INSERT INTO narudzba values (default, NOW(), '" + korisnik1.id + "', '"+ "poslano" +"')");

                foreach (var element in lista)
                {
                    idNarudzba = baza.Instanca.dohvatiBroj("SELECT MAX(id) FROM narudzba");
                    baza.Instanca.izvrsiUpit("INSERT INTO stavke_narudzbe VALUES(default, '" + element.Šifra + "','" + idNarudzba + "','" + element.Količina + "');");
                }
                postaviDestinaciju();
                posaljiPoruku(idNarudzba.ToString());
                MessageBox.Show("Narudžba je uspješno poslana!");
                ispisStavki.Rows.Clear();
                ispisStavki.Refresh();
                ispisStavki.DataSource = null;
                odabirDobavljaca.Enabled = true;
                ispisUkupneCijene.Text = "";
                odabirDobavljaca.SelectedIndex = 0;
                ukupnaCijena = 0;
            }
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
        /// <summary>
        /// Klikom na label "natrag" aplikacija nas vraća na formu na kojoj smo bili prije forme na kojoj smo trenutno.
        /// </summary>

        private void otkaziNarudzbu_Click(object sender, EventArgs e)
        {
            lista.Clear();
            ispisStavki.DataSource = null;
            odabirDobavljaca.Enabled = true;
            odabirDobavljaca.SelectedIndex = 0;
            ispisUkupneCijene.Text = "";
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

        //Mrežno slanje
        /// <summary>
        /// Metoda "postaviDestinaciju" postavlja IP adresu lokalnog računala "127.000.000.001."
        /// </summary>
        private void postaviDestinaciju()
        {
            string adresa = "127.000.000.001";
            netClientServerArgs.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(adresa.Replace(" ", "")), 8087);
        }
        /// <summary>
        /// Metoda "posaljiPoruku" pretvara dobivenu poruku u polje byte-ova i to polje byte-ova pohranjuje
        /// u buffer. Taj buffer se postavlja kao buffer u "netClientServerArgs". Nakon toga se nad 
        /// socketom poziva SentToAsync koja kao parametar prima "netClientServerArgs". Te šalje poruku drugoj aplikaciji.
        /// </summary>
        /// <param name="poruka">Poruka odnosno Id narudžbe koju preko mreže jedna aplikacija šalje drugoj.</param>
        private void posaljiPoruku(string poruka)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(poruka);
            netClientServerArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendToAsync(netClientServerArgs);
        }
        /// <summary>
        /// Funkcija "osluskivanje" povezuje socket s lokalnom adresom i portom.
        /// </summary>
        private void osluskivanje()
        {
            try 
            {
                netSocket2.Bind(new IPEndPoint(IPAddress.Any, 8088));
                netSocket2.ReceiveAsync(netClientServerArgs2);
            }
            catch{}
        }
        /// <summary>
        /// Zavisno o odgovoru dobavljaca ova funkcija postavlja stanje narudzbe odbijeno ukoliko je dobavljac
        /// odbio narudzbu. Odnosno stavlja stanje narudzbe potvrdjeno i ažurira stanje na skladištu ukoliko
        /// je dobavljač potvrdio narudzbu.
        /// </summary>
        /// <param name="poruka">Poruka koju aplikacija prima od druge aplikacije ta poruka sadrži odgovor
        /// dobavljača na poslanu narudzbu.</param>
        private void potvrdaNarudzbe(string poruka)
        {
                string[] rastaviPoruku = poruka.Split(',');
                string stanjePoruke = rastaviPoruku[0];
                string id = rastaviPoruku[1];

                if (stanjePoruke == "0")
                {
                    MessageBox.Show("Narudžba "+ id +" je odbijena!");
                }
                else if (stanjePoruke == "1")
                {
                    MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT id_artikla, kolicina from stavke_narudzbe where id_narudzba ='" + id + "'; ");
                    DataTable tablica = new DataTable();
                    tablica.Load(reader);
                    baza.Instanca.zatvoriVezu();
                    foreach (DataRow dr in tablica.Rows)
                    {
                        baza.Instanca.izvrsiUpit("UPDATE artikli SET kolicina_na_skladistu = kolicina_na_skladistu+'" + dr[1] + "' WHERE id='" + dr[0] + "';");
                    }
                    MessageBox.Show("Narudžba "+ id +" je odobrena!");
                }
        }
        /// <summary>
        /// Ukoliko je zadnja operacija socketa = recive metoda poziva drugu metodu "potvrda narudzbe" koja se zatim
        /// konvertira iz polja byte-ova u string.
        /// </summary>
        void netClientServerArgs2Radnja(object sender, SocketAsyncEventArgs e)
        {
            if (netClientServerArgs2.LastOperation == SocketAsyncOperation.Receive)
            {
                potvrdaNarudzbe(UTF8Encoding.UTF8.GetString(netClientServerArgs2.Buffer, 0, e.BytesTransferred));
                netSocket2.ReceiveAsync(netClientServerArgs2);
            }
        }

        private void Narudzba_Load(object sender, EventArgs e)
        {
            osluskivanje();
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

        private void natrag_MouseMove(object sender, MouseEventArgs e)
        {
            natrag.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void natrag_MouseLeave(object sender, EventArgs e)
        {
            natrag.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
