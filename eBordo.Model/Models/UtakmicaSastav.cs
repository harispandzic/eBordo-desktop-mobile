using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class UtakmicaSastav
    {
        public int utakmicaSastavId { get; set; }
        public Igrac igrac { get; set; }
        public int igracId { get; set; }
        public Pozicija pozicija { get; set; }
        public int pozicijaId { get; set; }
        public string uloga { get; set; }
    }
}
