using eBordo.Api.Services.Formacija;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class FormacijaController : BaseREADController<eBordo.Model.Models.Formacija, object>
    {
        public FormacijaController(IFormacijaService service) : base(service) { }
    }
}
