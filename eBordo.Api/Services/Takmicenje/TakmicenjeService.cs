﻿using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Takmicenje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Takmicenje
{
    public class TakmicenjeService : BaseCRUDService<eBordo.Model.Models.Takmicenje, eBordo.Api.Database.Takmicenje, object,Model.Requests.Takmicenje.TakmicenjeInsertRequest, Model.Requests.Takmicenje.TakmicenjeUpdateRequest>, ITakmicenjeService
    {
        public TakmicenjeService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
        public override Model.Models.Takmicenje Insert(TakmicenjeInsertRequest request)
        {
            Database.Takmicenje takmicenje = new Database.Takmicenje
            {
                nazivTakmicenja = request.nazivTakmicenja,
                logo = request.logo
            };

            _db.Add(takmicenje);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Takmicenje>(takmicenje);
        }
        public override Model.Models.Takmicenje Update(int id, TakmicenjeUpdateRequest request)
        {
            var entity = _db.takmicenje.Where(s => s.takmicenjeId == id).SingleOrDefault();

            entity.nazivTakmicenja = request.nazivTakmicenja;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Takmicenje>(entity);
        }
    }
}
