using eBordo.Model.Requests.UtakmicaIzmjena;
using eBordo.Model.Requests.UtakmicaNastup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Izvjestaj
{
    public class IzvjestajUpdateRequest
    {
        public string zapisnik { get; set; }
        public int utakmicaId { get; set; }
        public ICollection<UtakmicaNastupUpdateRequest> utakmicaNastup { get; set; }
        public ICollection<UtakmicaIzmjenaUpdateRequest> izmjene { get; set; }
    }
}
