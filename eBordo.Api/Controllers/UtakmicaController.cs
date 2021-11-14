using eBordo.Api.Services.Utakmica;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class UtakmicaController : BaseCRUDController<eBordo.Model.Models.Utakmica, eBordo.Model.Requests.Utakmica.UtakmicaSearchObject, eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest, eBordo.Model.Requests.Utakmica.UtakmicaUpdateRequest>
    {
        public UtakmicaController(IUtakmicaService service) : base(service) { }

    }
}
