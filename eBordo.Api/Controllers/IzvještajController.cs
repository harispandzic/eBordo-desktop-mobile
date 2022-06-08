using eBordo.Api.Services.Izvjestaj;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class IzvjestajController : BaseCRUDController<eBordo.Model.Models.Izvjestaj, eBordo.Model.Requests.Izvjestaj.IzvjestajSearchObject, eBordo.Model.Requests.Izvjestaj.IzvjetajInsertRequest, eBordo.Model.Requests.Izvjestaj.IzvjestajUpdateRequest>
    {
        public IzvjestajController(IIzvjestajService service) : base(service) { }
    }
}
