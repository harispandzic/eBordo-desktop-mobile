using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class IgracStatistika
    {
        public int igracStatistikaId { get; set; }
        public int brojNastupa { get; set; }
        public int golovi { get; set; }
        public int asistencije { get; set; }
        public int zutiKartoni { get; set; }
        public int crveniKartoni { get; set; }
        public int zbirOcjena { get; set; }
        public float prosjecnaOcjena { get; set; }
    }
}
