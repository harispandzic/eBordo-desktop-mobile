using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.BaseCRUDService
{
    public interface IBaseCRUDService<TModel, TDatabase, TSearch, TInsert, TUpdate>
         where TModel : class
         where TSearch : class
         where TInsert : class
         where TUpdate : class
         where TDatabase : class
    {
        IEnumerable<TModel> Get(TSearch search = null);
        TModel GetById(int id);
        TModel Insert(TInsert request);
        TModel Update(int id, TUpdate request);
        TModel Delete(int id);
    }
}
