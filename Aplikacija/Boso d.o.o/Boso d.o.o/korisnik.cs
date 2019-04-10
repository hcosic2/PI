using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boso_d.o.o
{
    public class korisnik
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public int zanimanje { get; set; }
        public string korIme { get; set; }
        public string lozinka { get; set; }
        public string eMail { get; set; }

        public korisnik(int id, string ime, string prezime, int zanimanje, string korIme, string lozinka, string eMail)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.zanimanje = zanimanje;
            this.korIme = korIme;
            this.lozinka = lozinka;
            this.eMail = eMail;
        }
    }
}
