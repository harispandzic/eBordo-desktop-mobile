using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Ugovor
    {
        public int ugovorId { get; set; }
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }
    }
}
