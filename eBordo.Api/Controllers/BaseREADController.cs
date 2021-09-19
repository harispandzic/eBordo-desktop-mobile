using eBordo.Api.Services.BaseREADService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseREADController<TModel, TSearch> : ControllerBase where TModel : class where TSearch : class
    {
        protected readonly IBaseREADService<TModel, TSearch> _service;
        public BaseREADController(IBaseREADService<TModel, TSearch> service)
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
    }
}
