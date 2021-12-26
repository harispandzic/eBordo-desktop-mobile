using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Notifikacija
    {
        public int notifikacijaId { get; set; }
        public Korisnik korisnik { get; set; }
        public int korisnikId { get; set; }
        public string tekstNotifikacije { get; set; }
        public DateTime datumNotifikacije { get; set; }
        public StatusNotifikacije statusNotifikacije { get; set; }
        public TipNotifikacije tipNotifikacije { get; set; }
    }
}
