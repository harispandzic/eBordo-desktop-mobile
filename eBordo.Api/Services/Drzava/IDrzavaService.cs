using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Drzava
{
    public interface IDrzavaService: IBaseCRUDService<eBordo.Model.Models.Drzava, eBordo.Api.Database.Drzava, object, eBordo.Model.Requests.Drzava.DrzavaInsertRequest, object>
    {
    }
}
