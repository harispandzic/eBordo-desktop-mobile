using eBordo.Model.Models;
using eBordo.Model.Requests.Korisnik;
using eBordo.Model.Requests.Ugovor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Trener
{
    public class TrenerInsertRequest
    {
        public KorisnikInsertRequest korisnikInsertRequest { get; set; }       
        public UgovorInsertRequest ugovorInsertRequest { get; set; }
        public int preferiranaFormacijaId { get; set; }
        public int trenerskaLicencaId { get; set; }
        public int ulogaTreneraId { get; set; }
        public byte[] SlikaPanel { get; set; }
    }
}
