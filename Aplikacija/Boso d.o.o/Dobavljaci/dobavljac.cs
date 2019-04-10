using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobavljaci
{
    public class dobavljac
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string korIme { get; set; }
        public string lozinka { get; set; }

        public dobavljac(int id, string naziv, string adresa, string korIme, string lozinka)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
            this.korIme = korIme;
            this.lozinka = lozinka;
        }
    }
}
