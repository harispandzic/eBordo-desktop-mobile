﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Ugovor
{
    public class UgovorUpdateRequest
    {
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }
        public float plata { get; set; }
        public string napomene { get; set; }
    }
}
