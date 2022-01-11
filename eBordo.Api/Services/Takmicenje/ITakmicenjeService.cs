using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Takmicenje
{
    public interface ITakmicenjeService : IBaseCRUDService<eBordo.Model.Models.Takmicenje, object,Model.Requests.Takmicenje.TakmicenjeInsertRequest, Model.Requests.Takmicenje.TakmicenjeUpdateRequest>
    {
    }
}
