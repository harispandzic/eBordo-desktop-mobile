using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Models
{
    public class Grad
    {
        public int gradId { get; set; }
        public string nazivGrada { get; set; }
        public int drzavaId { get; set; }
        public Drzava drzava { get; set; }
    }
}
