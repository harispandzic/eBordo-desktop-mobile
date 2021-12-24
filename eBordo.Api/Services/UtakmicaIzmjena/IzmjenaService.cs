using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.UtakmicaIzmjena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaIzmjena
{
    public class UtakmicaIzmjenaService : BaseCRUDService<eBordo.Model.Models.UtakmicaIzmjena, eBordo.Api.Database.UtakmicaIzmjena, object, eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest, eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaUpdateRequest>, IUtakmicaIzmjenaService
    {
        public UtakmicaIzmjenaService(eBordoContext db, IMapper mapper)
            : base(db, mapper)
        {
        }
        public override Model.Models.UtakmicaIzmjena Insert(UtakmicaIzmjenaInsertRequest request)
        {
            eBordo.Api.Database.UtakmicaIzmjena novaIzmjena = new Database.UtakmicaIzmjena
            {
                utakmicaId = request.utakmicaId,
                igracOutId = request.igracOutId,
                igracInId = request.igracInId,
                minuta = request.minuta,
                izmjenaRazlog = (IzmjenaRazlog)Enum.Parse(typeof(IzmjenaRazlog), request.izmjenaRazlog)
        };

            _db.Add(novaIzmjena);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaIzmjena>(novaIzmjena);
        }
        public override Model.Models.UtakmicaIzmjena Update(int id, UtakmicaIzmjenaUpdateRequest request)
        {
            Database.UtakmicaIzmjena utakmicaIzmjena = _db.utakmicaIzmjena.Where(s => s.utakmicaIzmjenaID == id).SingleOrDefault();

            utakmicaIzmjena.igracOutId = request.igracOutId;
            utakmicaIzmjena.igracInId = request.igracInId;
            utakmicaIzmjena.minuta = request.minuta;
            utakmicaIzmjena.izmjenaRazlog = (IzmjenaRazlog)Enum.Parse(typeof(IzmjenaRazlog), request.izmjenaRazlog.ToUpper());
            
            return _mapper.Map<Model.Models.UtakmicaIzmjena>(utakmicaIzmjena);
        }
        public override Model.Models.UtakmicaIzmjena Delete(int utakmicaIzmjenaId)
        {
            Database.UtakmicaIzmjena utakmicaIzmjena = _db.utakmicaIzmjena.Where(s => s.utakmicaIzmjenaID == utakmicaIzmjenaId).SingleOrDefault();

            _db.Remove(utakmicaIzmjena);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaIzmjena>(utakmicaIzmjena);
        }
    }
}
