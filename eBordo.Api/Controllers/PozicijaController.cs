using eBordo.Api.Services.Pozicija;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class PozicijaController : BaseREADController<eBordo.Model.Models.Pozicija, object>
    {
        public PozicijaController(IPozicijaService service) : base(service) { }

    }
}
