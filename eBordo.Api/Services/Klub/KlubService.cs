using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Klub;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Klub
{
    public class KlubService : BaseCRUDService<eBordo.Model.Models.Klub, eBordo.Api.Database.Klub, object, eBordo.Model.Requests.Klub.KlubInsertRequest, eBordo.Model.Requests.Klub.KlubUpdateRequest>, IKlubService
    {
        public KlubService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override Model.Models.Klub Insert(KlubInsertRequest request)
        {
            if (_db.klubovi.Count() != 0)
            {
                foreach (var item in _db.klubovi)
                {
                    if (item.nazivKluba.StartsWith(request.nazivKluba))
                    {
                        throw new UserException("Klub postoji u bazi podataka!");
                    }
                }
            }
            
            Database.Klub klub = new Database.Klub
            {
                nazivKluba = request.nazivKluba,
                gradId = request.gradId,
                stadionId = request.stadionId,
                grb = request.grb
            };

            _db.Add(klub);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Klub>(klub);
        }
        public override Model.Models.Klub Update(int id, KlubUpdateRequest request)
        {
            foreach (var item in _db.klubovi)
            {
                if (item.nazivKluba.StartsWith(request.nazivKluba))
                {
                    throw new UserException("Klub postoji u bazi podataka!");
                }
            }
            var entity = _db.klubovi.Where(s => s.klubId == id).SingleOrDefault();

            entity.nazivKluba = request.nazivKluba;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Klub>(entity);
        }
        public override IEnumerable<eBordo.Model.Models.Klub> Get(object search = null)
        {
            var entity = _db.Set<Database.Klub>()
                .Include(s => s.grad)
                .Include(s => s.grad.drzava)
                .Include(s => s.stadion)
                .Include(s => s.stadion.lokacijaStadiona)
                .Include(s => s.stadion.lokacijaStadiona.drzava)
                .AsQueryable();

            if (entity.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Klub>>(result);
        }
        public override eBordo.Model.Models.Klub GetById(int id)
        {
            var entity = _db.Set<Database.Klub>()
                .Where(s => s.stadionId == id)
                .Include(s => s.grad)
                .Include(s => s.grad.drzava)
                .Include(s => s.stadion)
                .Include(s => s.stadion.lokacijaStadiona)
                .Include(s => s.stadion.lokacijaStadiona.drzava)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Klub>(result);
        }
    }
}
