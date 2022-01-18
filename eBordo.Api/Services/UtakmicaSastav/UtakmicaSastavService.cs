using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.UtakmicaSastav;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaSastav
{
    public class UtakmicaSastavService : BaseCRUDService<eBordo.Model.Models.UtakmicaSastav, eBordo.Api.Database.UtakmicaSastav, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavSearchObject, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavUpdateRequest>, IUtakmicaSastavService
    {
        public UtakmicaSastavService(eBordoContext db, IMapper mapper)
            : base(db, mapper)
        { }
        public override IEnumerable<Model.Models.UtakmicaSastav> Get(UtakmicaSastavSearchObject search)
        {
            var utakmicaSastav = _db.utakmicaSastav
                .Where(s => s.utakmicaId == search.utakmicaId)
                .Include(s => s.igrac)
                .Include(s => s.igrac.pozicija)
                .Include(s => s.igrac.korisnik)
                .Include(s => s.igrac.igracStatistika)
                .AsQueryable();

            if (utakmicaSastav.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

            var result = utakmicaSastav.ToList();

            return _mapper.Map<List<Model.Models.UtakmicaSastav>>(result);
        }
        public Model.Models.UtakmicaSastav InsertByUtakmicaId(UtakmicaSastavInsertRequest request, int utakmicaId)
        {
            SastavUloga uloga = (SastavUloga)Enum.Parse(typeof(SastavUloga), request.uloga);

            Database.UtakmicaSastav utakmicaSastav = new Database.UtakmicaSastav
            {
                igracId = request.igracId,
                pozicijaId = request.pozicijaId,
                utakmicaId = utakmicaId,
                uloga = uloga
            };

            _db.Add(utakmicaSastav);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaSastav>(utakmicaSastav);
        }
        public Model.Models.UtakmicaSastav UpdateByUtakmicaId(UtakmicaSastavUpdateRequest request, int utakmicaId, int igracId)
        {
            Database.UtakmicaSastav utakmicaSastav = _db.utakmicaSastav.Where(s => s.utakmicaId == utakmicaId && s.igracId == igracId).SingleOrDefault();

            SastavUloga uloga = (SastavUloga)Enum.Parse(typeof(SastavUloga), request.uloga);

            utakmicaSastav.igracId = request.igracId;
            utakmicaSastav.pozicijaId = request.pozicijaId;
            utakmicaSastav.utakmicaId = utakmicaId;
            utakmicaSastav.uloga = uloga;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaSastav>(utakmicaSastav);
        }
        public Model.Models.UtakmicaSastav DeleteByUtakmicaId(int utakmicaSastavId)
        {
            Database.UtakmicaSastav utakmicaSastav = _db.utakmicaSastav.Where(s => s.utakmicaSastavId == utakmicaSastavId).SingleOrDefault();

            _db.Remove(utakmicaSastav);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaSastav>(utakmicaSastav);
        }
    }
}
