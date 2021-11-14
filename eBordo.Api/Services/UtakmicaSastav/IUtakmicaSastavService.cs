using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.UtakmicaSastav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaSastav
{
    public interface IUtakmicaSastavService
    {
        public Model.Models.UtakmicaSastav Insert(UtakmicaSastavInsertRequest request, int utakmicaId);
        public Model.Models.UtakmicaSastav Update(UtakmicaSastavUpdateRequest request, int utakmicaId, int igracId);
        public Model.Models.UtakmicaSastav Delete(int utakmicaSastavId);
    }
}
