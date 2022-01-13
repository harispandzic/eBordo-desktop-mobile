using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaNastup
{
    public class UtakmicaNastupInsertRequest
    {
        [Required]
        public int igracId { get; set; }

        [Required]
        public int trenerId { get; set; }

        [Required]
        public int utakmicaId { get; set; }

        [Required]
        [Range(1, 120)]
        public int minute { get; set; }

        [Required]
        [Range(1, 20)]
        public int golovi { get; set; }

        [Required]
        [Range(1, 20)]
        public int asistencije { get; set; }

        [Required]
        [Range(1, 2)]
        public int zutiKartoni { get; set; }

        [Required]
        [Range(1, 1)]
        public int crveniKartoni { get; set; }

        [Required]
        [Range(1, 5)]
        public int ocjena { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Range(1, 5)]
        public string komentar { get; set; }

        [Required]
        [Range(1, 5)]
        public int kontrolaLopte { get; set; }

        [Required]
        [Range(1, 5)]
        public int driblanje { get; set; }

        [Required]
        [Range(1, 5)]
        public int dodavanje { get; set; }

        [Required]
        [Range(1, 5)]
        public int kretanje { get; set; }

        [Required]
        [Range(1, 5)]
        public int brzina { get; set; }

        [Required]
        [Range(1, 5)]
        public int sut { get; set; }

        [Required]
        [Range(1, 5)]
        public int snaga { get; set; }

        [Required]
        [Range(1, 5)]
        public int markiranje { get; set; }

        [Required]
        [Range(1, 5)]
        public int klizeciStart { get; set; }

        [Required]
        [Range(1, 5)]
        public int skok { get; set; }

        [Required]
        [Range(1, 5)]
        public int odbrana { get; set; }
    }
}
