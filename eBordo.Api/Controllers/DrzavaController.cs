using eBordo.Api.Services.Drzava;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class DrzavaController : BaseCRUDController<eBordo.Model.Models.Drzava, eBordo.Api.Database.Drzava, object, eBordo.Model.Requests.Drzava.DrzavaInsertRequest, object>
    {
        public DrzavaController(IDrzavaService service) : base(service) { }
    }
}
