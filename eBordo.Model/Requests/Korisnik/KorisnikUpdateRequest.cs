using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Korisnik
{
    public class KorisnikUpdateRequest
    {
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
    }
}
