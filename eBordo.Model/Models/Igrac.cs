using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Igrac
    {
        public int igracId { get; set; }
        public Korisnik korisnik { get; set; }
        public Pozicija pozicija { get; set; }
        public string boljaNoga { get; set; }
        public float visina { get; set; }
        public int tezina { get; set; }
        public int brojDresa { get; set; }
        public float trzisnaVrijednost { get; set; }
        public IgracStatistika igracStatistika { get; set; }
        public IgracSkills igracSkills { get; set; }
        public Ugovor ugovor { get; set; }
    }
}
