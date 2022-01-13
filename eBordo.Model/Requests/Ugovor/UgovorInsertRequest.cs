using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Ugovor
{
    public class UgovorInsertRequest
    {
        [Required]
        public DateTime datumPocetka { get; set; }

        [Required]
        public DateTime datumZavrsetka { get; set; }
    }
}
