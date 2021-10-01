using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Services.BaseCRUDService;

namespace eBordo.Api.Services.IgracSkills
{
    public class IgracSkillsService: BaseCRUDService<Model.Models.IgracSkills, Database.IgracSkills,object,object,object>, IIgracSkillsService
    {
        public IgracSkillsService(eBordoContext db, IMapper mapper):base(db, mapper) { }

        public override Model.Models.IgracSkills Insert(object request = null)
        {
            Database.IgracSkills skills = new Database.IgracSkills();
            _db.igracSkills.Add(skills);
            _db.SaveChanges();
            return _mapper.Map<Model.Models.IgracSkills>(skills);
        }
        public override Model.Models.IgracSkills Delete(int id)
        {
            var entity = _db.igracSkills.Where(s => s.igracId == id).FirstOrDefault();

            _db.Remove(entity);
            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.IgracSkills>(entity);
        }
    }
}
