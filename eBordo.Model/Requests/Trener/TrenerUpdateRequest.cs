using eBordo.Model.Requests.Korisnik;
using eBordo.Model.Requests.Ugovor;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Trener
{
    public class TrenerUpdateRequest
    {
        public KorisnikUpdateRequest korisnikUpdateRequest { get; set; }
        public UgovorUpdateRequest ugovorUpdateRequeest { get; set; }
        public int preferiranaFormacijaId { get; set; }
        public int trenerskaLicencaId { get; set; }
    }
}
