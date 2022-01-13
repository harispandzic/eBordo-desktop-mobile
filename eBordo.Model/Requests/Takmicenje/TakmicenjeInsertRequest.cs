using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Takmicenje
{
    public class TakmicenjeInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string nazivTakmicenja { get; set; }

        [Required]
        public byte[] logo { get; set; }
    }
}
