using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.ML;
using eBordo.Api.Services.Igrac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Controllers
{
    public class IgracController : BaseCRUDController<eBordo.Model.Models.Igrac, eBordo.Model.Requests.Igrac.IgracSearchObject, eBordo.Model.Requests.Igrac.IgracInsertRequest, eBordo.Model.Requests.Igrac.IgracUpdateRequest>
    {
        private readonly eBordoContext _db;
        private readonly IMapper _mapper;

        public IgracController(IIgracService service, eBordoContext db, IMapper mapper) : base(service) {
            _db = db;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("/api/Igrac/GetPreporuceneIgrace")]
        public List<Model.Models.Igrac> GetPreporuceneIgrace([FromBody] Model.Requests.Igrac.RecommendedIgraci request)
        {
            Recommender recommender = new Recommender(_db, _mapper);
            return recommender.GetRecommendedIgrace(request);
        }
    }
}
