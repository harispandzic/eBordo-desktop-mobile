using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Utakmica
{
    public interface IUtakmicaService: IBaseCRUDService<eBordo.Model.Models.Utakmica, eBordo.Model.Requests.Utakmica.UtakmicaSearchObject, eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest, eBordo.Model.Requests.Utakmica.UtakmicaUpdateRequest>
    {
    }
}
