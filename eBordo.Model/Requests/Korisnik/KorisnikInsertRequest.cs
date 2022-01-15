using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Korisnik
{
    public class KorisnikInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string prezime { get; set; }

        [Required]
        public DateTime datumRodjenja { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string adresa { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        [StringLength(11)]
        public string telefon { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        public int drzavljanstvoId { get; set; }

        [Required]
        public int gradRodjenjaId { get; set; }

        [Required]
        public byte[] Slika { get; set; }
    }
}
