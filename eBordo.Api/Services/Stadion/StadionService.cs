﻿using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Stadion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Stadion
{
    public class StadionService : BaseCRUDService<eBordo.Model.Models.Stadion, eBordo.Api.Database.Stadion, object, Model.Requests.Stadion.StadionInsertRequest, object>, IStadionService
    {
        public StadionService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override Model.Models.Stadion Insert(StadionInsertRequest request)
        {
            Database.Stadion stadion = new Database.Stadion
            {
                nazivStadiona = request.nazivStadiona,
                lokacijaStadionaId = request.lokacijaStadionaId,
                slikaStadiona = request.slikaStadiona,
            };
            _db.Add(stadion);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Stadion>(stadion);
        }
        public override IEnumerable<eBordo.Model.Models.Stadion> Get(object search = null)
        {
            var entity = _db.Set<Database.Stadion>()
                .Include(s => s.lokacijaStadiona)
                .Include(s => s.lokacijaStadiona.drzava)
                .AsQueryable();

            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Stadion>>(result);
        }
        public override eBordo.Model.Models.Stadion GetById(int id)
        {
            var entity = _db.Set<Database.Stadion>()
                .Where(s => s.stadionId == id)
                .Include(s => s.lokacijaStadiona)
                .Include(s => s.lokacijaStadiona.drzava)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Stadion>(result);
        }
    }
}
