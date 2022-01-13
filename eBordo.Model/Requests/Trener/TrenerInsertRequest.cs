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
        [Required]
        public KorisnikInsertRequest korisnikInsertRequest { get; set; }       

        [Required]
        public UgovorInsertRequest ugovorInsertRequest { get; set; }

        [Required]
        public int preferiranaFormacijaId { get; set; }

        [Required]
        public int trenerskaLicencaId { get; set; }
        
        [Required]
        public int ulogaTreneraId { get; set; }

        [Required]
        public byte[] SlikaPanel { get; set; }
    }
}
