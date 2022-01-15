using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Klub
{
    public class KlubInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string nazivKluba { get; set; }

        [Required]
        public int gradId { get; set; }

        [Required]
        public int stadionId { get; set; }

        [Required]
        public byte[] grb { get; set; }
    }
}
