using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.TrenerskaLicenca
{
    public class TrenerskaLicencaService : BaseREADService<eBordo.Model.Models.TrenerskaLicenca, eBordo.Api.Database.TrenerskaLicenca, object>, ITrenerskaLicencaService
    {
        public TrenerskaLicencaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }
    }
}
