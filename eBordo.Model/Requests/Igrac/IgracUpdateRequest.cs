using eBordo.Model.Requests.Korisnik;
using eBordo.Model.Requests.Ugovor;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Igrac
{
    public class IgracUpdateRequest
    {
        public KorisnikUpdateRequest korisnikUpdateRequest { get; set; }
        public UgovorUpdateRequest ugovorUpdateRequeest { get; set; }
        public float visina { get; set; }
        public int tezina { get; set; }
        public int brojDresa { get; set; }
        public float trzisnaVrijednost { get; set; }
        public string slika { get; set; }
        public int pozicijaId { get; set; }
    }
}
