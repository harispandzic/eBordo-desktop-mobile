using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class UtakmicaIzmjena
    {
        public int utakmicaIzmjenaID { get; set; }
        public int utakmicaId { get; set; }
        public Utakmica utakmica { get; set; }
        public Igrac igracOut { get; set; }
        public int igracOutId { get; set; }
        public Igrac igracIn { get; set; }
        public int igracInId { get; set; }
        public int minuta { get; set; }
        public IzmjenaRazlog izmjenaRazlog { get; set; }
    }
}
