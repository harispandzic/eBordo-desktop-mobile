using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Izvjestaj
{
    public interface IIzvjestajService : IBaseCRUDService<eBordo.Model.Models.Izvjestaj, eBordo.Model.Requests.Izvjestaj.IzvjestajSearchObject, eBordo.Model.Requests.Izvjestaj.IzvjetajInsertRequest, eBordo.Model.Requests.Izvjestaj.IzvjestajUpdateRequest>
    {
    }
}
