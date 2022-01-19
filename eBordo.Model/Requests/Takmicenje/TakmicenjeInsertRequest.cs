using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Takmicenje
{
    public class TakmicenjeInsertRequest
    {
        public string nazivTakmicenja { get; set; }
        public byte[] logo { get; set; }
    }
}
