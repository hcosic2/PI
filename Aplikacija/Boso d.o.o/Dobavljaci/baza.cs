using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Dobavljaci
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

