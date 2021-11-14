using eBordo.Api.Services.Stadion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class StadionController : BaseREADController<eBordo.Model.Models.Stadion, object>
    {
        public StadionController(IStadionService service) : base(service) { }
    }
}
