﻿using System;
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
            //INSERT & UPDATE
            CreateMap<eBordo.Model.Requests.Trener.TrenerInsertRequest, eBordo.Api.Database.Trener>();
            CreateMap<eBordo.Model.Requests.Trener.TrenerUpdateRequest, eBordo.Api.Database.Trener>();

        }
    }
}
