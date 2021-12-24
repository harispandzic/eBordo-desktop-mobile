using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaNastupService
{
    public interface IUtakmicaNastupService: IBaseCRUDService<eBordo.Model.Models.UtakmicaNastup, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupSearchObject, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest, eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupUpdateRequest>
    {
    }
}
