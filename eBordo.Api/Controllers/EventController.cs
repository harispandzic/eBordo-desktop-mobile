using eBordo.Api.Services.Event;
using Microsoft.AspNetCore.Mvc;

namespace eBordo.Api.Controllers
{
    public class EventController : BaseREADController<eBordo.Model.Models.KalendarStavka, object>
    {
        public EventController(IEventService service) : base(service) { }
    }
}
