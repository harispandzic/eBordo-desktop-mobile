using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.GradService
{
    public interface IGradService: IBaseCRUDService<eBordo.Model.Models.Grad, eBordo.Api.Database.Grad, eBordo.Model.Requests.Grad.GradSearchRequest, eBordo.Model.Requests.Grad.GradInsertRequest, object>
    {
    }
}
