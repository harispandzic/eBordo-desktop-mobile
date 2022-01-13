using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaNastup
{
    public class UtakmicaNastupUpdateRequest
    {
        [Required]
        public int utakmicaNastupId { get; set; }

        [Required]
        public int igracId { get; set; }

        [Required]
        public int trenerId { get; set; }

        [Required]
        public int utakmicaId { get; set; }

        [Range(1, 120)]
        public int minute { get; set; }

        [Range(1, 20)]
        public int golovi { get; set; }

        [Range(1, 20)]
        public int asistencije { get; set; }

        [Range(1, 2)]
        public int zutiKartoni { get; set; }

        [Range(1, 1)]
        public int crveniKartoni { get; set; }

        [Range(1, 5)]
        public int ocjena { get; set; }

        [MinLength(2)]
        public string komentar { get; set; }

        [Range(1, 5)]
        public int kontrolaLopte { get; set; }

        [Range(1, 5)]
        public int driblanje { get; set; }

        [Range(1, 5)]
        public int dodavanje { get; set; }

        [Range(1, 5)]
        public int kretanje { get; set; }

        [Range(1, 5)]
        public int brzina { get; set; }

        [Range(1, 5)]
        public int sut { get; set; }

        [Range(1, 5)]
        public int snaga { get; set; }

        [Range(1, 5)]
        public int markiranje { get; set; }

        [Range(1, 5)]
        public int klizeciStart { get; set; }

        [Range(1, 5)]
        public int skok { get; set; }

        [Range(1, 5)]
        public int odbrana { get; set; }
    }
}
