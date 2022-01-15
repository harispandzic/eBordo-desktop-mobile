using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Trening
{
    public class TreningInsertRequest
    {
        [Required]
        public DateTime datumOdrzavanja { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        [MaxLength(5)]
        public string satnica { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string lokacija { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string fokusTreninga { get; set; }

        [Required]
        public int zabiljezioID { get; set; }

        [Required]
        [MaxLength(1)]
        public int trajanje { get; set; }
    }
}
