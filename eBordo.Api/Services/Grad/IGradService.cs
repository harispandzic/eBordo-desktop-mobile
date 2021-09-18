using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Grad
{
    public interface IGradService:IBaseCRUDService<eBordo.Model.Models.Grad, eBordo.Model.Requests.Grad.GradSearchObject, eBordo.Model.Requests.Grad.GradInsertRequest, eBordo.Model.Requests.Grad.GradUpdateRequest>
    {
    }
}
