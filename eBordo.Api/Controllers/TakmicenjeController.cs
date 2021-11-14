using eBordo.Api.Services.Takmicenje;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class TakmicenjeController : BaseREADController<eBordo.Model.Models.Takmicenje, object>
    {
        public TakmicenjeController(ITakmicenjeService service) : base(service) { }

    }
}
