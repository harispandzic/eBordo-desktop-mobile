using eBordo.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.UtakmicaIzmjena
{
    public class UtakmicaIzmjenaInsertRequest
    {
       
        public int utakmicaId { get; set; }

 
        public int igracOutId { get; set; }

     
        public int igracInId { get; set; }

  
        public int minuta { get; set; }

 
        public string izmjenaRazlog { get; set; }
    }
}
