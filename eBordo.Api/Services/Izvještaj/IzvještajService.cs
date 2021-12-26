using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Api.Services.Notifikacija;
using eBordo.Api.Services.UtakmicaIzmjena;
using eBordo.Api.Services.UtakmicaNastupService;
using eBordo.Model.Requests.Izvještaj;
using eBordo.Model.Requests.UtakmicaIzmjena;
using eBordo.Model.Requests.UtakmicaNastup;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Izvještaj
{
    public class IzvještajService : BaseCRUDService<eBordo.Model.Models.Izvještaj, eBordo.Api.Database.Izvještaj, eBordo.Model.Requests.Izvještaj.IzvjestajSearchObject, eBordo.Model.Requests.Izvještaj.IzvjetajInsertRequest, eBordo.Model.Requests.Izvještaj.IzvjestajUpdateRequest>, IIzvještajService
    {
        private IUtakmicaNastupService _utakmicaNastupService { get; set; }
        private IUtakmicaIzmjenaService _utakmicaIzmjenaService { get; set; }
        private INotifikacijaService _notifikacijaService { get; set; }

        public IzvještajService(eBordoContext db, IMapper mapper, IUtakmicaNastupService utakmicaNastupService, IUtakmicaIzmjenaService utakmicaIzmjenaService, INotifikacijaService notifikacijaService)
            : base(db, mapper)
        {
            _utakmicaNastupService = utakmicaNastupService;
            _utakmicaIzmjenaService = utakmicaIzmjenaService;
            _notifikacijaService = notifikacijaService;
        }
        public override IEnumerable<Model.Models.Izvještaj> Get(IzvjestajSearchObject search = null)
        {
            var entity = _db.izvještaj
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.igracUtakmica)
                .Include(s => s.igracUtakmica.korisnik)
                .Include(s => s.utakmica)
                .Include(s => s.utakmica.stadion)
                .Include(s => s.utakmica.takmicenje)
                .Include(s => s.utakmica.kapiten)
                .Include(s => s.utakmica.kapiten.korisnik)
                .Include(s => s.utakmica.trener)
                .Include(s => s.utakmica.trener.korisnik)
                .Include(s => s.utakmica.protivnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .AsQueryable();

            if (search != null && !string.IsNullOrEmpty(search.tipUtakmice))
            {
                if (search.tipUtakmice == "Domaća")
                {
                    entity = entity.Where(s => s.utakmica.vrstaUtakmice == VrstaUtakmice.Domaća);
                }
                if (search.tipUtakmice == "Gostujuća")
                {
                    entity = entity.Where(s => s.utakmica.vrstaUtakmice == VrstaUtakmice.Gostujuća);
                }
            }
            if (search != null && !string.IsNullOrEmpty(search.rezultat))
            {
                if (search.tipUtakmice == "Pobjeda")
                {
                    entity = entity.Where(s => s.rezultat == Rezultat.POBJEDA);
                }
                if (search.tipUtakmice == "Poraz")
                {
                    entity = entity.Where(s => s.rezultat == Rezultat.PORAZ);
                }
                if (search.tipUtakmice == "Nerješeno")
                {
                    entity = entity.Where(s => s.rezultat == Rezultat.NERJEŠENO);
                }
            }
            if (search.isSearchZadnjaUtakmica)
            {
                entity = entity.Where(s => s.utakmica.datumOdigravanja.Date <= DateTime.Now.Date).OrderByDescending(s => s.utakmica.datumOdigravanja).Take(1);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Izvještaj>>(result);
        }
        public override Model.Models.Izvještaj GetById(int id)
        {
            var entity = _db.izvještaj
                .Where(s => s.izvještajId == id)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.igracUtakmica)
                .Include(s => s.igracUtakmica.korisnik)
                .Include(s => s.utakmica)
                .Include(s => s.utakmica.stadion)
                .Include(s => s.utakmica.takmicenje)
                .Include(s => s.utakmica.kapiten)
                .Include(s => s.utakmica.kapiten.korisnik)
                .Include(s => s.utakmica.trener)
                .Include(s => s.utakmica.trener.korisnik)
                .Include(s => s.utakmica.protivnik)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .AsQueryable();

            var result = entity.SingleOrDefault();

            return _mapper.Map<Model.Models.Izvještaj>(result);
        }
        public override Model.Models.Izvještaj Insert(IzvjetajInsertRequest request)
        {
            string rezultat = "";
            if (request.goloviSarajevo > request.goloviProtivnik)
            {
                rezultat = "POBJEDA";
            }
            else if (request.goloviSarajevo < request.goloviProtivnik)
            {
                rezultat = "PORAZ";
            }
            else if (request.goloviSarajevo == request.goloviProtivnik)
            {
                rezultat = "NERJEŠENO";
            }
            eBordo.Api.Database.Izvještaj izvjestaj = new Database.Izvještaj
            {
                goloviSarajevo = request.goloviSarajevo,
                goloviProtivnik = request.goloviProtivnik,
                rezultat = (Rezultat)Enum.Parse(typeof(Rezultat), rezultat),
                datumKreiranja = DateTime.Now,
                zapisnik = request.zapisnik,
                slikaSaUtakmice = request.slikaSaUtakmice,
                vrijeme = Vrijeme.KIŠA,
                igracUtakmicaID = request.igracUtakmicaID,
                utakmicaID = request.utakmicaID,
                trenerID = request.trenerID,
            };

            _db.Add(izvjestaj);
            _db.SaveChanges();

            var igraciUtakmica = _db.utakmicaSastav.Where(s => s.utakmicaId == request.utakmicaID).Include(s => s.igrac).ToList();

            foreach (var item in igraciUtakmica)
            {
                Model.Requests.Notifikacija.NotifikacijaInsertRequest notifikacijaInsert = new Model.Requests.Notifikacija.NotifikacijaInsertRequest
                {
                    tekstNotifikacije = "Utakmica je uspješno pohranjena!",
                    korisnikId = item.igrac.korisnikId,
                    tipNotifikacije = "Obavještenje"
                };
                _notifikacijaService.Insert(notifikacijaInsert);
            }

           
            Database.Izvještaj izvjestajSearch = _db.izvještaj.Where(s => s.utakmicaID == request.utakmicaID).SingleOrDefault();

            if (request.utakmicaNastup.Count != 0)
            {
                foreach (var item in request.utakmicaNastup)
                {
                    _utakmicaNastupService.Insert(item);
                }
            }

            ICollection<Database.UtakmicaNastup> nastupiUtakmicaDatabase = _db.utakmicaNastup.Where(s => s.utakmicaId == request.utakmicaID).ToList();

            if (request.izmjene.Count != 0)
            {
                foreach (var item in request.izmjene)
                {
                    _utakmicaIzmjenaService.Insert(item);
                }
            }

            ICollection<Database.UtakmicaIzmjena> izmjenaUtakmicaDatabase = _db.utakmicaIzmjena.Where(s => s.utakmicaId == request.utakmicaID).ToList();

            izvjestajSearch.nastupi = nastupiUtakmicaDatabase;
            izvjestajSearch.izmjene = izmjenaUtakmicaDatabase;

            Database.Utakmica utakmicaSearch = _db.utakmice.Where(s => s.utakmicaId == request.utakmicaID).SingleOrDefault();

            utakmicaSearch.odigrana = true;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Izvještaj>(izvjestaj);
        }
        public override Model.Models.Izvještaj Update(int id, IzvjestajUpdateRequest request)
        {
            Database.Izvještaj izvjestaj = _db.izvještaj.Where(s => s.izvještajId == id).SingleOrDefault();

            izvjestaj.zapisnik = request.zapisnik;

            _db.SaveChanges();

            if (request.utakmicaNastup.Count != 0)
            {
                foreach (var item in request.utakmicaNastup)
                {
                    if (item.utakmicaNastupId == 0)
                    {
                        UtakmicaNastupInsertRequest nastup = new UtakmicaNastupInsertRequest
                        {
                            igracId = item.igracId,
                            trenerId = item.trenerId,
                            utakmicaId = item.utakmicaId,
                            minute = item.minute,
                            golovi = item.golovi,
                            asistencije = item.asistencije,
                            zutiKartoni = item.zutiKartoni,
                            crveniKartoni = item.crveniKartoni,
                            ocjena = item.ocjena,
                            komentar = item.komentar
                        };
                        _utakmicaNastupService.Insert(nastup);
                    }
                    else
                    {
                        _utakmicaNastupService.Update(item.utakmicaNastupId, item);
                    }
                }
            }

            ICollection<Database.UtakmicaNastup> nastupiUtakmicaDatabase = _db.utakmicaNastup.Where(s => s.utakmicaId == request.utakmicaId).ToList();

         
            if (request.izmjene.Count != 0)
            {
                foreach (var item in request.izmjene)
                {
                    if (item.utakmicaIzmjenaId == 0)
                    {
                        UtakmicaIzmjenaInsertRequest izmjena = new UtakmicaIzmjenaInsertRequest
                        {
                            utakmicaId = item.utakmicaId,
                            igracOutId = item.igracOutId,
                            igracInId = item.igracInId,
                            minuta = item.minuta,
                            izmjenaRazlog = item.izmjenaRazlog
                        };
                        _utakmicaIzmjenaService.Insert(izmjena);
                    }
                    else
                    {
                        _utakmicaIzmjenaService.Update(item.utakmicaIzmjenaId,item);
                    }
                }
            }

            ICollection<Database.UtakmicaIzmjena> izmjenaUtakmicaDatabase = _db.utakmicaIzmjena.Where(s => s.utakmicaId == request.utakmicaId).ToList();

            izvjestaj.nastupi = nastupiUtakmicaDatabase;
            izvjestaj.izmjene = izmjenaUtakmicaDatabase;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Izvještaj>(izvjestaj);
        }
        public override Model.Models.Izvještaj Delete(int id)
        {
            var entity = _db.izvještaj.Where(s => s.izvještajId == id).FirstOrDefault();

            var utakmicaNastupi = _db.utakmicaNastup.Where(s => s.utakmicaId == entity.utakmicaID).ToList();

            foreach (var item in utakmicaNastupi)
            {
                Model.Models.UtakmicaNastup nastupResultModel = _utakmicaNastupService.Delete(item.utakmicaNastupId);
                _db.SaveChanges();
            }
            var utakmicaIzmjene = _db.utakmicaIzmjena.Where(s => s.utakmicaId == entity.utakmicaID).ToList();

            foreach (var item in utakmicaIzmjene)
            {
                Model.Models.UtakmicaIzmjena izmjenaResultModel = _utakmicaIzmjenaService.Delete(item.utakmicaIzmjenaID);
                _db.SaveChanges();
            }

            Database.Utakmica utakmica = _db.utakmice.Where(s => s.utakmicaId == entity.utakmicaID).SingleOrDefault();

            utakmica.odigrana = false;

            _db.SaveChanges();

            _db.Remove(entity);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.Izvještaj>(entity);
        }
    }
}
