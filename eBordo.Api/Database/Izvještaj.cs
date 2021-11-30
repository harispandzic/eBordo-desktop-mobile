using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Izvještaj
    {
        public int izvještajId { get; set; }
        public int goloviSarajevo { get; set; }
        public int goloviProtivnik { get; set; }
        public Rezultat rezultat { get; set; }
        public int brojGledalaca { get; set; }
        public DateTime datumKreiranja { get; set; }
        public string zapisnik { get; set; }
        public byte[] slikaSaUtakmice { get; set; }
        public Vrijeme vrijeme { get; set; }

        public ICollection<UtakmicaNastup> nastupi { get; set; }
        public ICollection<UtakmicaOcjena> ocjene { get; set; }
        public ICollection<UtakmicaIzmjena> izmjene { get; set; }

        public Igrac igracUtakmica { get; set; }
        public int igracUtakmicaID { get; set; }

        public Utakmica utakmica { get; set; }
        public int utakmicaID { get; set; }

        public Trener trener { get; set; }
        public int trenerID { get; set; }
    }
}
