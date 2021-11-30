using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class UtakmicaIzmjena
    {
        public int utakmicaIzmjenaID { get; set; }

        public int utakmicaId { get; set; }
        public Utakmica utakmica { get; set; }

        public int izmjenaId { get; set; }
        public Izmjena izmjena { get; set; }
    }
}
