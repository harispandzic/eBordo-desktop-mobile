using eBordo.Api.Services.Takmicenje;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class TakmicenjeController : BaseCRUDController<eBordo.Model.Models.Takmicenje, object,Model.Requests.Takmicenje.TakmicenjeInsertRequest,object>
    {
        public TakmicenjeController(ITakmicenjeService service) : base(service) { }

    }
}
