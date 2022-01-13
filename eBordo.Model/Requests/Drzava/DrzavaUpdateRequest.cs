using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Drzava
{
    public class DrzavaUpdateRequest
    {
        [MinLength(2)]
        public string nazivDrzave { get; set; }
    }
}
