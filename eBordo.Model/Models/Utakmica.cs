using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Utakmica
    {
        public int utakmicaId { get; set; }
        public DateTime datumOdigravanja { get; set; }
        public string satnica { get; set; }
        public string sudija { get; set; }
        public Stadion stadion { get; set; }
        public int stadionId { get; set; }
        public string napomene { get; set; }
        public string opisUtakmice { get; set; }
        public int brojUlaznica { get; set; }
        public Takmicenje takmicenje { get; set; }
        public int takmicenjeId { get; set; }
        public Igrac kapiten { get; set; }
        public int kapitenId { get; set; }
        public Trener trener { get; set; }
        public int trenerId { get; set; }
        public Klub protivnik { get; set; }
        public int protivnikId { get; set; }
        public string tipGarniture { get; set; }
        public string vrstaUtakmice { get; set; }
        public bool odigrana { get; set; }
        public ICollection<UtakmicaSastav> sastav { get; set; }
    }
}
