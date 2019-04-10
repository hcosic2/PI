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
    public partial class FrmDobavljaci : Form
    {
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];
        public int idNarudzbe { get; set; }
        public int stanjeNarudzbe { get; set; }

        private void zaprimiId(string poruka)
        {
            dgvNarudzba.Invoke((MethodInvoker)delegate
            {
                idNarudzbe = int.Parse(poruka);
                MySqlDataReader reader = baza.Instanca.dohvatiDataReader("SELECT naziv as Artikl, stn.id_narudzba as Narudzba, stn.kolicina as Količina, stn.cijena as Cijena from stavke_narudzbe stn JOIN artikli ON artikli.id = stn.id_artikla AND id_narudzba= '" + idNarudzbe + "'; ");
                DataTable tablica = new DataTable();
                tablica.Load(reader);
                dgvNarudzba.DataSource = tablica;
                baza.Instanca.zatvoriVezu();
            });
        }
        public FrmDobavljaci()
        {
            InitializeComponent();
            netSocket.ExclusiveAddressUse = false;
            netSocketServerArgs.Completed += netSocketServerArgs_Completed;
            netSocketServerArgs.SetBuffer(netSocketBuffer, 0, 1024);
        }
        private void osluskivanje()
        {
            netSocket.Bind(new IPEndPoint(IPAddress.Any, 8087));
            netSocket.ReceiveAsync(netSocketServerArgs);
        }
        void netSocketServerArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (netSocketServerArgs.LastOperation == SocketAsyncOperation.Receive)
            {
                zaprimiId(UTF8Encoding.UTF8.GetString(netSocketServerArgs.Buffer, 0, e.BytesTransferred));
                netSocket.ReceiveAsync(netSocketServerArgs);
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

        private void FrmDobavljaci_Load(object sender, EventArgs e)
        {
            osluskivanje();
        }
        //private void posaljiPoruku(string message)
        //{
        //    netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
        //    netSocketServerArgs2.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
        //    netSocket.SendToAsync(netSocketServerArgs2);
        //}

        private void prihvatiNarudzbu_Click(object sender, EventArgs e)
        {
        //    stanjeNarudzbe = 1;
        //    //postaviDestinaciju();
        //    posaljiPoruku(stanjeNarudzbe.ToString());
        //    textBox1.Text = stanjeNarudzbe.ToString();
        }

        private void odbijNarudzbu_Click(object sender, EventArgs e)
        {
        //    stanjeNarudzbe = 0;
        //    //postaviDestinaciju();
        //    posaljiPoruku(stanjeNarudzbe.ToString());
        //    textBox1.Text = stanjeNarudzbe.ToString();
        }
        ////private void postaviDestinaciju()
        ////{
        ////    string adresa = "127.000.000.001";
        ////    netSocketServerArgs2.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(adresa.Replace(" ", "")), 8087);
        ////}
    }
}
