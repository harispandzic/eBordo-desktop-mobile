using eBordo.Api.Services.TrenerskaLicenca;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class TrenerskaLicencaController : BaseREADController<eBordo.Model.Models.TrenerskaLicenca, object>
    {
        public TrenerskaLicencaController(ITrenerskaLicencaService service) : base(service) { }

    }
}
