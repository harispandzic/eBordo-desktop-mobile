﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Utakmica
{
    public class UtakmicaSearchObject
    {
        public string tipUtakmice { get; set; }
        public bool odigrana { get; set; }
        public bool isSearchTop3 { get; set; }
        public bool isNarednaUtakmica { get; set; }
    }
}
