using eBordo.Api.Services.BaseCRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Services.UtakmicaIzmjena
{
    public interface IUtakmicaIzmjenaService : IBaseCRUDService<eBordo.Model.Models.UtakmicaIzmjena, object, eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest, eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaUpdateRequest>
    {
       
    }
}
