using eBordo.Api.Services.Korisnik;
using eBordo.Model.Requests.Korisnik;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    //[Authorize]
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
        [HttpPost("ChangePassword")]
        public Task<Model.Models.Korisnik> ChangePassword([FromBody] KorisnikChangePasswordRequest request)
        {
            return _korisnikService.ChangePassword(request);
        }
        [HttpPut("/api/Korisnik/UrediKorisnika/{id}")]
        public Model.Models.Korisnik UrediKorisnika(int id,[FromBody] KorisnikUpdateRequest request)
        {
            return _korisnikService.Update(id, request);
        }
    }
}
