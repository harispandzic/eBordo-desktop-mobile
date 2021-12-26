using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Trening
{
    public interface ITreningService : IBaseCRUDService<eBordo.Model.Models.Trening, eBordo.Model.Requests.Trening.TreningSearchObject, eBordo.Model.Requests.Trening.TreningInsertRequest, eBordo.Model.Requests.Trening.TreningUpdateRequest>
    {
    }
}
