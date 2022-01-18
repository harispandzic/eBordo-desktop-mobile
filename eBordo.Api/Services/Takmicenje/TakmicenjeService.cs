using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Takmicenje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Takmicenje
{
    public class TakmicenjeService : BaseCRUDService<eBordo.Model.Models.Takmicenje, eBordo.Api.Database.Takmicenje, object,Model.Requests.Takmicenje.TakmicenjeInsertRequest, Model.Requests.Takmicenje.TakmicenjeUpdateRequest>, ITakmicenjeService
    {
        public TakmicenjeService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
        public override Model.Models.Takmicenje Insert(TakmicenjeInsertRequest request)
        {
            if (_db.takmicenje.Count() != 0)
            {
                foreach (var item in _db.takmicenje)
                {
                    if (item.nazivTakmicenja.StartsWith(request.nazivTakmicenja))
                    {
                        throw new UserException("Takmicenje postoji u bazi podataka!");
                    }
                }
            }
            
            Database.Takmicenje takmicenje = new Database.Takmicenje
            {
                nazivTakmicenja = request.nazivTakmicenja,
                logo = request.logo
            };

            _db.Add(takmicenje);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Takmicenje>(takmicenje);
        }
        public override Model.Models.Takmicenje Update(int id, TakmicenjeUpdateRequest request)
        {
            foreach (var item in _db.takmicenje)
            {
                if (item.nazivTakmicenja.StartsWith(request.nazivTakmicenja))
                {
                    throw new UserException("Takmicenje postoji u bazi podataka!");
                }
            }
            var entity = _db.takmicenje.Where(s => s.takmicenjeId == id).SingleOrDefault();

            entity.nazivTakmicenja = request.nazivTakmicenja;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Takmicenje>(entity);
        }
    }
}
