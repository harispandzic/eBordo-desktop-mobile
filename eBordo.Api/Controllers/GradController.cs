using eBordo.Api.Services.Grad;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class GradController : BaseREADController<eBordo.Model.Models.Grad, object>
    {
        public GradController(IGradService service) : base(service) { }
    }
}
