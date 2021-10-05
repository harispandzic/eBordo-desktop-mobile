using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Korisnik
{
    public class KorisnikInsertRequest
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public int drzavljanstvoId { get; set; }
        public int gradRodjenjaId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
