using eBordo.Api.Services.Trener;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class TrenerController : BaseCRUDController<eBordo.Model.Models.Trener, eBordo.Model.Requests.Trener.TrenerSearchObject, eBordo.Model.Requests.Trener.TrenerInsertRequest, eBordo.Model.Requests.Trener.TrenerUpdateRequest>
    {
        public TrenerController(ITrenerService service) : base(service) { }
    }
}
