using eBordo.Api.Services.Izvještaj;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class IzvještajController : BaseCRUDController<eBordo.Model.Models.Izvještaj, eBordo.Model.Requests.Izvještaj.IzvjestajSearchObject, eBordo.Model.Requests.Izvještaj.IzvjetajInsertRequest, eBordo.Model.Requests.Izvještaj.IzvjestajUpdateRequest>
    {
        public IzvještajController(IIzvještajService service) : base(service) { }
    }
}
