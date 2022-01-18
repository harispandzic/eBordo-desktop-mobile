using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Drzava
{
    public class DrzavaService: BaseCRUDService<eBordo.Model.Models.Drzava, eBordo.Api.Database.Drzava, object, eBordo.Model.Requests.Drzava.DrzavaInsertRequest, eBordo.Model.Requests.Drzava.DrzavaUpdateRequest>, IDrzavaService
    {
        public DrzavaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }



        public override Model.Models.Drzava Insert(DrzavaInsertRequest request)
        {
            if (_db.drzave.Count() != 0)
            {
                foreach (var item in _db.drzave)
                {
                    if (item.nazivDrzave.StartsWith(request.nazivDrzave))
                    {
                        throw new UserException("Drzava postoji u bazi podataka!");
                    }
                }
            }
            
            Database.Drzava drzava = new Database.Drzava
            {
                nazivDrzave = request.nazivDrzave,
                zastava = request.zastava
            };

            _db.Add(drzava);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Drzava>(drzava);
        }
        public override Model.Models.Drzava Update(int id, DrzavaUpdateRequest request)
        {
            foreach (var item in _db.drzave)
            {
                if (item.nazivDrzave.StartsWith(request.nazivDrzave))
                {
                    throw new UserException("Drzava postoji u bazi podataka!");
                }
            }
            var entity = _db.drzave.Where(s => s.drzavaId == id).SingleOrDefault();

            entity.nazivDrzave = request.nazivDrzave;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Drzava>(entity);
        }
    }
}
