using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Klub
    {
        public int klubId { get; set; }
        public string nazivKluba { get; set; }
        public Grad grad { get; set; }
        public int gradId { get; set; }
        public Stadion stadion { get; set; }
        public int stadionId { get; set; }
        public byte[] grb { get; set; }
    }
}
