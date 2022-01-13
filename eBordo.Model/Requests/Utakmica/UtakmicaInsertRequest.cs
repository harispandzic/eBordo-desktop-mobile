using eBordo.Model.Requests.UtakmicaSastav;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Utakmica
{
    public class UtakmicaInsertRequest
    {
        [Required]
        public DateTime datumOdigravanja { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        [MaxLength(5)]
        public string satnica { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string sudija { get; set; }

        [Required]
        public int stadionId { get; set; }

        public string napomene { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string opisUtakmice { get; set; }

        [Required]
        public int takmicenjeId { get; set; }

        [Required]
        public int kapitenId { get; set; }

        [Required]
        public int trenerId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public int protivnikId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string tipGarniture { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string tipUtakmice { get; set; }

        public bool odigrana { get; set; }

        [Required]
        public ICollection<UtakmicaSastavInsertRequest> sastav { get; set; }
    }
}
