using eBordo.Model.Requests.Korisnik;
using eBordo.Model.Requests.Ugovor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Igrac
{
    public class IgracInsertRequest
    {
        [Required]
        public KorisnikInsertRequest korisnikInsertRequest { get; set; }

        [Required]
        public UgovorInsertRequest ugovorInsertRequest { get; set; }

        [Required]
        public int pozicijaId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string noga { get; set; }

        [Range(1, 5)]
        public int jacinaSlabijeNoge { get; set; }

        [Range(120, 250)]
        public float visina { get; set; }

        [Range(55, 100)]
        public int tezina { get; set; }

        [Range(1, 99)]
        public int brojDresa { get; set; }
        
        [Range(1, 100000000)]
        public float trzisnaVrijednost { get; set; }

        public string napomeneOIgracu { get; set; }

        [Required]
        public byte[] SlikaPanel { get; set; }
    }
}
