using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Stadion
{
    public class StadionInsertRequest
    {
        public string nazivStadiona { get; set; }
        public int lokacijaStadionaId { get; set; }
        public byte[] slikaStadiona { get; set; }
    }
}
