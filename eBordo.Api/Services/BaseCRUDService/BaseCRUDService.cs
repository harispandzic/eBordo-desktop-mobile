using AutoMapper;
using eBordo.Api.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.BaseCRUDService
{
    public class BaseCRUDService<TModel, TDatabase, TSearch, TInsert, TUpdate> : IBaseCRUDService<TModel, TDatabase, TSearch, TInsert, TUpdate>
        where TModel : class
        where TSearch : class
        where TInsert : class
        where TUpdate : class
        where TDatabase : class
    {
        public eBordoContext _db { get; set; }
        protected readonly IMapper _mapper;

        public BaseCRUDService(eBordoContext db, IMapper mapper)
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
        public virtual TModel GetById(int id)
        {
            var set = _db.Set<TDatabase>();

            var entity = set.Find(id);

            return _mapper.Map<TModel>(entity);
        }
        public virtual TModel Insert(TInsert request)
        {
            var set = _db.Set<TDatabase>();

            TDatabase entity = _mapper.Map<TDatabase>(request);

            set.Add(entity);

            _db.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
        public virtual TModel Update(int id, TUpdate request)
        {
            var set = _db.Set<TDatabase>();

            var entity = set.Find(id);

            _mapper.Map(request, entity);

            _db.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
        public virtual TModel Delete(int id)
        {
            var set = _db.Set<TDatabase>();

            var entity = set.Find(id);

            _db.Remove(entity);

            _db.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
    }
}
