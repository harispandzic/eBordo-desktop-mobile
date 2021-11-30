using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class UtakmicaOcjena
    {
        public int utakmicaOcjenaId { get; set; }

        public Igrac igrac { get; set; }
        public int igracId { get; set; }

        public Utakmica utakmica { get; set; }
        public int utakmicaId { get; set; }

        public int kontrolaLopte { get; set; }
        public int driblanje { get; set; }
        public int dodavanje { get; set; }
        public int kretanje { get; set; }
        public int brzina { get; set; }
        public int sut { get; set; }
        public int snaga { get; set; }
        public int markiranje { get; set; }
        public int klizeciStart { get; set; }
        public int skok { get; set; }
        public int odbrana { get; set; }
        public float prosjecnaOcjena { get; set; }
    }
}
