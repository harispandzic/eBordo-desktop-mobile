using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Trening
{
    public class TreningInsertRequest
    {
        public DateTime datumOdrzavanja { get; set; }
        public string satnica { get; set; }
        public string lokacija { get; set; }
        public string fokusTreninga { get; set; }
        public int zabiljezioID { get; set; }
    }
}
