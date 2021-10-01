﻿using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using eBordo.Model.Requests.Grad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Grad
{
    public class GradService: BaseREADService<eBordo.Model.Models.Grad,eBordo.Api.Database.Grad, object>, IGradService
    {
        public GradService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override IEnumerable<eBordo.Model.Models.Grad> Get(object search = null)
        {
            var entity = _db.Set<Database.Grad>()
                .Include(s => s.drzava)
                .AsQueryable();

            var result = entity.ToList();

            return _mapper.Map<List<Model.Models.Grad>>(result);
        }
        public override eBordo.Model.Models.Grad GetById(int id)
        {
            var entity = _db.Set<Database.Grad>()
                .Where(s => s.gradId == id)
                .Include(s => s.drzava)
                .AsQueryable();

            var result = entity.FirstOrDefault();

            return _mapper.Map<Model.Models.Grad>(result);
        }
    }
}
