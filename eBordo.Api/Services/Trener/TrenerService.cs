using AutoMapper;
using eBordo.Api.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBordo.Api.Services.BaseCRUDService;
using Microsoft.EntityFrameworkCore;
using eBordo.Model.Requests.Trener;
using eBordo.Model.Exceptions;

namespace eBordo.Api.Services.Trener
{
    public class TrenerService: BaseCRUDService<eBordo.Model.Models.Trener, eBordo.Api.Database.Trener, eBordo.Model.Requests.Trener.TrenerSearchObject, eBordo.Model.Requests.Trener.TrenerInsertRequest, eBordo.Model.Requests.Trener.TrenerUpdateRequest>, ITrenerService
    {
        private Korisnik.IKorisnikService _korisnikService { get; set; }
        private TrenerStatistika.ITrenerStatistikaService _statistikaService { get; set; }
        private TrenerskaLicenca.ITrenerskaLicencaService _trenerLicenca { get; set; }
        private Formacija.IFormacijaService _formacijaService { get; set; }
        private Ugovor.IUgovorService _ugovorService { get; set; }
        public TrenerService(eBordoContext db, IMapper mapper,
            Korisnik.IKorisnikService korisnikService,
            TrenerStatistika.ITrenerStatistikaService statistikaService,
            TrenerskaLicenca.ITrenerskaLicencaService trenerLicenca,
            Formacija.IFormacijaService formacijaService,
            Ugovor.IUgovorService ugovorService)
            : base(db, mapper)
        {
            _korisnikService = korisnikService;
            _statistikaService = statistikaService;
            _trenerLicenca = trenerLicenca;
            _formacijaService = formacijaService;
            _ugovorService = ugovorService;
        }
        public override IEnumerable<Model.Models.Trener> Get(TrenerSearchObject search = null)
        {
            var entity = _db.Set<Database.Trener>()
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.trenerStatistika)
                .Include(s => s.trenerskaLicenca)
                .Include(s => s.formacija)
                .Include(s => s.ugovor)
                .AsQueryable();

            if (entity.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

            if (search != null && !string.IsNullOrEmpty(search.ime))
            {
                entity = entity.Where(s => s.korisnik.ime.StartsWith(search.ime));
            }
            if (search.isAktivan == false)
            {
                entity = entity.Where(s => !s.korisnik.isAktivan);
            }
            else
            {
                entity = entity.Where(s => s.korisnik.isAktivan);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Trener>>(result);
        }
        public override Model.Models.Trener GetById(int id)
        {
            var entity = _db.treneri.Where(s => s.trenerId == id)
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.trenerStatistika)
                .Include(s => s.trenerskaLicenca)
                .Include(s => s.formacija)
                .Include(s => s.ugovor)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<eBordo.Model.Models.Trener>(result);
        }
        public override Model.Models.Trener Insert(TrenerInsertRequest request)
        {
            var korisnikResult = _korisnikService.Insert(request.korisnikInsertRequest);
            var statistikaResult = _statistikaService.Insert(new object());
            var ugovorResult = _ugovorService.Insert(request.ugovorInsertRequest);

            var korisnik = _db.korisnici.Find(korisnikResult.korisnikId);

            korisnik.isIgrac = false;
            korisnik.isTrener = true;
            korisnik.isAdmin = false;
            _db.SaveChanges();

            var statistika = _db.trenerStatistika.Find(statistikaResult.trenerStatistikaID);
            var ugovor = _db.ugovori.Find(ugovorResult.ugovorId);

            var preferiranaFormacija = _db.formacije.Find(request.preferiranaFormacijaId);
            var trenerskaLicenca = _db.trenerskeLicence.Find(request.trenerskaLicencaId);

            UlogaTrenera ulogaTrenera = request.ulogaTreneraId == 1 ? UlogaTrenera.GLAVNI : UlogaTrenera.POMOĆNI;

            eBordo.Api.Database.Trener trener = new eBordo.Api.Database.Trener
            {
                formacija = preferiranaFormacija,
                trenerskaLicenca = trenerskaLicenca,
                trenerStatistika = statistika,
                ugovor = ugovor,
                korisnik = korisnik,
                slikaPanel = request.SlikaPanel,
                ulogaTrenera = ulogaTrenera
            };

            _db.treneri.Add(trener);
            _db.SaveChanges();

            statistika.trenerID = trener.trenerId;
            _db.SaveChanges();

            ugovor.trenerID = trener.trenerId;
            _db.SaveChanges();

            korisnik.trenerID = trener.trenerId;
            _db.SaveChanges();

            var entity = _db.treneri.Where(s => s.trenerId == trener.trenerId)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.trenerStatistika)
                .Include(s => s.trenerskaLicenca)
                .Include(s => s.formacija)
                .Include(s => s.ugovor)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<eBordo.Model.Models.Trener>(result);
        }
        public override Model.Models.Trener Update(int id, eBordo.Model.Requests.Trener.TrenerUpdateRequest request)
        {
            var entity = _db.treneri.Where(s => s.trenerId == id)
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.trenerStatistika)
                .Include(s => s.trenerskaLicenca)
                .Include(s => s.formacija)
                .Include(s => s.ugovor)
                .SingleOrDefault();

            var korisnikResult = _korisnikService.Update(entity.korisnikId, request.korisnikUpdateRequest);
            var ugovorResult = _ugovorService.Update(entity.ugovorId, request.ugovorUpdateRequeest);

            var preferiranaFormacija = _db.formacije.Find(request.preferiranaFormacijaId);
            var trenerskaLicenca = _db.trenerskeLicence.Find(request.trenerskaLicencaId);

            entity.formacija = preferiranaFormacija;
            entity.trenerskaLicenca = trenerskaLicenca;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Trener>(entity);
        }
        public override Model.Models.Trener Delete(int id)
        {
            var entity = _db.treneri.Where(s => s.trenerId == id)
                .Include(s => s.korisnik)
                .Include(s => s.korisnik.drzavljanstvo)
                .Include(s => s.korisnik.gradRodjenja.drzava)
                .Include(s => s.trenerStatistika)
                .Include(s => s.trenerskaLicenca)
                .Include(s => s.formacija)
                .Include(s => s.ugovor)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            //_db.Remove(result);
            //_db.SaveChanges();

            _korisnikService.Delete(result.korisnikId);
            //_statistikaService.Delete(result.trenerStatistikaId);
            //_ugovorService.Delete(result.ugovorId);

            return _mapper.Map<eBordo.Model.Models.Trener>(result);
        }
    }
}
