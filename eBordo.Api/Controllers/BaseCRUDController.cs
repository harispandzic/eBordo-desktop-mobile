using eBordo.Api.Services.BaseCRUDService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseCRUDController<TModel, TDatabase, TSearch, TInsert, TUpdate> : ControllerBase
        where TModel : class
        where TSearch : class
        where TInsert : class
        where TUpdate : class
        where TDatabase : class
    {
        protected readonly IBaseCRUDService<TModel, TDatabase, TSearch, TInsert, TUpdate> _service;
        public BaseCRUDController(IBaseCRUDService<TModel, TDatabase, TSearch, TInsert, TUpdate> service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IEnumerable<TModel> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public virtual TModel GetById(int id)
        {
            return _service.GetById(id);
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
