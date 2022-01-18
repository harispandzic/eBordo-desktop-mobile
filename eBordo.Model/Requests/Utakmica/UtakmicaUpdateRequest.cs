using eBordo.Model.Requests.UtakmicaSastav;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Utakmica
{
    public class UtakmicaUpdateRequest
    {
        public DateTime datumOdigravanja { get; set; }
        public string satnica { get; set; }
        public string napomene { get; set; }
        public int kapitenId { get; set; }
        public ICollection<UtakmicaSastavUpdateRequest> sastav { get; set; }
    }
}
