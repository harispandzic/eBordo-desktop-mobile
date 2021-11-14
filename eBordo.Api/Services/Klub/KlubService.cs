using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Klub
{
    public class KlubService : BaseREADService<eBordo.Model.Models.Klub, eBordo.Api.Database.Klub, object>, IKlubService
    {
        public KlubService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override IEnumerable<eBordo.Model.Models.Klub> Get(object search = null)
        {
            var entity = _db.Set<Database.Klub>()
                .Include(s => s.grad)
                .Include(s => s.grad.drzava)
                .Include(s => s.stadion)
                .Include(s => s.stadion.lokacijaStadiona)
                .Include(s => s.stadion.lokacijaStadiona.drzava)
                .AsQueryable();

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
