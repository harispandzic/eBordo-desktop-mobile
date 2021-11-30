using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Klub
{
    public class KlubInsertRequest
    {
        public string nazivKluba { get; set; }
        public int gradId { get; set; }
        public int stadionId { get; set; }
        public byte[] grb { get; set; }
    }
}
