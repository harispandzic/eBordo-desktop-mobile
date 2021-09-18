using eBordo.Api.Services.BaseREADService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.BaseCRUDService
{
    public interface IBaseCRUDService<TModel, TSearch, TInsert, TUpdate> : IBaseREADService<TModel, TSearch>
         where TModel : class
         where TSearch : class
         where TInsert : class
         where TUpdate : class
    {
        TModel Insert(TInsert request);
        TModel Update(int id, TUpdate request);
        TModel Delete(int id);
    }
}
