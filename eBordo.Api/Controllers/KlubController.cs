using eBordo.Api.Services.Klub;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class KlubController : BaseREADController<eBordo.Model.Models.Klub, object>
    {
        public KlubController(IKlubService service) : base(service) { }
    }
}
