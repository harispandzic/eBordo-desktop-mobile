using eBordo.Model.Models;
using eBordo.Model.Requests.UtakmicaIzmjena;
using eBordo.Model.Requests.UtakmicaNastup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Izvjestaj
{
    public class IzvjetajInsertRequest
    {
        public int goloviSarajevo { get; set; }
        public int goloviProtivnik { get; set; }
        public string zapisnik { get; set; }
        public byte[] slikaSaUtakmice { get; set; }
        public Vrijeme vrijeme { get; set; }
        public int igracUtakmicaID { get; set; }
        public int utakmicaID { get; set; }
        public int trenerID { get; set; }
        public ICollection<UtakmicaNastupInsertRequest> utakmicaNastup { get; set; }
        public ICollection<UtakmicaIzmjenaInsertRequest> izmjene { get; set; }
    }
}
