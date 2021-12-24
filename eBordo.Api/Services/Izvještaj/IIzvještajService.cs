using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Izvještaj
{
    public interface IIzvještajService : IBaseCRUDService<eBordo.Model.Models.Izvještaj, eBordo.Model.Requests.Izvještaj.IzvjestajSearchObject, eBordo.Model.Requests.Izvještaj.IzvjetajInsertRequest, eBordo.Model.Requests.Izvještaj.IzvjestajUpdateRequest>
    {
    }
}
