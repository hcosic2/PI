using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Boso_d.o.o
{
    class baza
    {
        private MySqlConnection connection;

        private static baza instanca;


        public static baza Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new baza("localhost", "pibaza", "root", "");
                }
                return instanca;
            }
        }

        private baza(string server, string baza, string userId, string lozinka)
        {
            string connectionString = "SERVER=" + server + ";PORT=3306;" + "DATABASE=" + baza + ";" +
                "UID=" + userId + ";" + "PASSWORD=" + lozinka + ";";
            connection = new MySqlConnection(connectionString);
        }
        /// <summary>
        /// Funkcija za otvaranje veze
        /// </summary>
        public bool otvoriVezu()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Funkcija za zatvaranje veze
        /// </summary>
        public bool zatvoriVezu()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Funkcija "izvrsiUpit" izvršava UPDATE, INSERT, DELETE upite na bazi.
        /// </summary>
        /// <param name="sqlUpit">SQL upit koji prosljeđujemo funkciji</param>
        public void izvrsiUpit(string sqlUpit)
        {
            if (this.otvoriVezu())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(sqlUpit, connection);
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.Number.ToString());
                }
                finally
                {
                    this.zatvoriVezu();
                }
            }
        }
        /// <summary>
        /// Funkcija "dohvatiDataReader" na temelju SQL upita dohvaća više podataka iz baze.
        /// </summary>
        /// <param name="sqlUpit">SQL upit koji prosljeđujemo funkciji</param>
        /// <returns>Funkcija vraća rezultat upita odnosno sve podatke koji su dohvaćeni iz baze</returns>
        public MySqlDataReader dohvatiDataReader(string sqlUpit)
        {
            MySqlDataReader rezultatUpita = null;
            if (this.otvoriVezu())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(sqlUpit, connection);
                    rezultatUpita = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return rezultatUpita;
        }
        /// <summary>
        /// Funkcija "dohvatiBroj" na temelju SQL upita vraća jedan broj iz baze.
        /// </summary>
        /// <param name="sqlUpit">SQL upit koji prosljeđujemo funkciji</param>
        /// <returns>Funkcija vraća rezultat upita koji je isključivo jedan broj</returns>
        public int dohvatiBroj(string sqlUpit)
        {
            int broj = -1;
            if (this.otvoriVezu())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(sqlUpit, connection);
                    broj = int.Parse(command.ExecuteScalar().ToString());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Pogrešan upit");
                }
                finally
                {
                    this.zatvoriVezu();
                }
            }
            return broj;
        }
    }
}
