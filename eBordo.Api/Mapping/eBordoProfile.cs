using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace eBordo.Api.Mapping
{
    public class eBordoProfile: Profile
    {
        public eBordoProfile()
        {
            //Država
            CreateMap<eBordo.Api.Database.Drzava, eBordo.Model.Models.Drzava>();

            //Grad
            CreateMap<eBordo.Api.Database.Grad, eBordo.Model.Models.Grad>();

            //Korisnik
            CreateMap<eBordo.Api.Database.Korisnik, eBordo.Model.Models.Korisnik>();
            CreateMap<eBordo.Model.Requests.Korisnik.KorisnikInsertRequest, eBordo.Api.Database.Korisnik>();
            CreateMap<eBordo.Model.Requests.Korisnik.KorisnikUpdateRequest, eBordo.Api.Database.Korisnik>();

            //Igrač
            CreateMap<eBordo.Api.Database.Igrac, eBordo.Model.Models.Igrac>();
            CreateMap<eBordo.Api.Database.IgracStatistika, eBordo.Model.Models.IgracStatistika>();
            CreateMap<eBordo.Api.Database.IgracSkills, eBordo.Model.Models.IgracSkills>();
            CreateMap<eBordo.Api.Database.Ugovor, eBordo.Model.Models.Ugovor>();
            //INSERT & UPDATE
            CreateMap<eBordo.Model.Requests.Igrac.IgracInsertRequest, eBordo.Api.Database.Igrac>();
            CreateMap<eBordo.Model.Requests.Igrac.IgracUpdateRequest, eBordo.Api.Database.Igrac>();


        }
    }
}
