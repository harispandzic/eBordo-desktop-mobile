using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Drzava
{
    public class DrzavaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string nazivDrzave { get; set; }

        [Required]
        public byte[] zastava { get; set; }
    }
}
