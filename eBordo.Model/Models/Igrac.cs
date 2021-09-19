using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Igrac
    {
        public int igracId { get; set; }
        public Korisnik korisnik { get; set; }
        public string pozicija { get; set; }
        public string boljaNoga { get; set; }
        public IgracStatistika igracStatistika { get; set; }
        public IgracSkills igracSkills { get; set; }
        public Ugovor ugovor { get; set; }
    }
}
