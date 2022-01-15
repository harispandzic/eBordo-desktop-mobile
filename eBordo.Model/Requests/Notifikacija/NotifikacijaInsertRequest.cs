using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Notifikacija
{
    public class NotifikacijaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string tekstNotifikacije { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string tipNotifikacije { get; set; }

        [Required]
        public int korisnikId { get; set; }
    }
}
