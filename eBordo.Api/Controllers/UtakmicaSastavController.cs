using eBordo.Api.Services.UtakmicaNastup;
using eBordo.Api.Services.UtakmicaNastupService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class UtakmicaNastupController: BaseCRUDController<eBordo.Model.Models.UtakmicaNastup, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupSearchObject, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupUpdateRequest>
    {
        public UtakmicaNastupController(IUtakmicaNastupService service) : base(service) { }
    }
}
