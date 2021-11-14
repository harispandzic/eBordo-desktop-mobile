using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Stadion
    {
        public int stadionId { get; set; }
        public string nazivStadiona { get; set; }
        public Grad lokacijaStadiona { get; set; }
        public int lokacijaStadionaId { get; set; }
        public byte[] slikaStadiona { get; set; }
    }
}
