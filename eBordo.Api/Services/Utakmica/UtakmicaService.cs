using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Api.Services.UtakmicaSastav;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Utakmica;
using eBordo.Model.Requests.UtakmicaSastav;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Utakmica
{
    public class UtakmicaService : BaseCRUDService<eBordo.Model.Models.Utakmica,eBordo.Api.Database.Utakmica, eBordo.Model.Requests.Utakmica.UtakmicaSearchObject, eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest, eBordo.Model.Requests.Utakmica.UtakmicaUpdateRequest>, IUtakmicaService
    {
        private IUtakmicaSastavService _utakmicaSastavService { get; set; }

        public UtakmicaService(eBordoContext db, IMapper mapper, IUtakmicaSastavService utakmicaSastavService)
            : base(db, mapper)
        {
            _utakmicaSastavService = utakmicaSastavService;
        }

        public override IEnumerable<Model.Models.Utakmica> Get(UtakmicaSearchObject search = null)
        {
            var entity = _db.utakmice
                .Include(s => s.stadion)
                .Include(s => s.takmicenje)
                .Include(s => s.kapiten)
                .Include(s => s.kapiten.korisnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .Include(s => s.protivnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .OrderByDescending(s => s.datumOdigravanja)
                .AsQueryable();

            if (search != null && !string.IsNullOrEmpty(search.tipUtakmice))
            {
                if(search.tipUtakmice == "Domaća")
                {
                    entity = entity.Where(s => s.vrstaUtakmice == VrstaUtakmice.Domaća);
                }
                if (search.tipUtakmice == "Gostujuća")
                {
                    entity = entity.Where(s => s.vrstaUtakmice == VrstaUtakmice.Gostujuća);
                }
            }
            if (search != null)
            {
                entity = entity.Where(s => s.odigrana == search.odigrana);
                if (search.isNarednaUtakmica)
                {
                    entity = entity.Where(s => s.datumOdigravanja.Date >= DateTime.Now.Date).OrderBy(s => s.datumOdigravanja).Take(1);
                }
                if (search.isSearchTop3)
                {
                    entity = entity.Where(s => s.datumOdigravanja.Date >= DateTime.Now.Date).OrderBy(s => s.datumOdigravanja).Take(3);
                }
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Utakmica>>(result);
        }
        public override Model.Models.Utakmica GetById(int id)
        {
            var entity = _db.utakmice
                .Where(s => s.utakmicaId == id)
                .Include(s => s.stadion)
                .Include(s => s.takmicenje)
                .Include(s => s.kapiten)
                .Include(s => s.kapiten.korisnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .Include(s => s.protivnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .AsQueryable();

            var result = entity.SingleOrDefault();

            return _mapper.Map<Model.Models.Utakmica>(result);
        }
        public override Model.Models.Utakmica Insert(UtakmicaInsertRequest request)
        {
            foreach (var item in _db.utakmice)
            {
                if(item.datumOdigravanja.Date == request.datumOdigravanja.Date)
                {
                    throw new UserException("Odabrani datum je zauzet. Vec je evidentirana utakmica!");
                }
            }
            foreach (var item in _db.trening)
            {
                if (item.datumOdrzavanja.Date == request.datumOdigravanja.Date)
                {
                    throw new UserException("Odabrani datum je zauzet. Vec je evidentiran trening!");
                }
            }
            Garnitura tipGarniture = (Garnitura)Enum.Parse(typeof(Garnitura), request.tipGarniture);
            VrstaUtakmice vrstaUtakmice = (VrstaUtakmice)Enum.Parse(typeof(VrstaUtakmice), request.tipUtakmice);

            eBordo.Api.Database.Utakmica utakmica = new Database.Utakmica
            {
                datumOdigravanja = request.datumOdigravanja,
                satnica = request.satnica,
                sudija = request.sudija,    
                stadionId = request.stadionId,
                napomene = request.napomene,
                opisUtakmice = request.opisUtakmice,
                takmicenjeId = request.takmicenjeId,
                kapitenId = request.kapitenId,
                trenerId = request.trenerId,
                protivnikId = request.protivnikId,
                tipGarniture = tipGarniture,
                vrstaUtakmice = vrstaUtakmice, 
                odigrana = false
            };

            _db.Add(utakmica);
            _db.SaveChanges();

            if (request.sastav.Count != 0)
            {
                foreach (var item in request.sastav)
                {
                    Model.Models.UtakmicaSastav sastavResultModel = _utakmicaSastavService.InsertByUtakmicaId(item, utakmica.utakmicaId);
                }
            }

            ICollection<Database.UtakmicaSastav> sastavResultDatabase = _db.utakmicaSastav.Where(s => s.utakmicaId == utakmica.utakmicaId).ToList();

            Database.Utakmica utakmicaSearch = _db.utakmice.Where(s => s.utakmicaId == utakmica.utakmicaId).SingleOrDefault();

            utakmica.sastav = sastavResultDatabase;

            _db.SaveChanges();

            var entity = _db.utakmice
                .Where(s => s.utakmicaId == utakmica.utakmicaId)
                .Include(s => s.stadion)
                .Include(s => s.takmicenje)
                .Include(s => s.kapiten)
                .Include(s => s.kapiten.korisnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .Include(s => s.protivnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Utakmica>(result);
        }
        public override Model.Models.Utakmica Update(int id, UtakmicaUpdateRequest request)
        {
            foreach (var item in _db.utakmice)
            {
                if (item.datumOdigravanja.Date == request.datumOdigravanja.Date)
                {
                    throw new UserException("Odabrani datum je zauzet. Vec je evidentirana utakmica!");
                }
            }
            foreach (var item in _db.trening)
            {
                if (item.datumOdrzavanja.Date == request.datumOdigravanja.Date)
                {
                    throw new UserException("Odabrani datum je zauzet. Vec je evidentiran trening!");
                }
            }
            Database.Utakmica utakmica = _db.utakmice.Where(s => s.utakmicaId == id).SingleOrDefault();

            utakmica.datumOdigravanja = request.datumOdigravanja;
            utakmica.satnica = request.satnica;
            utakmica.napomene = request.napomene;
            utakmica.kapitenId = request.kapitenId;
            utakmica.odigrana = false;

            _db.SaveChanges();

            if (request.sastav.Count != 0)
            {
                foreach (var item in request.sastav)
                {
                    if (item.utakmicaSastavid == 0)
                    {
                        UtakmicaSastavInsertRequest sastav = new UtakmicaSastavInsertRequest
                        {
                            igracId = item.igracId,
                            utakmicaId = item.utakmicaId,
                            pozicijaId = item.pozicijaId,
                            uloga = item.uloga
                        };
                        _utakmicaSastavService.InsertByUtakmicaId(sastav, utakmica.utakmicaId);
                    }
                    else
                    {
                        _utakmicaSastavService.UpdateByUtakmicaId(item, id, item.igracId);
                    }
                }
            }

            ICollection<Database.UtakmicaSastav> sastavResultDatabase = _db.utakmicaSastav.Where(s => s.utakmicaId == utakmica.utakmicaId).ToList();

            Database.Utakmica utakmicaSearch = _db.utakmice.Where(s => s.utakmicaId == id).SingleOrDefault();

            utakmica.sastav = sastavResultDatabase;

            _db.SaveChanges();

            var entity = _db.utakmice
                .Where(s => s.utakmicaId == utakmica.utakmicaId)
                .Include(s => s.stadion)
                .Include(s => s.takmicenje)
                .Include(s => s.kapiten)
                .Include(s => s.kapiten.korisnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .Include(s => s.protivnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Utakmica>(result);
        }
        public override Model.Models.Utakmica Delete(int id)
        {
            var entity = _db.utakmice
                .Where(s => s.utakmicaId == id)
                .Include(s => s.stadion)
                .Include(s => s.takmicenje)
                .Include(s => s.kapiten)
                .Include(s => s.kapiten.korisnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .Include(s => s.protivnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.sastav)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            var sastavResultDatabase = _db.utakmicaSastav.Where(s => s.utakmicaId == id).ToList();

            foreach (var item in sastavResultDatabase)
            {
                Model.Models.UtakmicaSastav sastavResultModel = _utakmicaSastavService.Delete(item.utakmicaSastavId);
                _db.SaveChanges();
            }

            _db.Remove(result);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Utakmica>(result);
        }
    }
}
