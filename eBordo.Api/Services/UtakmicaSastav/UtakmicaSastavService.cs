using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.UtakmicaSastav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaSastav
{
    public class UtakmicaSastavService: IUtakmicaSastavService
    {
        public eBordoContext _db { get; set; }
        protected readonly IMapper _mapper;

        public UtakmicaSastavService(eBordoContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Model.Models.UtakmicaSastav Insert(UtakmicaSastavInsertRequest request, int utakmicaId)
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
        public Model.Models.UtakmicaSastav Update(UtakmicaSastavUpdateRequest request, int utakmicaId, int igracId)
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
        public Model.Models.UtakmicaSastav Delete(int utakmicaSastavId)
        {
            Database.UtakmicaSastav utakmicaSastav = _db.utakmicaSastav.Where(s => s.utakmicaSastavId == utakmicaSastavId).SingleOrDefault();

            _db.Remove(utakmicaSastav);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaSastav>(utakmicaSastav);
        }
    }
}
