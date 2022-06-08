using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace eBordo.Api.Mapping
{
    public class eBordoProfile : Profile
    {
        public eBordoProfile()
        {
            //Pozicija
            CreateMap<eBordo.Api.Database.Pozicija, eBordo.Model.Models.Pozicija>();

            //Država
            CreateMap<eBordo.Api.Database.Drzava, eBordo.Model.Models.Drzava>();

            //Grad
            CreateMap<eBordo.Api.Database.Grad, eBordo.Model.Models.Grad>();

            //Korisnik
            CreateMap<eBordo.Api.Database.Korisnik, eBordo.Model.Models.Korisnik>().ReverseMap();
            CreateMap<eBordo.Model.Requests.Korisnik.KorisnikInsertRequest, eBordo.Api.Database.Korisnik>();
            CreateMap<eBordo.Model.Requests.Korisnik.KorisnikUpdateRequest, eBordo.Api.Database.Korisnik>();

            //Igrač
            CreateMap<eBordo.Api.Database.Igrac, eBordo.Model.Models.Igrac>();
            CreateMap<eBordo.Api.Database.IgracStatistika, eBordo.Model.Models.IgracStatistika>().ReverseMap();
            CreateMap<eBordo.Api.Database.IgracSkills, eBordo.Model.Models.IgracSkills>();
            CreateMap<eBordo.Api.Database.Ugovor, eBordo.Model.Models.Ugovor>();
            //INSERT & UPDATE
            CreateMap<eBordo.Model.Requests.Igrac.IgracInsertRequest, eBordo.Api.Database.Igrac>();
            CreateMap<eBordo.Model.Requests.Igrac.IgracUpdateRequest, eBordo.Api.Database.Igrac>();

            //Trener
            CreateMap<eBordo.Api.Database.Trener, eBordo.Model.Models.Trener>();
            CreateMap<eBordo.Api.Database.TrenerStatistika, eBordo.Model.Models.TrenerStatistika>().ReverseMap();
            CreateMap<eBordo.Api.Database.TrenerskaLicenca, eBordo.Model.Models.TrenerskaLicenca>();
            CreateMap<eBordo.Api.Database.Formacija, eBordo.Model.Models.Formacija>();
            CreateMap<eBordo.Api.Database.Ugovor, eBordo.Model.Models.Ugovor>();
            CreateMap<eBordo.Api.Database.Stadion, eBordo.Model.Models.Stadion>();
            CreateMap<eBordo.Api.Database.Takmicenje, eBordo.Model.Models.Takmicenje>();
            CreateMap<eBordo.Api.Database.Klub, eBordo.Model.Models.Klub>();
            CreateMap<eBordo.Api.Database.Utakmica, eBordo.Model.Models.Utakmica>();
            CreateMap<eBordo.Api.Database.UtakmicaSastav, eBordo.Model.Models.UtakmicaSastav>();
            //INSERT & UPDATE
            CreateMap<eBordo.Model.Requests.Trener.TrenerInsertRequest, eBordo.Api.Database.Trener>();
            CreateMap<eBordo.Model.Requests.Trener.TrenerUpdateRequest, eBordo.Api.Database.Trener>();

            CreateMap<eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest, eBordo.Api.Database.Utakmica>();
            CreateMap<eBordo.Model.Requests.Utakmica.UtakmicaUpdateRequest, eBordo.Api.Database.Utakmica>().ReverseMap(); ;

            CreateMap<eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest, eBordo.Api.Database.UtakmicaSastav>();
            CreateMap<eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavUpdateRequest, eBordo.Api.Database.UtakmicaSastav>().ReverseMap(); ;

            CreateMap<eBordo.Api.Database.Izvjestaj, eBordo.Model.Models.Izvjestaj>();
            CreateMap<eBordo.Api.Database.UtakmicaNastup, eBordo.Model.Models.UtakmicaNastup>();
            CreateMap<eBordo.Api.Database.UtakmicaIzmjena, eBordo.Model.Models.UtakmicaIzmjena>();

            CreateMap<eBordo.Model.Requests.Izvjestaj.IzvjetajInsertRequest, eBordo.Api.Database.Izvjestaj>();
            CreateMap<eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest, eBordo.Api.Database.UtakmicaNastup>();
            CreateMap<eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest, eBordo.Api.Database.UtakmicaIzmjena>();

            CreateMap<eBordo.Api.Database.Notifikacija, eBordo.Model.Models.Notifikacija>();
            CreateMap<eBordo.Model.Requests.Notifikacija.NotifikacijaInsertRequest, eBordo.Api.Database.Notifikacija>();

            CreateMap<eBordo.Api.Database.Trening, eBordo.Model.Models.Trening>();
            CreateMap<eBordo.Model.Requests.Trening.TreningInsertRequest, eBordo.Api.Database.Trening>();
            CreateMap<eBordo.Model.Requests.Trening.TreningUpdateRequest, eBordo.Api.Database.Trening>();
        }
    }
}
