using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Klub
{
    public interface IKlubService : IBaseCRUDService<eBordo.Model.Models.Klub, object,eBordo.Model.Requests.Klub.KlubInsertRequest, eBordo.Model.Requests.Klub.KlubUpdateRequest>
    {
    }
}
