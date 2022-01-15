using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Stadion
{
    public class StadionUpdateRequest
    {
        [MinLength(2)]
        public string nazivStadiona { get; set; }
    }
}
