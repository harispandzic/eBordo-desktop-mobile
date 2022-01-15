using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Korisnik
{
    public class KorisnikUpdateRequest
    {
        [MinLength(2)]
        public string adresa { get; set; }

        [MinLength(2)]
        [StringLength(11)]
        public string telefon { get; set; }

        [MinLength(2)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public bool isAktivan { get; set; }
    }
}
