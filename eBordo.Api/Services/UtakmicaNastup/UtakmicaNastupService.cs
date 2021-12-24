using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Api.Services.UtakmicaNastupService;
using eBordo.Model.Requests.UtakmicaNastup;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaNastup
{
    public class UtakmicaNastupService : BaseCRUDService<eBordo.Model.Models.UtakmicaNastup, eBordo.Api.Database.UtakmicaNastup, UtakmicaNastupSearchObject, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupUpdateRequest>, IUtakmicaNastupService
    {
        public UtakmicaNastupService(eBordoContext db, IMapper mapper)
            : base(db, mapper)
        {
        }
        public override IEnumerable<Model.Models.UtakmicaNastup> Get(UtakmicaNastupSearchObject search = null)
        {
            var entity = _db.utakmicaNastup
                .AsQueryable();

            if (search != null)
            {
                entity = entity.Where(s => s.utakmicaId == search.utakmicaId);
            }
            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.UtakmicaNastup>>(result);
        }
        public override Model.Models.UtakmicaNastup Insert(UtakmicaNastupInsertRequest request)
        {
            eBordo.Api.Database.UtakmicaNastup noviNastup = new Database.UtakmicaNastup
            {
                igracId = request.igracId,
                trenerId = request.trenerId,
                utakmicaId = request.utakmicaId,
                minute = request.minute,
                golovi = request.golovi,
                asistencije = request.asistencije,
                zutiKartoni = request.zutiKartoni,
                crveniKartoni = request.crveniKartoni,
                ocjena = request.ocjena,
                komentar = request.komentar,
                kontrolaLopte = request.kontrolaLopte,
                driblanje = request.driblanje,
                dodavanje = request.dodavanje,
                kretanje = request.kretanje,
                brzina = request.brzina,
                sut = request.sut,
                snaga = request.snaga,
                markiranje = request.markiranje,
                klizeciStart = request.klizeciStart,
                skok = request.skok,
                odbrana = request.odbrana,
            };

            Database.Igrac igrac = _db.igraci
                .Where(s => s.igracId == request.igracId)
                .Include(s => s.igracSkills)
                .Include(s => s.igracStatistika)
                .SingleOrDefault();

            if (request.minute > 0)
            {

                igrac.igracStatistika.brojNastupa++;
                igrac.igracStatistika.golovi += request.golovi;
                igrac.igracStatistika.asistencije += request.asistencije;
                igrac.igracStatistika.crveniKartoni += request.crveniKartoni;
                igrac.igracStatistika.zutiKartoni += request.zutiKartoni;
                igrac.igracStatistika.zbirOcjena += request.ocjena;
                igrac.igracStatistika.prosjecnaOcjena = izracunajProsjek(igrac.igracStatistika.zbirOcjena, igrac.igracStatistika.brojNastupa);

                _db.SaveChanges();

                int brojNastupa = igrac.igracStatistika.brojNastupa;

                igrac.igracSkills.kontrolaLopteZbir += request.kontrolaLopte;
                igrac.igracSkills.kontrolaLopte = izracunajProsjek(igrac.igracSkills.kontrolaLopteZbir, brojNastupa);

                igrac.igracSkills.dribljanjeZbir += request.driblanje;
                igrac.igracSkills.driblanje = izracunajProsjek(igrac.igracSkills.dribljanjeZbir, brojNastupa);
                
                igrac.igracSkills.dodavanjeZbir += request.dodavanje;
                igrac.igracSkills.dodavanje = izracunajProsjek(igrac.igracSkills.dodavanjeZbir, brojNastupa);
                
                igrac.igracSkills.kretanjeZbir += request.kretanje;
                igrac.igracSkills.kretanje = izracunajProsjek(igrac.igracSkills.kretanjeZbir, brojNastupa);
                
                igrac.igracSkills.brzinaZbir += request.brzina;
                igrac.igracSkills.brzina = izracunajProsjek(igrac.igracSkills.brzinaZbir, brojNastupa);
                
                igrac.igracSkills.sutZbir += request.sut;
                igrac.igracSkills.sut = izracunajProsjek(igrac.igracSkills.sutZbir, brojNastupa);
                
                igrac.igracSkills.snagaZbir += request.snaga;
                igrac.igracSkills.snaga = izracunajProsjek(igrac.igracSkills.snagaZbir, brojNastupa);
                
                igrac.igracSkills.markiranjeZbir += request.markiranje;
                igrac.igracSkills.markiranje = izracunajProsjek(igrac.igracSkills.markiranjeZbir, brojNastupa);
                
                igrac.igracSkills.klizeciStartZbir += request.klizeciStart;
                igrac.igracSkills.klizeciStart = izracunajProsjek(igrac.igracSkills.klizeciStartZbir, brojNastupa);
                
                igrac.igracSkills.skokZbir += request.skok;
                igrac.igracSkills.skok = izracunajProsjek(igrac.igracSkills.skokZbir, brojNastupa);
                
                igrac.igracSkills.odbranaZbir += request.odbrana;
                igrac.igracSkills.odbrana = izracunajProsjek(igrac.igracSkills.odbranaZbir, brojNastupa);

                int zbirOcjena = request.kontrolaLopte +
                                 request.driblanje +
                                 request.dodavanje +
                                 request.kretanje +
                                 request.brzina +
                                 request.sut +
                                 request.snaga +
                                 request.markiranje +
                                 request.klizeciStart +
                                 request.skok +
                                 request.odbrana;

                float prosjekOcjenaSaUtakmice = izracunajProsjek(zbirOcjena, 11);

                igrac.igracSkills.zbirOcjena += prosjekOcjenaSaUtakmice;
                igrac.igracSkills.prosjekOcjena = (float)Math.Round(igrac.igracSkills.zbirOcjena / (float)brojNastupa, 2);

                _db.SaveChanges();
            }

            _db.Add(noviNastup);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaNastup>(noviNastup);
        }
        public override Model.Models.UtakmicaNastup Update(int id, UtakmicaNastupUpdateRequest request)
        {
            Database.UtakmicaNastup utakmicaNastup = _db.utakmicaNastup.Where(s => s.utakmicaNastupId == id).SingleOrDefault();

            Database.Igrac igrac = _db.igraci
                .Where(s => s.igracId == utakmicaNastup.igracId)
                .Include(s => s.igracSkills)
                .Include(s => s.igracStatistika)
                .SingleOrDefault();

            int brojNastupa = igrac.igracStatistika.brojNastupa;

            igrac.igracStatistika.golovi -= utakmicaNastup.golovi;
            igrac.igracStatistika.asistencije -= utakmicaNastup.asistencije;
            igrac.igracStatistika.crveniKartoni -= utakmicaNastup.crveniKartoni;
            igrac.igracStatistika.zutiKartoni -= utakmicaNastup.zutiKartoni;
            igrac.igracStatistika.zbirOcjena -= utakmicaNastup.ocjena;

            igrac.igracSkills.kontrolaLopteZbir -= utakmicaNastup.kontrolaLopte;

            igrac.igracSkills.dribljanjeZbir -= utakmicaNastup.driblanje;

            igrac.igracSkills.dodavanjeZbir -= utakmicaNastup.dodavanje;

            igrac.igracSkills.kretanjeZbir -= utakmicaNastup.kretanje;

            igrac.igracSkills.brzinaZbir -= utakmicaNastup.brzina;

            igrac.igracSkills.sutZbir -= utakmicaNastup.sut;

            igrac.igracSkills.snagaZbir -= utakmicaNastup.snaga;

            igrac.igracSkills.markiranjeZbir -= utakmicaNastup.markiranje;

            igrac.igracSkills.klizeciStartZbir -= utakmicaNastup.klizeciStart;

            igrac.igracSkills.skokZbir -= utakmicaNastup.skok;

            igrac.igracSkills.odbranaZbir -= utakmicaNastup.odbrana;

            int zbirOcjena = utakmicaNastup.kontrolaLopte +
                             utakmicaNastup.driblanje +
                             utakmicaNastup.dodavanje +
                             utakmicaNastup.kretanje +
                             utakmicaNastup.brzina +
                             utakmicaNastup.sut +
                             utakmicaNastup.snaga +
                             utakmicaNastup.markiranje +
                             utakmicaNastup.klizeciStart +
                             utakmicaNastup.skok +
                             utakmicaNastup.odbrana;

            float prosjekOcjenaSaUtakmice = izracunajProsjek(zbirOcjena, 11);

            igrac.igracSkills.zbirOcjena -= prosjekOcjenaSaUtakmice;

            if (request.minute > 0)
            {
                igrac.igracStatistika.golovi += request.golovi;
                igrac.igracStatistika.asistencije += request.asistencije;
                igrac.igracStatistika.crveniKartoni += request.crveniKartoni;
                igrac.igracStatistika.zutiKartoni += request.zutiKartoni;
                igrac.igracStatistika.zbirOcjena += request.ocjena;
                igrac.igracStatistika.prosjecnaOcjena = izracunajProsjek(igrac.igracStatistika.zbirOcjena, igrac.igracStatistika.brojNastupa);

                igrac.igracSkills.kontrolaLopteZbir += request.kontrolaLopte;
                igrac.igracSkills.kontrolaLopte = izracunajProsjek(igrac.igracSkills.kontrolaLopteZbir, brojNastupa);

                igrac.igracSkills.dribljanjeZbir += request.driblanje;
                igrac.igracSkills.driblanje = izracunajProsjek(igrac.igracSkills.dribljanjeZbir, brojNastupa);

                igrac.igracSkills.dodavanjeZbir += request.dodavanje;
                igrac.igracSkills.dodavanje = izracunajProsjek(igrac.igracSkills.dodavanjeZbir, brojNastupa);

                igrac.igracSkills.kretanjeZbir += request.kretanje;
                igrac.igracSkills.kretanje = izracunajProsjek(igrac.igracSkills.kretanjeZbir, brojNastupa);

                igrac.igracSkills.brzinaZbir += request.brzina;
                igrac.igracSkills.brzina = izracunajProsjek(igrac.igracSkills.brzinaZbir, brojNastupa);

                igrac.igracSkills.sutZbir += request.sut;
                igrac.igracSkills.sut = izracunajProsjek(igrac.igracSkills.sutZbir, brojNastupa);

                igrac.igracSkills.snagaZbir += request.snaga;
                igrac.igracSkills.snaga = izracunajProsjek(igrac.igracSkills.snagaZbir, brojNastupa);

                igrac.igracSkills.markiranjeZbir += request.markiranje;
                igrac.igracSkills.markiranje = izracunajProsjek(igrac.igracSkills.markiranjeZbir, brojNastupa);

                igrac.igracSkills.klizeciStartZbir += request.klizeciStart;
                igrac.igracSkills.klizeciStart = izracunajProsjek(igrac.igracSkills.klizeciStartZbir, brojNastupa);

                igrac.igracSkills.skokZbir += request.skok;
                igrac.igracSkills.skok = izracunajProsjek(igrac.igracSkills.skokZbir, brojNastupa);

                igrac.igracSkills.odbranaZbir += request.odbrana;
                igrac.igracSkills.odbrana = izracunajProsjek(igrac.igracSkills.odbranaZbir, brojNastupa);

                zbirOcjena = request.kontrolaLopte +
                                 request.driblanje +
                                 request.dodavanje +
                                 request.kretanje +
                                 request.brzina +
                                 request.sut +
                                 request.snaga +
                                 request.markiranje +
                                 request.klizeciStart +
                                 request.skok +
                                 request.odbrana;

                prosjekOcjenaSaUtakmice = izracunajProsjek(zbirOcjena, 11);

                igrac.igracSkills.zbirOcjena += prosjekOcjenaSaUtakmice;
                igrac.igracSkills.prosjekOcjena = (float)Math.Round(igrac.igracSkills.zbirOcjena / (float)brojNastupa, 2);

                _db.SaveChanges();
            }

            utakmicaNastup.minute = request.minute;
            utakmicaNastup.golovi = request.golovi;
            utakmicaNastup.asistencije = request.asistencije;
            utakmicaNastup.zutiKartoni = request.zutiKartoni;
            utakmicaNastup.crveniKartoni = request.crveniKartoni;
            utakmicaNastup.ocjena = request.ocjena;
            utakmicaNastup.komentar = request.komentar;
            utakmicaNastup.kontrolaLopte = request.kontrolaLopte;
            utakmicaNastup.driblanje = request.driblanje;
            utakmicaNastup.dodavanje = request.dodavanje;
            utakmicaNastup.kretanje = request.kretanje;
            utakmicaNastup.brzina = request.brzina;
            utakmicaNastup.sut = request.sut;
            utakmicaNastup.snaga = request.snaga;
            utakmicaNastup.markiranje = request.markiranje;
            utakmicaNastup.klizeciStart = request.klizeciStart;
            utakmicaNastup.skok = request.skok;
            utakmicaNastup.odbrana = request.odbrana;

            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaNastup>(utakmicaNastup);
        }
        public override Model.Models.UtakmicaNastup Delete(int utakmicaNastupId)
        {
            Database.UtakmicaNastup utakmicaNastup = _db.utakmicaNastup.Where(s => s.utakmicaNastupId == utakmicaNastupId).SingleOrDefault();

            Database.Igrac igrac = _db.igraci
                .Where(s => s.igracId == utakmicaNastup.igracId)
                .Include(s => s.igracSkills)
                .Include(s => s.igracStatistika)
                .SingleOrDefault();
         
                igrac.igracStatistika.brojNastupa--;
                igrac.igracStatistika.golovi -= utakmicaNastup.golovi;
                igrac.igracStatistika.asistencije -= utakmicaNastup.asistencije;
                igrac.igracStatistika.crveniKartoni -= utakmicaNastup.crveniKartoni;
                igrac.igracStatistika.zutiKartoni -= utakmicaNastup.zutiKartoni;
                igrac.igracStatistika.zbirOcjena -= utakmicaNastup.ocjena;
                igrac.igracStatistika.prosjecnaOcjena = izracunajProsjek(igrac.igracStatistika.zbirOcjena, igrac.igracStatistika.brojNastupa);

                _db.SaveChanges();

                int brojNastupa = igrac.igracStatistika.brojNastupa;

                igrac.igracSkills.kontrolaLopteZbir -= utakmicaNastup.kontrolaLopte;
                igrac.igracSkills.kontrolaLopte = izracunajProsjek(igrac.igracSkills.kontrolaLopteZbir, brojNastupa);

                igrac.igracSkills.dribljanjeZbir -= utakmicaNastup.driblanje;
                igrac.igracSkills.driblanje = izracunajProsjek(igrac.igracSkills.dribljanjeZbir, brojNastupa);

                igrac.igracSkills.dodavanjeZbir -= utakmicaNastup.dodavanje;
                igrac.igracSkills.dodavanje = izracunajProsjek(igrac.igracSkills.dodavanjeZbir, brojNastupa);

                igrac.igracSkills.kretanjeZbir -= utakmicaNastup.kretanje;
                igrac.igracSkills.kretanje = izracunajProsjek(igrac.igracSkills.kretanjeZbir, brojNastupa);

                igrac.igracSkills.brzinaZbir -= utakmicaNastup.brzina;
                igrac.igracSkills.brzina = izracunajProsjek(igrac.igracSkills.brzinaZbir, brojNastupa);

                igrac.igracSkills.sutZbir -= utakmicaNastup.sut;
                igrac.igracSkills.sut = izracunajProsjek(igrac.igracSkills.sutZbir, brojNastupa);

                igrac.igracSkills.snagaZbir -= utakmicaNastup.snaga;
                igrac.igracSkills.snaga = izracunajProsjek(igrac.igracSkills.snagaZbir, brojNastupa);

                igrac.igracSkills.markiranjeZbir -= utakmicaNastup.markiranje;
                igrac.igracSkills.markiranje = izracunajProsjek(igrac.igracSkills.markiranjeZbir, brojNastupa);

                igrac.igracSkills.klizeciStartZbir -= utakmicaNastup.klizeciStart;
                igrac.igracSkills.klizeciStart = izracunajProsjek(igrac.igracSkills.klizeciStartZbir, brojNastupa);

                igrac.igracSkills.skokZbir -= utakmicaNastup.skok;
                igrac.igracSkills.skok = izracunajProsjek(igrac.igracSkills.skokZbir, brojNastupa);

                igrac.igracSkills.odbranaZbir -= utakmicaNastup.odbrana;
                igrac.igracSkills.odbrana = izracunajProsjek(igrac.igracSkills.odbranaZbir, brojNastupa);

                int zbirOcjena = utakmicaNastup.kontrolaLopte +
                                 utakmicaNastup.driblanje +
                                 utakmicaNastup.dodavanje +
                                 utakmicaNastup.kretanje +
                                 utakmicaNastup.brzina +
                                 utakmicaNastup.sut +
                                 utakmicaNastup.snaga +
                                 utakmicaNastup.markiranje +
                                 utakmicaNastup.klizeciStart +
                                 utakmicaNastup.skok +
                                 utakmicaNastup.odbrana;

                float prosjekOcjenaSaUtakmice = izracunajProsjek(zbirOcjena, 11);

                igrac.igracSkills.zbirOcjena -= prosjekOcjenaSaUtakmice;
                igrac.igracSkills.prosjekOcjena = (float)Math.Round(igrac.igracSkills.zbirOcjena / (float)brojNastupa, 2);

            _db.SaveChanges();

            _db.Remove(utakmicaNastup);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.UtakmicaNastup>(utakmicaNastup);
        }
        private float izracunajProsjek(int zbir, int brojNastupa)
        {
            return (float)Math.Round(zbir / (float)brojNastupa, 2);
        }
    }
}
