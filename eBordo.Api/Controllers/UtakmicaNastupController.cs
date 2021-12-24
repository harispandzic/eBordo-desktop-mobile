using eBordo.Api.Services.UtakmicaSastav;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class UtakmicaSastavController: BaseCRUDController<eBordo.Model.Models.UtakmicaSastav, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavSearchObject, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavUpdateRequest>
    {
        public UtakmicaSastavController(IUtakmicaSastavService service) : base(service) { }
    }
}
