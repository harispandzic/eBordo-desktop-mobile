using eBordo.Api.Services.Drzava;
using eBordo.Api.Services.GradService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class GradController : BaseCRUDController<eBordo.Model.Models.Grad, eBordo.Api.Database.Grad, eBordo.Model.Requests.Grad.GradSearchRequest, eBordo.Model.Requests.Grad.GradInsertRequest, object>
    {
        public GradController(IGradService service) : base(service) { }
    }
}
