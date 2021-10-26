using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Ugovor
    {
        public int ugovorId { get; set; }
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }

        public Igrac igrac { get; set; }
        public int? igracId { get; set; }

        public Trener trener { get; set; }
        public int? trenerID { get; set; }
    }
}
