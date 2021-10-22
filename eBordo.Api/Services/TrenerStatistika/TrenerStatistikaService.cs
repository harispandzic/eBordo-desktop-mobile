using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.TrenerStatistika
{
    public class TrenerStatistikaService : BaseCRUDService<eBordo.Model.Models.TrenerStatistika, eBordo.Api.Database.TrenerStatistika, object, object, object>, ITrenerStatistikaService
    {
        public TrenerStatistikaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override Model.Models.TrenerStatistika Insert(object request = null)
        {
            eBordo.Api.Database.TrenerStatistika statistika = new eBordo.Api.Database.TrenerStatistika();
            _db.trenerStatistika.Add(statistika);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.TrenerStatistika>(statistika);
        }
        public override Model.Models.TrenerStatistika Delete(int id)
        {
            var entity = _db.trenerStatistika.Where(s => s.trenerStatistikaID == id).FirstOrDefault();

            _db.Remove(entity);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.TrenerStatistika>(entity);
        }
    }
}
