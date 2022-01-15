using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaSastav
{
    public class UtakmicaSastavInsertRequest
    {
        [Required]
        public int igracId { get; set; }

        public int? utakmicaId { get; set; }

        [Required]
        public int pozicijaId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string uloga { get; set; }
    }
}
