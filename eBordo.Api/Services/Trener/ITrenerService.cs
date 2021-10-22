using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Trener
{
    public interface ITrenerService : IBaseCRUDService<eBordo.Model.Models.Trener, eBordo.Model.Requests.Trener.TrenerSearchObject, eBordo.Model.Requests.Trener.TrenerInsertRequest, eBordo.Model.Requests.Trener.TrenerUpdateRequest>    
    {
    }
}
