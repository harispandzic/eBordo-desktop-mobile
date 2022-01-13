using eBordo.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Grad
{
    public class GradInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string nazivGrada { get; set; }

        [Required]
        public int drzavaId { get; set; }
    }
}
