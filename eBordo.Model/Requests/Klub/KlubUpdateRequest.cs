using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Klub
{
    public class KlubUpdateRequest
    {
        [MinLength(2)]
        public string nazivKluba { get; set; }
    }
}
