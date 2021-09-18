using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Grad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Grad
{
    public class GradService: BaseCRUDService<eBordo.Model.Models.Grad, eBordo.Api.Database.Grad, eBordo.Model.Requests.Grad.GradSearchObject, eBordo.Model.Requests.Grad.GradInsertRequest, eBordo.Model.Requests.Grad.GradUpdateRequest>, IGradService
    {
        public GradService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override IEnumerable<eBordo.Model.Models.Grad> Get(GradSearchObject search = null)
        {
            var entity = _db.Set<Database.Grad>().AsQueryable();

            if (search != null && search?.includeList?.Length > 0)
            {
                foreach (var item in search.includeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Models.Grad>>(list);
        }
        public override eBordo.Model.Models.Grad GetById(int id, GradSearchObject search = null)
        {
            var entity = _db.Set<Database.Grad>().AsQueryable();

            if (search != null && search?.includeList?.Length > 0)
            {
                foreach (var item in search.includeList)
                {
                    entity = entity.Include(item);
                }
            }

            var result = entity.Where(s => s.gradId == id).FirstOrDefault();

            return _mapper.Map<Model.Models.Grad>(result);
        }
    }
}
