using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boso_d.o.o
{
    class stavke
    {
        public int Šifra { get; set; }
        public string Naziv { get; set; }
        public int Količina { get; set; }
        public string Cijena { get; set; }
        public string Ukupno { get; set; }

        public stavke(int Id, string Naziv, int Količina, string Cijena, string Ukupno)
        {
            this.Šifra = Id;
            this.Naziv = Naziv;
            this.Količina = Količina;
            this.Cijena = Cijena;
            this.Ukupno = Ukupno;
        }
    }
}
