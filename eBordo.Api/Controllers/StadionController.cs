using eBordo.Api.Services.Stadion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class StadionController : BaseCRUDController<eBordo.Model.Models.Stadion, object, Model.Requests.Stadion.StadionInsertRequest,object>
    {
        public StadionController(IStadionService service) : base(service) { }
    }
}
