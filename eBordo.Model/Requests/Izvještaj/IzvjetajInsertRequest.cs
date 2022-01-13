using eBordo.Model.Models;
using eBordo.Model.Requests.UtakmicaIzmjena;
using eBordo.Model.Requests.UtakmicaNastup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Izvještaj
{
    public class IzvjetajInsertRequest
    {
        [Required]
        [Range(1, 20)]
        public int goloviSarajevo { get; set; }

        [Required]
        [Range(1, 20)]
        public int goloviProtivnik { get; set; }
        public string zapisnik { get; set; }

        [Required]
        public byte[] slikaSaUtakmice { get; set; }

        [Required]
        public Vrijeme vrijeme { get; set; }

        [Required]
        public int igracUtakmicaID { get; set; }

        [Required]
        public int utakmicaID { get; set; }

        [Required]
        public int trenerID { get; set; }

        [Required]
        public ICollection<UtakmicaNastupInsertRequest> utakmicaNastup { get; set; }
        
        [Required]
        public ICollection<UtakmicaIzmjenaInsertRequest> izmjene { get; set; }
    }
}
