using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Trening
{
    public class TreningUpdateRequest
    {
        public DateTime datumOdrzavanja { get; set; }

        [MinLength(2)]
        [MaxLength(5)]
        public string satnica { get; set; }

        [MinLength(2)]
        public string lokacija { get; set; }

        [MinLength(2)]
        public string fokusTreninga { get; set; }

        public bool isOdradjen { get; set; }

        [MinLength(2)]
        public int trajanje { get; set; }
    }
}
