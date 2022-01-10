using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Trening
    {
        public int treningID { get; set; }
        public DateTime datumOdrzavanja { get; set; }
        public string satnica { get; set; }
        public string lokacija { get; set; }
        public string fokusTreninga { get; set; }
        public bool isOdradjen { get; set; }
        public Trener zabiljezio { get; set; }
        public int zabiljezioID { get; set; }
        public int trajanje { get; set; }
    }
}
