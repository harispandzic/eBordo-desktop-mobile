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
            CreateMap<eBordo.Api.Database.Drzava, eBordo.Model.Models.Drzava>();
            CreateMap<eBordo.Api.Database.Grad, eBordo.Model.Models.Grad>();

            //INSERT requests
            CreateMap<eBordo.Model.Requests.Drzava.DrzavaInsertRequest, eBordo.Api.Database.Drzava>();
            CreateMap<eBordo.Model.Requests.Grad.GradInsertRequest, eBordo.Api.Database.Grad>();
        }
    }
}
