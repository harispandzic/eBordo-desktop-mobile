using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Grad
{
    public interface IGradService: IBaseCRUDService<eBordo.Model.Models.Grad,object, Model.Requests.Grad.GradInsertRequest, Model.Requests.Grad.GradUpdateRequest>
    {
    }
}
