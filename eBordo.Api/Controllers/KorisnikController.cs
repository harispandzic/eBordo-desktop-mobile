using eBordo.Api.Services.Korisnik;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _korisnikService;
        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }
        [HttpGet("Auth")]
        public ActionResult<Model.Models.Korisnik> Auth()
        {
            return _korisnikService.Auth();
        }
    }
}
