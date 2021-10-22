using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.BaseREADService
{
    public interface IBaseREADService<TModel, TSearch>
         where TModel : class
         where TSearch : class
    {
        IEnumerable<TModel> Get(TSearch search = null);
        TModel GetById(int id);
    }
}
