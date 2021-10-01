using eBordo.Api.Services.Igrac;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class IgracController : BaseCRUDController<eBordo.Model.Models.Igrac, eBordo.Model.Requests.Igrac.IgracSearchObject, eBordo.Model.Requests.Igrac.IgracInsertRequest, eBordo.Model.Requests.Igrac.IgracUpdateRequest>
    {
       
        public IgracController(IIgracService service): base(service) { }
    }
}
