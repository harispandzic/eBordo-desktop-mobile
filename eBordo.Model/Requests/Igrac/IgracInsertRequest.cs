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
        public KorisnikInsertRequest korisnikInsertRequest { get; set; }
        public UgovorInsertRequest ugovorInsertRequest { get; set; }
        public int pozicijaId { get; set; }
        public string noga { get; set; }
        public int jacinaSlabijeNoge { get; set; }
        public float visina { get; set; }
        public int tezina { get; set; }
        public int brojDresa { get; set; }
        public float trzisnaVrijednost { get; set; }
        public string napomeneOIgracu { get; set; }
        public byte[] SlikaPanel { get; set; }
    }
}
