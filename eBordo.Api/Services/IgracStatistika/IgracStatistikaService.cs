using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;

namespace eBordo.Api.Services.IgracStatistika
{
    public class IgracStatistikaService: BaseCRUDService<eBordo.Model.Models.IgracStatistika, eBordo.Api.Database.IgracStatistika, object, object, object>, IIgracStatistikaService

    {
        public IgracStatistikaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override Model.Models.IgracStatistika Insert(object request = null)
        {
            eBordo.Api.Database.IgracStatistika statistika = new eBordo.Api.Database.IgracStatistika();
            _db.igracStatistika.Add(statistika);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.IgracStatistika>(statistika);
        }
        public override Model.Models.IgracStatistika Delete(int id)
        {
            var entity = _db.igracStatistika.Where(s => s.igracStatistikaId == id).FirstOrDefault();

            _db.Remove(entity);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.IgracStatistika>(entity);
        }
    }
}
