using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class UtakmicaSastav
    {
        public int utakmicaSastavId { get; set; }
        public Igrac igrac { get; set; }
        public int igracId { get; set; }
        public Utakmica utakmica { get; set; }
        public int? utakmicaId { get; set; }
        public Pozicija pozicija { get; set; }
        public int pozicijaId { get; set; }
        public SastavUloga uloga { get; set; }
    }
}
