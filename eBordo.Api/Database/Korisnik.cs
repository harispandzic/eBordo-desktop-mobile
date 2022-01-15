using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Korisnik
    {
        public int korisnikId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email{ get; set; }
        public string korisnickoIme { get; set; }
        public string lozinkaHash { get; set; }
        public string lozinkaSalt { get; set; }
        public bool isAktivan { get; set; }

        public Drzava drzavljanstvo { get; set; }
        public int drzavljanstvoId { get; set; }

        public Grad gradRodjenja { get; set; }
        public int gradRodjenjaId { get; set; }

        public Igrac igrac { get; set; }
        public int igracId { get; set; }

        public byte[] Slika { get; set; }

        public Trener trener { get; set; }
        public int trenerID { get; set; }

        public bool isIgrac { get; set; }
        public bool isTrener { get; set; }
        public bool isAdmin { get; set; }
    }
}
