using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.BaseCRUDService
{
    public class BaseCRUDService<TModel, TDatabase, TSearch, TInsert, TUpdate> : BaseREADService<TModel, TDatabase, TSearch>,IBaseCRUDService<TModel, TSearch, TInsert, TUpdate>
        where TModel : class
        where TDatabase : class
        where TSearch : class
        where TInsert : class
        where TUpdate : class
    {
        public BaseCRUDService(eBordoContext db, IMapper mapper):base(db, mapper)
        {
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
