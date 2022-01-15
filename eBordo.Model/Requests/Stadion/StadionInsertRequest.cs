using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Stadion
{
    public class StadionInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string nazivStadiona { get; set; }

        [Required]
        public int lokacijaStadionaId { get; set; }

        [Required]
        public byte[] slikaStadiona { get; set; }
    }
}
