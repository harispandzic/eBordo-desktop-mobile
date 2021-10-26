using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Trener
    {
        public int trenerId { get; set; }
        public DateTime prvaZvanicnaUtakmica { get; set; }
        public float trzisnaVrijednost { get; set; }
        public TrenerStatistika trenerStatistika { get; set; }
        public Ugovor ugovor { get; set; }
        public Korisnik korisnik { get; set; }
        public Formacija formacija { get; set; }
        public TrenerskaLicenca trenerskaLicenca { get; set; }
    }
}
