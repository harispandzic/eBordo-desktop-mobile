using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Notifikacija
{
    public interface INotifikacijaService : IBaseCRUDService<eBordo.Model.Models.Notifikacija, eBordo.Model.Requests.Notifikacija.NotifikacijaSearchObject, eBordo.Model.Requests.Notifikacija.NotifikacijaInsertRequest, object>
    {
    }
}
