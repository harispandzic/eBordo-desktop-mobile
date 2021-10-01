using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Korisnik
{
    public interface IKorisnikService: IBaseCRUDService<eBordo.Model.Models.Korisnik,object, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
    }
}
