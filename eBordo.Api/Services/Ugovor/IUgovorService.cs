using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Ugovor;

namespace eBordo.Api.Services.Ugovor
{
    public interface IUgovorService : IBaseCRUDService<eBordo.Model.Models.Ugovor, object, UgovorInsertRequest, UgovorUpdateRequest>
    {
    }
}
