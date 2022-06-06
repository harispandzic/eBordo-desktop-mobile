using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class KalendarStavka
    {
        public string opis { get; set; }
        public DateTime datum { get; set; }
        public string satnica { get; set; }
        public string trajanje { get; set; }
        public string lokacija { get; set; }
        public string tipEventa { get; set; }
    }
}
