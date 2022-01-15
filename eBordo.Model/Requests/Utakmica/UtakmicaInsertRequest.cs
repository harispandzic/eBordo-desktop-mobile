using eBordo.Model.Requests.UtakmicaSastav;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Utakmica
{
    public class UtakmicaInsertRequest
    {
        public DateTime datumOdigravanja { get; set; }

 
        public string satnica { get; set; }

       
        public string sudija { get; set; }

        public int stadionId { get; set; }

        public string napomene { get; set; }

        public string opisUtakmice { get; set; }

   
        public int takmicenjeId { get; set; }

    
        public int kapitenId { get; set; }

        public int trenerId { get; set; }

        public int protivnikId { get; set; }


        public string tipGarniture { get; set; }

        public string tipUtakmice { get; set; }

        public bool odigrana { get; set; }

        public ICollection<UtakmicaSastavInsertRequest> sastav { get; set; }
    }
}
