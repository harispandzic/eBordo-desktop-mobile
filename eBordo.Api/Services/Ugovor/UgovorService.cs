using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.Ugovor;

namespace eBordo.Api.Services.Ugovor
{
    public class UgovorService : BaseCRUDService<eBordo.Model.Models.Ugovor, eBordo.Api.Database.Ugovor, object, UgovorInsertRequest, UgovorUpdateRequest>, IUgovorService
    {
        public UgovorService(eBordoContext db, IMapper mapper): base(db, mapper) { }

        public override Model.Models.Ugovor Insert(UgovorInsertRequest request)
        {
            Database.Ugovor ugovor = new Database.Ugovor();
            ugovor.datumPocetka = request.datumPocetka;
            ugovor.datumZavrsetka = request.datumZavrsetka;
            _db.ugovori.Add(ugovor);
            _db.SaveChanges();

            return _mapper.Map<Model.Models.Ugovor>(ugovor);
        }
        public override Model.Models.Ugovor Update(int id, UgovorUpdateRequest request)
        {
            var ugovor = _db.ugovori.Find(id);

            ugovor.datumPocetka = request.datumPocetka;
            ugovor.datumZavrsetka = request.datumZavrsetka;

            return _mapper.Map<Model.Models.Ugovor>(ugovor);
        }
        public override Model.Models.Ugovor Delete(int id)
        {
            var entity = _db.ugovori.Where(s => s.ugovorId == id).FirstOrDefault();

            _db.Remove(entity);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Ugovor>(entity);
        }
    }
}
