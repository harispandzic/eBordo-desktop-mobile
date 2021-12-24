using eBordo.Api.Services.UtakmicaIzmjena;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class UtakmicaIzmjenaController: BaseCRUDController<eBordo.Model.Models.UtakmicaIzmjena, object, eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest, eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaUpdateRequest>
    {
        public UtakmicaIzmjenaController(IUtakmicaIzmjenaService service) : base(service) { }
    }
}
