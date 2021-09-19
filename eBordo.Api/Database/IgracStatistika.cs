using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
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
        public float prosjecnaOcjena { get; set; } //na osnovu ocjena sa nastupa

        public Igrac igrac { get; set; }
        public int? igracId { get; set; }
    }
}
