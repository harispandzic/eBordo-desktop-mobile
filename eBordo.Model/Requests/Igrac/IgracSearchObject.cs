using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Igrac
{
    public class IgracSearchObject
    {
        public string ime { get; set; }
        public int pozicijaId { get; set; }
        public bool isAktivan{ get; set; }
    }
}
