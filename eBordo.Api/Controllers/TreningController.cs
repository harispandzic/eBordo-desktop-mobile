using eBordo.Api.Services.Trening;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class TreningController : BaseCRUDController<eBordo.Model.Models.Trening, eBordo.Model.Requests.Trening.TreningSearchObject, eBordo.Model.Requests.Trening.TreningInsertRequest, eBordo.Model.Requests.Trening.TreningUpdateRequest>
    {
        public TreningController(ITreningService service) : base(service) { }
    }
}
