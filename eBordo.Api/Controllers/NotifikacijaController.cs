using eBordo.Api.Services.Notifikacija;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class NotifikacijaController : BaseCRUDController<Model.Models.Notifikacija, Model.Requests.Notifikacija.NotifikacijaSearchObject, Model.Requests.Notifikacija.NotifikacijaInsertRequest, object>
    {
        public NotifikacijaController(INotifikacijaService service) : base(service) { }
    }
}
