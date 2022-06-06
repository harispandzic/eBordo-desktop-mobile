using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Korisnik
{
    public interface IKorisnikService
    {
        Task<Model.Models.Korisnik> Login(string username, string password);
        Task<Model.Models.Korisnik> ChangePassword(KorisnikChangePasswordRequest request);
        Model.Models.Korisnik Auth();
        Model.Models.Korisnik Insert(KorisnikInsertRequest request);
        Model.Models.Korisnik Update(int id, KorisnikUpdateRequest request);
        Model.Models.Korisnik Delete(int id);
    }
}
