using eBordo.Api.Services.BaseCRUDService;
using eBordo.Model.Requests.UtakmicaSastav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaSastav
{
    public interface IUtakmicaSastavService : IBaseCRUDService<eBordo.Model.Models.UtakmicaSastav, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavSearchObject, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest, eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavUpdateRequest>
    {
        public Model.Models.UtakmicaSastav InsertByUtakmicaId(UtakmicaSastavInsertRequest request, int utakmicaId);
        public Model.Models.UtakmicaSastav UpdateByUtakmicaId(UtakmicaSastavUpdateRequest request, int utakmicaId, int igracId);
        public Model.Models.UtakmicaSastav DeleteByUtakmicaId(int utakmicaSastavId);
    }
}
