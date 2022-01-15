using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Trening
    {
        public int treningID { get; set; }
        public DateTime datumOdrzavanja { get; set; }
        public string satnica { get; set; }
        public LokacijaTreninga lokacija { get; set; }
        public string fokusTreninga { get; set; }
        public bool isOdradjen { get; set; }
        public Trener zabiljezio { get; set; }
        public int zabiljezioID { get; set; }
        public int trajanje { get; set; }
    }
}
