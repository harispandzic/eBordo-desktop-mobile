using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Filters;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Grad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Grad
{
    public class GradService: BaseCRUDService<eBordo.Model.Models.Grad,eBordo.Api.Database.Grad, object, Model.Requests.Grad.GradInsertRequest, Model.Requests.Grad.GradUpdateRequest>, IGradService
    {
        public GradService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override Model.Models.Grad Insert(GradInsertRequest request)
        {
            if (_db.gradovi.Count() != 0)
            {
                foreach (var item in _db.gradovi)
                {
                    if (item.nazivGrada.StartsWith(request.nazivGrada))
                    {
                        throw new UserException("Grad postoji u bazi podataka!");
                    }
                }
            }
            
            Database.Grad grad = new Database.Grad
            {
                nazivGrada = request.nazivGrada,
                drzavaId = request.drzavaId
            };

            _db.Add(grad);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.Grad>(grad);
        }
        public override Model.Models.Grad Update(int id, GradUpdateRequest request)
        {
            foreach (var item in _db.gradovi)
            {
                if (item.nazivGrada.StartsWith(request.nazivGrada))
                {
                    throw new UserException("Grad postoji u bazi podataka!");
                }
            }
            var entity = _db.gradovi.Where(s => s.gradId == id).SingleOrDefault();

            entity.nazivGrada = request.nazivGrada;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Grad>(entity);
        }

        public override IEnumerable<eBordo.Model.Models.Grad> Get(object search = null)
        {
            var entity = _db.Set<Database.Grad>()
                .Include(s => s.drzava)
                .AsQueryable();

            if (entity.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Grad>>(result);
        }
        public override eBordo.Model.Models.Grad GetById(int id)
        {
            var entity = _db.Set<Database.Grad>()
                .Where(s => s.gradId == id)
                .Include(s => s.drzava)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Grad>(result);
        }
    }
}
