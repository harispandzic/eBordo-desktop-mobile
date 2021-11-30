using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Stadion
{
    public interface IStadionService : IBaseCRUDService<eBordo.Model.Models.Stadion, object,Model.Requests.Stadion.StadionInsertRequest,object>
    {
    }
}
