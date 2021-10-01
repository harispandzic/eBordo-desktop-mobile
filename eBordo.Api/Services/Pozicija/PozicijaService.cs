using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Pozicija
{
    public class PozicijaService: BaseREADService<eBordo.Model.Models.Pozicija, eBordo.Api.Database.Pozicija, object>, IPozicijaService
    {
        public PozicijaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
    }
}
