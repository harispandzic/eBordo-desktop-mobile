using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.Notifikacija;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Notifikacija;
using eBordo.Model.Requests.Trening;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Trening
{
    public class TreningService : BaseCRUDService.BaseCRUDService<eBordo.Model.Models.Trening, Database.Trening, eBordo.Model.Requests.Trening.TreningSearchObject, eBordo.Model.Requests.Trening.TreningInsertRequest, eBordo.Model.Requests.Trening.TreningUpdateRequest>, ITreningService
    {
        private INotifikacijaService _notifikacijaService { get; set; }

        public TreningService(eBordoContext db, IMapper mapper, INotifikacijaService notifikacijaService)
            : base(db, mapper) {
            _notifikacijaService = notifikacijaService;
        }

        public override IEnumerable<Model.Models.Trening> Get(TreningSearchObject search = null)
        {
            var entity = _db.trening
                .Include(s => s.zabiljezio)
                .Include(s => s.zabiljezio.korisnik)
                .AsQueryable();

            if (entity.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

            if (search != null && !string.IsNullOrEmpty(search.lokacijaTreninga))
            {
                LokacijaTreninga lokacija = (LokacijaTreninga)Enum.Parse(typeof(LokacijaTreninga), search.lokacijaTreninga);
                entity = entity.Where(s => s.lokacija == lokacija);
            }
            if (search.isSearchTop3)
            {
                entity = entity.Where(s => s.datumOdrzavanja.Date >= DateTime.Now.Date).OrderBy(s => s.datumOdrzavanja).Take(3);
            }
            if (search.zavrsen == true)
            {
                entity = entity.Where(s => s.isOdradjen).OrderBy(s => s.datumOdrzavanja).Take(3);
            }
            else
            {
                entity = entity.Where(s => !s.isOdradjen).OrderBy(s => s.datumOdrzavanja).Take(3);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Trening>>(result);
        }
        public override Model.Models.Trening GetById(int id)
        {
            Database.Trening trening = _db.trening.Where(s => s.treningID == id)
                .Include(s => s.zabiljezio)
                .Include(s => s.zabiljezio.korisnik)
                .SingleOrDefault();

            return _mapper.Map<Model.Models.Trening>(trening);
        }
        public override Model.Models.Trening Insert(TreningInsertRequest request)
        {
            if (_db.trening.Count() != 0)
            {
                foreach (var item in _db.utakmice)
                {
                    if (item.datumOdigravanja.Date == request.datumOdrzavanja.Date)
                    {
                        throw new UserException("Odabrani datum je zauzet. Vec je evidentirana utakmica!");
                    }
                }
                foreach (var item in _db.trening)
                {
                    if (item.datumOdrzavanja.Date == request.datumOdrzavanja.Date)
                    {
                        throw new UserException("Odabrani datum je zauzet. Vec je evidentiran trening!");
                    }
                }
            }
            
            
            Database.Trening trening = new Database.Trening
            {
                datumOdrzavanja = request.datumOdrzavanja,
                satnica = request.satnica,
                lokacija = (LokacijaTreninga)Enum.Parse(typeof(LokacijaTreninga), request.lokacija),
                fokusTreninga = request.fokusTreninga,
                isOdradjen = false,
                trajanje = request.trajanje,
                zabiljezioID = 1
            };

            _db.Add(trening);
            _db.SaveChanges();

            //foreach (var item in _db.igraci)
            //{
            //    NotifikacijaInsertRequest notifikacijaInsertRequest = new NotifikacijaInsertRequest
            //    {
            //        korisnikId = item.korisnikId,
            //        tekstNotifikacije = "Trening je zakazan za " +  trening.datumOdrzavanja.ToString("dd.MM.yyyy") + " za " + trening.satnica + " sati",
            //        tipNotifikacije = "Info"
            //    };

            //    _notifikacijaService.Insert(notifikacijaInsertRequest);
            //}

            return _mapper.Map<Model.Models.Trening>(trening);
        }
        public override Model.Models.Trening Update(int id, TreningUpdateRequest request)
        {
            foreach (var item in _db.trening)
            {
                if (item.datumOdrzavanja.Date == request.datumOdrzavanja.Date)
                {
                    throw new UserException("Odabrani datum je zauzet. Vec je evidentiran trening!");
                }
            }
            Database.Trening trening = _db.trening.Where(s => s.treningID == id).SingleOrDefault();

            trening.datumOdrzavanja = request.datumOdrzavanja;
            trening.satnica = request.satnica;
            trening.lokacija = (LokacijaTreninga)Enum.Parse(typeof(LokacijaTreninga), request.lokacija);
            trening.fokusTreninga = request.fokusTreninga;
            trening.isOdradjen = request.isOdradjen;
            trening.trajanje = request.trajanje;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Trening>(trening);
        }
        public override Model.Models.Trening Delete(int id)
        {
            Database.Trening trening = _db.trening.Where(s => s.treningID == id).SingleOrDefault();

            _db.Remove(trening);

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Trening>(trening);
        }
    }
}
