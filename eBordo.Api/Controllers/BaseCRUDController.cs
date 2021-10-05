using eBordo.Api.Services.BaseCRUDService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class BaseCRUDController<TModel, TSearch, TInsert, TUpdate> : BaseREADController<TModel, TSearch>
        where TModel : class
        where TSearch : class
        where TInsert : class
        where TUpdate : class
    {
        protected readonly IBaseCRUDService<TModel, TSearch, TInsert, TUpdate> _service;
        public BaseCRUDController(IBaseCRUDService<TModel, TSearch, TInsert, TUpdate> service):base(service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual TModel Insert([FromBody] TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public virtual TModel Update(int id, [FromBody] TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public virtual TModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
