using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Api.Services.Notifikacija;
using eBordo.Api.Services.UtakmicaIzmjena;
using eBordo.Api.Services.UtakmicaNastupService;
using eBordo.Model.Exceptions;
using eBordo.Model.Requests.Izvjestaj;
using eBordo.Model.Requests.Notifikacija;
using eBordo.Model.Requests.UtakmicaIzmjena;
using eBordo.Model.Requests.UtakmicaNastup;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vonage;
using Vonage.Request;

namespace eBordo.Api.Services.Izvjestaj
{
    public class IzvjestajService : BaseCRUDService<eBordo.Model.Models.Izvjestaj, eBordo.Api.Database.Izvjestaj, eBordo.Model.Requests.Izvjestaj.IzvjestajSearchObject, eBordo.Model.Requests.Izvjestaj.IzvjetajInsertRequest, eBordo.Model.Requests.Izvjestaj.IzvjestajUpdateRequest>, IIzvjestajService
    {
        private IUtakmicaNastupService _utakmicaNastupService { get; set; }
        private IUtakmicaIzmjenaService _utakmicaIzmjenaService { get; set; }
        private INotifikacijaService _notifikacijaService { get; set; }

        public IzvjestajService(eBordoContext db, IMapper mapper, IUtakmicaNastupService utakmicaNastupService, IUtakmicaIzmjenaService utakmicaIzmjenaService, INotifikacijaService notifikacijaService)
            : base(db, mapper)
        {
            _utakmicaNastupService = utakmicaNastupService;
            _utakmicaIzmjenaService = utakmicaIzmjenaService;
            _notifikacijaService = notifikacijaService;
        }
        public override IEnumerable<Model.Models.Izvjestaj> Get(IzvjestajSearchObject search = null)
        {
            var entity = _db.izvjestaj
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik.gradRodjenja)
                    .ThenInclude(t => t.drzava)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                    .ThenInclude(t => t.drzavljanstvo)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.pozicija)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.ugovor)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik.gradRodjenja)
                    .ThenInclude(t => t.drzava)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik)
                    .ThenInclude(t => t.drzavljanstvo)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.igracStatistika)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.igracSkills)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.ugovor)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik.gradRodjenja)
                    .ThenInclude(t => t.drzava)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik)
                    .ThenInclude(t => t.drzavljanstvo)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.igracStatistika)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.igracSkills)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.ugovor)
                .Include(s => s.igracUtakmica)
                .Include(s => s.igracUtakmica.igracStatistika)
                .Include(s => s.igracUtakmica.igracSkills)
                .Include(s => s.igracUtakmica.pozicija)
                .Include(s => s.igracUtakmica.korisnik)
                .Include(s => s.igracUtakmica.korisnik.drzavljanstvo)
                .Include(s => s.igracUtakmica.korisnik.gradRodjenja.drzava)
                .Include(s => s.igracUtakmica.ugovor)
                .Include(s => s.utakmica)
                .Include(s => s.utakmica.stadion)
                .Include(s => s.utakmica.stadion.lokacijaStadiona)
                .Include(s => s.utakmica.stadion.lokacijaStadiona.drzava)
                .Include(s => s.utakmica.takmicenje)
                .Include(s => s.utakmica.kapiten)
                .Include(s => s.utakmica.kapiten.igracStatistika)
                .Include(s => s.utakmica.kapiten.igracSkills)
                .Include(s => s.utakmica.kapiten.pozicija)
                .Include(s => s.utakmica.kapiten.korisnik)
                .Include(s => s.utakmica.kapiten.korisnik.drzavljanstvo)
                .Include(s => s.utakmica.kapiten.korisnik.gradRodjenja.drzava)
                .Include(s => s.utakmica.kapiten.ugovor)
                .Include(s => s.utakmica.trener)
                .Include(s => s.utakmica.trener.trenerStatistika)
                .Include(s => s.utakmica.trener.trenerskaLicenca)
                .Include(s => s.utakmica.trener.formacija)
                .Include(s => s.utakmica.trener.ugovor)
                .Include(s => s.utakmica.trener.korisnik)
                .Include(s => s.utakmica.trener.korisnik.drzavljanstvo)
                .Include(s => s.utakmica.trener.korisnik.gradRodjenja.drzava)
                .Include(s => s.utakmica.protivnik)
                .Include(s => s.utakmica.protivnik.stadion)
                .Include(s => s.utakmica.protivnik.stadion.lokacijaStadiona)
                .Include(s => s.utakmica.protivnik.stadion.lokacijaStadiona.drzava)
                .Include(s => s.utakmica.protivnik.grad)
                .Include(s => s.utakmica.protivnik.grad.drzava)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .AsQueryable();


            if (entity.Count() == 0)
            {
                throw new UserException("Nema podataka!");
            }

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
                if (search.rezultat == "Pobjeda")
                {
                    entity = entity.Where(s => s.rezultat == Rezultat.POBJEDA);
                }
                if (search.rezultat == "Poraz")
                {
                    entity = entity.Where(s => s.rezultat == Rezultat.PORAZ);
                }
                if (search.rezultat == "Nerješeno")
                {
                    entity = entity.Where(s => s.rezultat == Rezultat.NERJEŠENO);
                }
            }
            if (search.isSearchZadnjaUtakmica)
            {
                entity = entity.Where(s => s.utakmica.datumOdigravanja.Date <= DateTime.Now.Date).OrderByDescending(s => s.utakmica.datumOdigravanja).Take(1);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Izvjestaj>>(result);
        }
        public override Model.Models.Izvjestaj GetById(int id)
        {
            var entity = _db.izvjestaj
                .Where(s => s.izvjestajId == id)
            .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik.gradRodjenja)
                    .ThenInclude(t => t.drzava)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac)
                    .ThenInclude(t => t.korisnik)
                    .ThenInclude(t => t.drzavljanstvo)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.igracStatistika)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.igracSkills)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.pozicija)
                .Include(s => s.nastupi)
                    .ThenInclude(t => t.igrac.ugovor)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik.gradRodjenja)
                    .ThenInclude(t => t.drzava)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn)
                    .ThenInclude(t => t.korisnik)
                    .ThenInclude(t => t.drzavljanstvo)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.igracStatistika)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.igracSkills)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracIn.ugovor)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik.gradRodjenja)
                    .ThenInclude(t => t.drzava)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut)
                    .ThenInclude(t => t.korisnik)
                    .ThenInclude(t => t.drzavljanstvo)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.igracStatistika)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.igracSkills)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.pozicija)
                .Include(s => s.izmjene)
                    .ThenInclude(t => t.igracOut.ugovor)
                .Include(s => s.igracUtakmica)
                .Include(s => s.igracUtakmica.igracStatistika)
                .Include(s => s.igracUtakmica.igracSkills)
                .Include(s => s.igracUtakmica.pozicija)
                .Include(s => s.igracUtakmica.korisnik)
                .Include(s => s.igracUtakmica.korisnik.drzavljanstvo)
                .Include(s => s.igracUtakmica.korisnik.gradRodjenja.drzava)
                .Include(s => s.igracUtakmica.ugovor)
                .Include(s => s.utakmica)
                .Include(s => s.utakmica.stadion)
                .Include(s => s.utakmica.stadion.lokacijaStadiona)
                .Include(s => s.utakmica.stadion.lokacijaStadiona.drzava)
                .Include(s => s.utakmica.takmicenje)
                .Include(s => s.utakmica.kapiten)
                .Include(s => s.utakmica.kapiten.igracStatistika)
                .Include(s => s.utakmica.kapiten.igracSkills)
                .Include(s => s.utakmica.kapiten.pozicija)
                .Include(s => s.utakmica.kapiten.korisnik)
                .Include(s => s.utakmica.kapiten.korisnik.drzavljanstvo)
                .Include(s => s.utakmica.kapiten.korisnik.gradRodjenja.drzava)
                .Include(s => s.utakmica.kapiten.ugovor)
                .Include(s => s.utakmica.trener)
                .Include(s => s.utakmica.trener.trenerStatistika)
                .Include(s => s.utakmica.trener.trenerskaLicenca)
                .Include(s => s.utakmica.trener.formacija)
                .Include(s => s.utakmica.trener.ugovor)
                .Include(s => s.utakmica.trener.korisnik)
                .Include(s => s.utakmica.trener.korisnik.drzavljanstvo)
                .Include(s => s.utakmica.trener.korisnik.gradRodjenja.drzava)
                .Include(s => s.utakmica.protivnik)
                .Include(s => s.utakmica.protivnik.stadion)
                .Include(s => s.utakmica.protivnik.stadion.lokacijaStadiona)
                .Include(s => s.utakmica.protivnik.stadion.lokacijaStadiona.drzava)
                .Include(s => s.utakmica.protivnik.grad)
                .Include(s => s.utakmica.protivnik.grad.drzava)
                .Include(s => s.trener)
                .Include(s => s.trener.korisnik)
                .AsQueryable();

            var result = entity.SingleOrDefault();

            return _mapper.Map<Model.Models.Izvjestaj>(result);
        }
        public override Model.Models.Izvjestaj Insert(IzvjetajInsertRequest request)
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
            eBordo.Api.Database.Izvjestaj izvjestaj = new Database.Izvjestaj
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

            Database.Izvjestaj izvjestajSearch = _db.izvjestaj.Where(s => s.utakmicaID == request.utakmicaID).SingleOrDefault();

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

            //foreach (var item in izvjestajSearch.nastupi)
            //{
            //    NotifikacijaInsertRequest notifikacijaInsertRequest = new NotifikacijaInsertRequest
            //    {
            //        korisnikId = item.igrac.korisnik.korisnikId,
            //        tekstNotifikacije = "Izvjestaj za utakmicu protiv" + utakmicaSearch.protivnik.nazivKluba + " je kreiran!",
            //        tipNotifikacije = "Info"
            //    };

            //    _notifikacijaService.Insert(notifikacijaInsertRequest);
            //}

            try
            {
                Database.Igrac igracUtakmice = _db.igraci
                .Where(s => s.igracId == request.igracUtakmicaID)
                .Include(s => s.korisnik)
                .FirstOrDefault();

                var credentials = Credentials.FromApiKeyAndSecret(
                "f9a87310",
                "4iJaLbyjSXUcOuIm"
                );

                var VonageClient = new VonageClient(credentials);

                var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
                {
                    To = "38762209709",
                    From = "FK SARAJEVO",
                    Text = igracUtakmice.korisnik.ime + " " + igracUtakmice.korisnik.prezime + ", čestitamo na osvojenoj nagradi za igrača utakmice!"
                });

            }
            catch (Exception e)
            {

            }


            return _mapper.Map<Model.Models.Izvjestaj>(izvjestaj);
        }
        public override Model.Models.Izvjestaj Update(int id, IzvjestajUpdateRequest request)
        {
            Database.Izvjestaj izvjestaj = _db.izvjestaj.Where(s => s.izvjestajId == id).SingleOrDefault();

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
                        _utakmicaIzmjenaService.Update(item.utakmicaIzmjenaId, item);
                    }
                }
            }

            ICollection<Database.UtakmicaIzmjena> izmjenaUtakmicaDatabase = _db.utakmicaIzmjena.Where(s => s.utakmicaId == request.utakmicaId).ToList();

            izvjestaj.nastupi = nastupiUtakmicaDatabase;
            izvjestaj.izmjene = izmjenaUtakmicaDatabase;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Izvjestaj>(izvjestaj);
        }
        public override Model.Models.Izvjestaj Delete(int id)
        {
            var entity = _db.izvjestaj.Where(s => s.izvjestajId == id).FirstOrDefault();

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

            return _mapper.Map<Model.Models.Izvjestaj>(entity);
        }
    }
}
