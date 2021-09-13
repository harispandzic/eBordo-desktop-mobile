using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Grad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.GradService
{
    public class GradService: BaseCRUDService<eBordo.Model.Models.Grad, eBordo.Api.Database.Grad, eBordo.Model.Requests.Grad.GradSearchRequest, eBordo.Model.Requests.Grad.GradInsertRequest, object>, IGradService
    {
        public GradService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override IEnumerable<eBordo.Model.Models.Grad> Get(GradSearchRequest search = null)
        {
            var entity = _db.Set<Database.Grad>().AsQueryable();

            if (search != null &&  search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<eBordo.Model.Models.Grad>>(list);
        }
    }
}

