using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaSastav
{
    public class UtakmicaSastavUpdateRequest
    {
        public int utakmicaSastavid { get; set; }
        public int igracId { get; set; }
        public int? utakmicaId { get; set; }
        public int pozicijaId { get; set; }
        public string uloga { get; set; }
    }
}
