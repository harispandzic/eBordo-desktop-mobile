using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBordo.Api.Services.BaseREADService;

namespace eBordo.Api.Services.Drzava
{
    public interface IDrzavaService: IBaseCRUDService<eBordo.Model.Models.Drzava, object, Model.Requests.Drzava.DrzavaInsertRequest, Model.Requests.Drzava.DrzavaUpdateRequest>
    {
    }
}
