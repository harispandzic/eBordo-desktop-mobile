using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Korisnik
    {
        public int korisnikId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string korisnickoIme { get; set; }
        public Drzava drzavljanstvo { get; set; }
        public Grad gradRodjenja { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool isIgrac { get; set; }
        public bool isTrener { get; set; }
        public bool isAdmin { get; set; }

    }
}
