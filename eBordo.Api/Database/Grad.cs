using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class Grad
    {
        public int gradId { get; set; }
        public string nazivGrada { get; set; }

        public Drzava drzava { get; set; }
        public int drzavaId { get; set; }
    }
}
