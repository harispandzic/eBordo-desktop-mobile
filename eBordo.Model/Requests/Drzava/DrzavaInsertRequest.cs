using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Drzava
{
    public class DrzavaInsertRequest
    {
        public string nazivDrzave { get; set; }
        public byte[] zastava { get; set; }
    }
}
