using AutoMapper;
using eBordo.Api.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.BaseREADService
{
    public class BaseREADService<TModel, TDatabase, TSearch> : IBaseREADService<TModel, TSearch>
        where TModel : class
        where TSearch : class
        where TDatabase : class
    {
        public eBordoContext _db { get; set; }
        protected readonly IMapper _mapper;

        public BaseREADService(eBordoContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public virtual IEnumerable<TModel> Get(TSearch search = null)
        {
            var entity = _db.Set<TDatabase>();

            var list = entity.ToList();

            return _mapper.Map<List<TModel>>(list);
        }
        public virtual TModel GetById(int id, TSearch search = null)
        {
            var set = _db.Set<TDatabase>();

            var entity = set.Find(id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
