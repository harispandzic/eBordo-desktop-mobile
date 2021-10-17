using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Igrac
    {
        public int igracId { get; set; }
        public Korisnik korisnik { get; set; }
        public int korisnikId { get; set; }
        public float visina { get; set; }
        public int tezina { get; set; }
        public int brojDresa { get; set; }
        public float trzisnaVrijednost { get; set; }
        public int jacinaSlabijeNoge { get; set; }
        public string napomeneOIgracu { get; set; }

        public Pozicija pozicija { get; set; }
        public int pozicijaId { get; set; }

        public BoljaNoga boljaNoga { get; set; }

        public IgracStatistika igracStatistika { get; set; }
        public int igracStatistikaId { get; set; }

        public IgracSkills igracSkills { get; set; }
        public int igracSkillsId { get; set; }

        public Ugovor ugovor { get; set; }
        public int ugovorId { get; set; }

    }
}
