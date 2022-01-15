using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Takmicenje
{
    public class TakmicenjeUpdateRequest
    {
        [MinLength(2)]
        public string nazivTakmicenja { get; set; }
    }
}
