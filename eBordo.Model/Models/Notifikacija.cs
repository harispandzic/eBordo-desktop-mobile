using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Notifikacija
    {
        public int notifikacijaId { get; set; }
        public int korisnikId { get; set; }
        public string tekstNotifikacije { get; set; }
        public DateTime datumNotifikacije { get; set; }
        public string tipNotifikacije { get; set; }
    }
}
