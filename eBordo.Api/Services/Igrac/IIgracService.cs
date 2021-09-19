using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBordo.Api.Services.BaseCRUDService;

namespace eBordo.Api.Services.Igrac
{
    public interface IIgracService: IBaseCRUDService<eBordo.Model.Models.Igrac, eBordo.Model.Requests.Igrac.IgracSearchObject, eBordo.Model.Requests.Igrac.IgracInsertRequest, eBordo.Model.Requests.Igrac.IgracUpdateRequest>
    {
    }
}
