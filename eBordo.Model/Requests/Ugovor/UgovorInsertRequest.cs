using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Ugovor
{
    public class UgovorInsertRequest
    {
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }
    }
}
