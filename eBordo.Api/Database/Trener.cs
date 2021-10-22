using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Trener
    {
        public int trenerId { get; set; }
        public DateTime prvaZvanicnaUtakmica { get; set; }
        public float trzisnaVrijednost { get; set; }

        public TrenerStatistika trenerStatistika { get; set; }
        public int trenerStatistikaId { get; set; }

        public Ugovor ugovor { get; set; }
        public int ugovorId { get; set; }

        public Korisnik korisnik { get; set; }
        public int korisnikId { get; set; }

        public Formacija formacija { get; set; }
        public int formacijaId { get; set; }

        public TrenerskaLicenca trenerskaLicenca { get; set; }
        public int trenerskaLicencaId { get; set; }
    }
}
