using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Drzava
{
    public class DrzavaService: BaseCRUDService<eBordo.Model.Models.Drzava, eBordo.Api.Database.Drzava, object, eBordo.Model.Requests.Drzava.DrzavaInsertRequest, object>, IDrzavaService
    {
        public DrzavaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
    }
}
