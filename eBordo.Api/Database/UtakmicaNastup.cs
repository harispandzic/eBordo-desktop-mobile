using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class UtakmicaNastup
    {
        public int utakmicaNastupId { get; set; }
        public Igrac igrac { get; set; }
        public int igracId { get; set; }
        public Trener trener { get; set; }
        public int trenerId { get; set; }

        public int minute { get; set; }
        public int golovi { get; set; }
        public int asistencije { get; set; }
        public int zutiKartoni { get; set; }
        public int crveniKartoni { get; set; }
        public int ocjena { get; set; }
        public string komentar { get; set; }
    }
}
