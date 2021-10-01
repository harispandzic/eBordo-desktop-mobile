using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Ugovor
{
    public class UgovorInsertRequest
    {
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }
        public DateTime datumPotpisa { get; set; }
        public float plata{ get; set; }
        public string napomene { get; set; }
    }
}
