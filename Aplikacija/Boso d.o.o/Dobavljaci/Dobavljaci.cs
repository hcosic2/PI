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
    public partial class Dobavljaci : Form
    {
        //Potrebno za mrežno slanje
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];

        private Socket netSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketServerArgs2 = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer2 = new byte[1024];
        public int idNarudzbe { get; set; }
        public int stanjeNarudzbe { get; set; }

        List<int> lista = new List<int>();
        dobavljac dobavljac1;

        public Dobavljaci(dobavljac dobavljac1)
        {
            InitializeComponent();
            this.dobavljac1 = dobavljac1;
            netSocket.ExclusiveAddressUse = false;
            netSocket2.ExclusiveAddressUse = false;
            netSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            netSocket2.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            netSocketServerArgs.Completed += netSocketServerArgsRadnja;
            netSocketServerArgs.SetBuffer(netSocketBuffer, 0, 1024);
            netSocketServerArgs2.SetBuffer(netSocketBuffer2, 0, 1024);
            imeKorisnika.Text = dobavljac1.naziv;
        }
        /// <summary>
        /// Funkcija pregledNarudzbi iz liste brojeva sprema te iste borjeve u varijablu tipa string
        /// koju kasnije prosljeđuje u upitu. Potom dohvaća sve narudžbe iz baze za određenog dobavljača.
        /// </summary>
        /// <param name="lista">lista id-eva narudžbi koje su naručene</param>
        private void pregledNarudzbi(List<int> lista) 
        {
            string skupId = "";
            int brojac = 0;
            foreach (int id in lista)
            {
                brojac++;
                if (brojac == lista.Count)
                {
                    skupId += "'" + id + "'";
                }
                else
                {
                    skupId += "'" + id + "'" + ",";
                }
            }
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT narudzba.id as Id, narudzba.datum as Datum, zaposlenik.korime as Narucio, stanje as Stanje from narudzba JOIN stavke_narudzbe ON narudzba.id=stavke_narudzbe.id_narudzba JOIN artikli ON artikli.id=stavke_narudzbe.id_artikla JOIN zaposlenik ON zaposlenik.id=narudzba.id_zaposlenik where narudzba.id IN(" + skupId + ") and artikli.dobavljac='" + dobavljac1.id + "' and narudzba.stanje= '"+"poslano"+"' ;");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            narudzbePrikaz.DataSource = tablica;
            baza.Instanca.zatvoriVezu();
        }
        /// <summary>
        /// Funkcija "zaprimiId" poruku odnosno id narudžbe od druge aplikacije. Zatim dohvaća sve stavke narudžbe
        /// koje imaju taj id koji je primljen od druge aplikacije. Nakon toga ispisuje sve te stavke narudžbe
        /// u datagridview-u. Također navedena funkcija dohvaća ukupnu cijenu te narudžbe te ju ispisuje u textBox.
        /// </summary>
        /// <param name="poruka">Poruka, odnosno id narudžbe koji je primljen do druge aplikacije</param>
        private void zaprimiId(string poruka)
        {
            narudzbePrikaz.Invoke((MethodInvoker)delegate
            {
                idNarudzbe = int.Parse(poruka);
                lista.Add(int.Parse(poruka));
                pregledNarudzbi(lista);
            });
        }
        /// <summary>
        /// Funkcija "osluskivanje" povezuje socket s lokalnom adresom i portom
        /// </summary>
        private void osluskivanje()
        {
            netSocket.Bind(new IPEndPoint(IPAddress.Any, 8087));
            netSocket.ReceiveAsync(netSocketServerArgs);
        }
        /// <summary>
        /// Ukoliko je zadnja operacija socketa = recive, metoda poziva drugu metodu "zaprimiId" koja se zatim
        /// konvertira iz polja byte-ova u string
        /// </summary>
        void netSocketServerArgsRadnja(object sender, SocketAsyncEventArgs e)
        {
            if (netSocketServerArgs.LastOperation == SocketAsyncOperation.Receive)
            {
                zaprimiId(UTF8Encoding.UTF8.GetString(netSocketServerArgs.Buffer, 0, e.BytesTransferred));
                netSocket.ReceiveAsync(netSocketServerArgs);
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

        private void Dobavljaci_Load(object sender, EventArgs e)
        {
            prihvatiNarudzbu.Enabled = false;
            odbijNarudzbu.Enabled = false;
            osluskivanje();
        }
        //Mrežno slanje
        /// <summary>
        /// Metoda "postaviDestinaciju" postavlja IP adresu lokalnog računala "127.000.000.001"
        /// </summary>
        private void postaviDestinaciju()
        {
            string adresa = "127.000.000.001";
            netSocketServerArgs2.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(adresa.Replace(" ", "")), 8088);
        }
        /// <summary>
        /// Metoda "posaljiPoruku" pretvara unesenu poruku u polje byte-ova i to polje byte-ova pohranjuje
        /// u buffer. Taj buffer se postavlja kao buffer u "netClientServerArgs". Nakon toga se nad 
        /// socketom poziva SentToAsync koja kao parametar prima "netClientServerArgs". Te šalje navedenu poruku drugoj aplikaciji.
        /// </summary>
        /// <param name="poruka">Poruka odnosno potvrda/odbijanje koju preko mreže jedna aplikacija šalje drugoj</param>
        private void posaljiPoruku(string poruka)
        {
            netSocketBuffer2 = UTF8Encoding.UTF8.GetBytes(poruka);
            netSocketServerArgs2.SetBuffer(netSocketBuffer2, 0, netSocketBuffer2.Length);
            netSocket2.SendToAsync(netSocketServerArgs2);
        }
        private void posaljiOdgovor(int stanje) 
        {
            string porukaZaSlanje = stanje.ToString() + "," + narudzbePrikaz.SelectedRows[0].Cells[0].Value.ToString();
            postaviDestinaciju();
            posaljiPoruku(porukaZaSlanje);
            pregledNarudzbi(lista);
            ispisUkupno.Clear();
            prihvatiNarudzbu.Enabled = false;
            odbijNarudzbu.Enabled = false;
            stavkeNarudzbePrikaz.DataSource = null;
        }
        /// <summary>
        /// Klikom na gumb "Prihvati narudzbu" drugoj aplikaciji šalje se vrijednost varijable "stanjeNarudzbe".
        /// </summary>
        private void prihvatiNarudzbu_Click(object sender, EventArgs e)
        {
            stanjeNarudzbe = 1;
            baza.Instanca.izvrsiUpit("UPDATE narudzba SET stanje = 'potvrdjeno' WHERE id = '" + narudzbePrikaz.SelectedRows[0].Cells[0].Value.ToString() + "';");
            posaljiOdgovor(stanjeNarudzbe);        
        }
        /// <summary>
        /// Klikom na gumb "Odbij narudzbu" drugoj aplikaciji šalje se vrijednost varijable "stanjeNarudzbe".
        /// </summary>
        private void odbijNarudzbu_Click(object sender, EventArgs e)
        {
            stanjeNarudzbe = 0;
            baza.Instanca.izvrsiUpit("UPDATE narudzba SET stanje = 'odbijeno' WHERE id = '" + narudzbePrikaz.SelectedRows[0].Cells[0].Value.ToString() + "';");
            posaljiOdgovor(stanjeNarudzbe); 
        }

        private void narudzbePrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT naziv as Artikl, stn.id_narudzba as Narudzba, stn.kolicina as Količina, concat(art.cijena,' kn') as Cijena, concat(round(art.cijena*stn.kolicina,2), ' kn') Ukupno from stavke_narudzbe stn JOIN artikli art ON art.id = stn.id_artikla AND id_narudzba = '" + narudzbePrikaz.SelectedRows[0].Cells[0].Value.ToString() + "'; ");
            DataTable tablica = new DataTable();
            tablica.Load(reader);
            stavkeNarudzbePrikaz.DataSource = tablica;
            baza.Instanca.zatvoriVezu();
            //Ukupna cijena
            MySqlDataReader reader2 = baza.Instanca.dohvatiDataReader("SELECT sum(round(art.cijena*stn.kolicina,2)) sveukupno from stavke_narudzbe stn JOIN artikli art ON art.id = stn.id_artikla AND id_narudzba = '" + narudzbePrikaz.SelectedRows[0].Cells[0].Value.ToString() + "';");
            DataTable tablica2 = new DataTable();
            tablica2.Load(reader2);
            ispisUkupno.Text = tablica2.Rows[0][0].ToString() + " kn";
            baza.Instanca.zatvoriVezu();
            prihvatiNarudzbu.Enabled = true;
            odbijNarudzbu.Enabled = true;
        }
    }
}
