using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class TrenerStatistika
    {
        public int trenerStatistikaID { get; set; }
        public int brojUtakmica { get; set; }
        public int brojPobjeda { get; set; }
        public int brojNerjesenih { get; set; }
        public int brojPoraza { get; set; }
        public Trener trener { get; set; }
        public int? trenerID { get; set; }
    }
}
