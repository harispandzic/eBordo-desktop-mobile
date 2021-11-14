using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Takmicenje
    {
        public int takmicenjeId { get; set; }
        public string nazivTakmicenja { get; set; }
        public byte[] logo { get; set; }
    }
}
