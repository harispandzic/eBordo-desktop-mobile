using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eBordo.Api.Services.Event
{
    public class EventService : BaseREADService<eBordo.Model.Models.KalendarStavka, object, object>, IEventService
    {
        public EventService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override IEnumerable<eBordo.Model.Models.KalendarStavka> Get(object search = null)
        {
            List<eBordo.Model.Models.KalendarStavka> stavke = new List<eBordo.Model.Models.KalendarStavka>();

            var utakmice = _db.utakmice
                .Include(s => s.protivnik)
                .Include(s => s.stadion)
                .Include(s => s.stadion.lokacijaStadiona)
                .ToList();

            var treninzi = _db.trening.ToList();

            foreach (var item in utakmice)
            {
                stavke.Add(new eBordo.Model.Models.KalendarStavka
                {
                    tipEventa = "UTAKMICA",
                    opis = "Utakmica protiv FK " + item.protivnik.nazivKluba,
                    lokacija = "STADION " + item.stadion.nazivStadiona + ", " + item.stadion.lokacijaStadiona.nazivGrada,
                    trajanje = "90 min",
                    datum = item.datumOdigravanja,
                    satnica = item.satnica.ToString() + "h"
                });
            }

            foreach (var item in treninzi)
            {
                stavke.Add(new eBordo.Model.Models.KalendarStavka
                {
                    tipEventa = "TRENING",
                    opis = "TRENING ",
                    lokacija = item.lokacija == LokacijaTreninga.Stadion ? "STADION ASIM FERHATOVIĆ HASE" : "TRENING CENTAR BUTMIR",
                    trajanje = item.trajanje.ToString() + "h",
                    datum = item.datumOdrzavanja,
                    satnica = item.satnica.ToString() + "h"
                });
            }

            stavke = stavke.OrderBy(s => s.datum).ToList();

            return stavke;
        }
    }
}
