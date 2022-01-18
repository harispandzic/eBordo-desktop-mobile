using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Trening
{
    public class TreningUpdateRequest
    {
        public DateTime datumOdrzavanja { get; set; }
        public string satnica { get; set; }
        public string lokacija { get; set; }
        public string fokusTreninga { get; set; }
        public bool isOdradjen { get; set; }
        public int trajanje { get; set; }
    }
}
