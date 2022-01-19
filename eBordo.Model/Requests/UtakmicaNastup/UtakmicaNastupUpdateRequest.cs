using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaNastup
{
    public class UtakmicaNastupUpdateRequest
    {
        public int utakmicaNastupId { get; set; }
        public int igracId { get; set; }
        public int trenerId { get; set; }
        public int utakmicaId { get; set; }
        public int minute { get; set; }
        public int golovi { get; set; }
        public int asistencije { get; set; }
        public int zutiKartoni { get; set; }
        public int crveniKartoni { get; set; }
        public int ocjena { get; set; }
        public string komentar { get; set; }
        public int kontrolaLopte { get; set; }
        public int driblanje { get; set; }
        public int dodavanje { get; set; }
        public int kretanje { get; set; }
        public int brzina { get; set; }
        public int sut { get; set; }
        public int snaga { get; set; }
        public int markiranje { get; set; }
        public int klizeciStart { get; set; }
        public int skok { get; set; }
        public int odbrana { get; set; }
    }
}
