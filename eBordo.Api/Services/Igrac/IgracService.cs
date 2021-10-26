using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Igrac;
using Microsoft.EntityFrameworkCore;
using eBordo.Model.Helpers;

namespace eBordo.Api.Services.Igrac
{
    public class IgracService: BaseCRUDService<eBordo.Model.Models.Igrac, eBordo.Api.Database.Igrac, eBordo.Model.Requests.Igrac.IgracSearchObject, eBordo.Model.Requests.Igrac.IgracInsertRequest, eBordo.Model.Requests.Igrac.IgracUpdateRequest>, IIgracService
    {
        private Korisnik.IKorisnikService _korisnikService { get; set; }
        private IgracStatistika.IIgracStatistikaService _statistikaService { get; set; }
        private IgracSkills.IIgracSkillsService _skillsService { get; set; }
        private Ugovor.IUgovorService _ugovorService { get; set; }
        public IgracService(eBordoContext db, IMapper mapper,
            Korisnik.IKorisnikService korisnikService,
            IgracStatistika.IIgracStatistikaService statistikaService,
            IgracSkills.IIgracSkillsService skillsService,
            Ugovor.IUgovorService ugovorService)
            : base(db, mapper) 
        {
            _korisnikService = korisnikService;
            _statistikaService = statistikaService;
            _skillsService = skillsService;
            _ugovorService = ugovorService;
        }

        public override IEnumerable<Model.Models.Igrac> Get(IgracSearchObject search = null)
        {
            var entity = _db.Set<Database.Igrac>()
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.pozicija)
                .Include(s => s.igracStatistika)
                .Include(s => s.igracSkills)
                .Include(s => s.ugovor)
                .AsQueryable();

            if (search!= null && !string.IsNullOrEmpty(search.ime))
            {
                entity = entity.Where(s => s.korisnik.ime.StartsWith(search.ime));
            }

            if (search != null && search.pozicijaId != -1)
            {
                entity = entity.Where(s => s.pozicijaId == search.pozicijaId);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Igrac>>(result);
        }
        public override Model.Models.Igrac GetById(int id)
        {
            var entity = _db.igraci.Where(s => s.igracId == id)
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.pozicija)
                .Include(s => s.igracStatistika)
                .Include(s => s.igracSkills)
                .Include(s => s.ugovor)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<eBordo.Model.Models.Igrac>(result);
        }
        public override Model.Models.Igrac Insert(IgracInsertRequest request)
        {
            var korisnikResult = _korisnikService.Insert(request.korisnikInsertRequest);
            var statistikaResult = _statistikaService.Insert(new object());
            var skillsResult = _skillsService.Insert(new object());
            var ugovorResult = _ugovorService.Insert(request.ugovorInsertRequest);

            var korisnik = _db.korisnici.Find(korisnikResult.korisnikId);

            korisnik.isIgrac = true;
            korisnik.isTrener = false;
            korisnik.isAdmin = false;
            _db.SaveChanges();

            var statistika = _db.igracStatistika.Find(statistikaResult.igracStatistikaId);
            var skills = _db.igracSkills.Find(skillsResult.igracSkillsId);
            var ugovor = _db.ugovori.Find(ugovorResult.ugovorId);

            var pozicija = _db.pozicije.Where(s => s.pozicijaId == request.pozicijaId).SingleOrDefault();
            BoljaNoga boljaNoga = (BoljaNoga)Enum.Parse(typeof(BoljaNoga), request.noga);

            eBordo.Api.Database.Igrac igrac = new eBordo.Api.Database.Igrac
            {
                visina = request.visina,
                tezina = request.tezina,
                brojDresa = request.brojDresa,
                trzisnaVrijednost = request.trzisnaVrijednost,
                pozicija = pozicija,
                boljaNoga = boljaNoga,
                napomeneOIgracu = request.napomeneOIgracu,
                jacinaSlabijeNoge = request.jacinaSlabijeNoge,
                igracStatistika = statistika,
                igracSkills = skills,
                ugovor = ugovor,
                korisnik = korisnik,
            };

            _db.igraci.Add(igrac);
            _db.SaveChanges();

            statistika.igracId = igrac.igracId;
            _db.SaveChanges();

            skills.igracId = igrac.igracId;
            _db.SaveChanges();

            ugovor.igracId = igrac.igracId;
            _db.SaveChanges();

            korisnik.igracId = igrac.igracId;
            _db.SaveChanges();

            var entity = _db.igraci.Where(s => s.igracId == igrac.igracId)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.pozicija)
                .Include(s => s.igracStatistika)
                .Include(s => s.igracSkills)
                .Include(s => s.ugovor)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<eBordo.Model.Models.Igrac>(result);
        }
        public override Model.Models.Igrac Update(int id, eBordo.Model.Requests.Igrac.IgracUpdateRequest request)
        {
            var entity = _db.igraci.Where(s => s.igracId == id)
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.pozicija)
                .Include(s => s.igracStatistika)
                .Include(s => s.igracSkills)
                .Include(s => s.ugovor)
                .SingleOrDefault();

            var korisnikResult = _korisnikService.Update(entity.korisnikId, request.korisnikUpdateRequest);
            var ugovorResult = _ugovorService.Update(entity.ugovorId, request.ugovorUpdateRequeest);

            entity.visina = request.visina;
            entity.tezina = request.tezina;
            entity.brojDresa = request.brojDresa;
            entity.trzisnaVrijednost = request.trzisnaVrijednost;
            //entity.slika = request.slika;
            entity.pozicijaId = request.pozicijaId;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Igrac>(entity);
        }
        public override Model.Models.Igrac Delete(int id)
        {
            var entity = _db.igraci.Where(s => s.igracId == id)
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.pozicija)
                .Include(s => s.igracStatistika)
                .Include(s => s.igracSkills)
                .Include(s => s.ugovor)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            _db.Remove(result);
            _db.SaveChanges();

            _korisnikService.Delete(result.korisnikId);
            _statistikaService.Delete(result.igracStatistikaId);
            _skillsService.Delete(result.igracSkillsId);
            _ugovorService.Delete(result.ugovorId);

            return _mapper.Map<eBordo.Model.Models.Igrac>(result);
        }
    }
}
