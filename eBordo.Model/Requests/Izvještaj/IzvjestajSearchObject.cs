using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Izvjestaj
{
    public class IzvjestajSearchObject
    {
        public string tipUtakmice { get; set; }
        public string rezultat { get; set; }
        public bool isSearchZadnjaUtakmica { get; set; }
    }
}
