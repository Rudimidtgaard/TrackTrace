using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackTrace.Models;

namespace TrackTrace.Controllers
{
    [Route("api/transports/{transportId}/Events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<EventDto>> GetEvents(int transportId) // change to other search parameter
        {
            var transport = DataStore.Current.Transports.FirstOrDefault(t => t.Id == transportId);

            if (transport == null)
            {
                return NotFound();
            }

            return Ok(transport.Events);
        }

        [HttpGet("{eventid}")]
        public ActionResult<EventDto> GetEvent(int transportId, int eventId)
        {
            var transport = DataStore.Current.Transports.FirstOrDefault(t => t.Id == transportId);

            if (transport == null)
            {
                return NotFound();
            }

            var tEvent = transport.Events.FirstOrDefault(t => t.Id == eventId);

            if (tEvent == null)
            {
                return NotFound();
            }

            return Ok(tEvent);
        }
    }
}
