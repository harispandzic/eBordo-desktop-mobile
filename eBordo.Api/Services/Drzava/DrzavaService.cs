using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Drzava
{
    public class DrzavaService: BaseCRUDService<eBordo.Model.Models.Drzava, eBordo.Api.Database.Drzava, object, eBordo.Model.Requests.Drzava.DrzavaInsertRequest, object>, IDrzavaService
    {
        public DrzavaService(eBordoContext db, IMapper mapper) : base(db, mapper) { }

        public override Model.Models.Drzava Insert(DrzavaInsertRequest request)
        {
            Database.Drzava drzava = new Database.Drzava
            {
                nazivDrzave = request.nazivDrzave,
                zastava = request.zastava
            };

            _db.Add(drzava);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Drzava>(drzava);
        }
    }
}
