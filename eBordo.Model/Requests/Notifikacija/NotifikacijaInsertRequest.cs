using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Notifikacija
{
    public class NotifikacijaInsertRequest
    {
        public string tekstNotifikacije { get; set; }

        public string tipNotifikacije { get; set; }

        public int korisnikId { get; set; }
    }
}
