using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Korisnik
{
    public class KorisnikChangePasswordRequest
    {
        public int korisnikId { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}
