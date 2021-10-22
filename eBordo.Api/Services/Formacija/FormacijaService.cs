using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Formacija
{
    public class FormacijaService: BaseREADService<eBordo.Model.Models.Formacija, eBordo.Api.Database.Formacija, object>, IFormacijaService
    {
        public FormacijaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
    }
}
