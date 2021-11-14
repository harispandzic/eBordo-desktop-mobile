using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Takmicenje
{
    public class TakmicenjeService : BaseREADService<eBordo.Model.Models.Takmicenje, eBordo.Api.Database.Takmicenje, object>, ITakmicenjeService
    {
        public TakmicenjeService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
    }
}
