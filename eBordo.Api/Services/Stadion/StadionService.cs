using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Stadion
{
    public class StadionService : BaseREADService<eBordo.Model.Models.Stadion, eBordo.Api.Database.Stadion, object>, IStadionService
    {
        public StadionService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override IEnumerable<eBordo.Model.Models.Stadion> Get(object search = null)
        {
            var entity = _db.Set<Database.Stadion>()
                .Include(s => s.lokacijaStadiona)
                .Include(s => s.lokacijaStadiona.drzava)
                .AsQueryable();

            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Stadion>>(result);
        }
        public override eBordo.Model.Models.Stadion GetById(int id)
        {
            var entity = _db.Set<Database.Stadion>()
                .Where(s => s.stadionId == id)
                .Include(s => s.lokacijaStadiona)
                .Include(s => s.lokacijaStadiona.drzava)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Stadion>(result);
        }
    }
}
