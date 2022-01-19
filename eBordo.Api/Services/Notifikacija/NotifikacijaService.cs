using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Notifikacija;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Notifikacija
{
    public class NotifikacijaService : BaseCRUDService<eBordo.Model.Models.Notifikacija, eBordo.Api.Database.Notifikacija, eBordo.Model.Requests.Notifikacija.NotifikacijaSearchObject, eBordo.Model.Requests.Notifikacija.NotifikacijaInsertRequest, object>, INotifikacijaService
    {
        public NotifikacijaService(eBordoContext db, IMapper mapper) : base(db, mapper) {}

        public override IEnumerable<Model.Models.Notifikacija> Get(NotifikacijaSearchObject search = null)
        {
            var entity = _db.notifikacije
                .Include(s => s.korisnik)
                .AsQueryable();

            if (entity.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

            if (search != null)
            {
                entity = entity.Where(s => s.korisnikId == search.korisnikId);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Notifikacija>>(result);
        }
        public override Model.Models.Notifikacija GetById(int id)
        {
            var entity = _db.notifikacije
                .Where(s => s.notifikacijaId == id)
                .Include(s => s.korisnik)
                .AsQueryable();

            var result = entity.ToList();

            return _mapper.Map<Model.Models.Notifikacija>(result);
        }
        public override Model.Models.Notifikacija Insert(NotifikacijaInsertRequest request)
        {
            Database.Notifikacija notifikacija = new Database.Notifikacija
            {
                korisnikId = request.korisnikId,
                tekstNotifikacije = request.tekstNotifikacije,
                statusNotifikacije = StatusNotifikacije.Nepročitana,
                datumNotifikacije = DateTime.Now,
                tipNotifikacije = (TipNotifikacije)Enum.Parse(typeof(TipNotifikacije), request.tipNotifikacije),
            };

            _db.Add(notifikacija);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.Notifikacija>(notifikacija);
        }
        public override Model.Models.Notifikacija Update(int id, object req = null)
        {
            Database.Notifikacija notifikacija = _db.notifikacije.Where(s => s.notifikacijaId == id).SingleOrDefault();

            notifikacija.statusNotifikacije = StatusNotifikacije.Pročitana;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Notifikacija>(notifikacija);
        }
        public override Model.Models.Notifikacija Delete(int id)
        {
            Database.Notifikacija notifikacija = _db.notifikacije.Where(s => s.notifikacijaId == id).SingleOrDefault();

            _db.Remove(notifikacija);

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Notifikacija>(notifikacija);
        }
    }
}
