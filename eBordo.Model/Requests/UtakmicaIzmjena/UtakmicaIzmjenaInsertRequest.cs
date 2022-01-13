using eBordo.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaIzmjena
{
    public class UtakmicaIzmjenaInsertRequest
    {
        [Required]
        public int utakmicaId { get; set; }

        [Required]
        public int igracOutId { get; set; }

        [Required]
        public int igracInId { get; set; }

        [Required]
        [Range(1, 120)]
        public int minuta { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string izmjenaRazlog { get; set; }
    }
}
