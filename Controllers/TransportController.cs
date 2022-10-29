using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TrackTrace.Models;

namespace TrackTrace.Controllers
{
    [ApiController]
    [Route("api/transports")]
    public class TransportController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<TransportDto>> GetEvents()
        {
            return Ok(DataStore.Current.Transports); 
        }

        [HttpGet("{id}")]
        public ActionResult<TransportDto> GetTransport(int id)
        {
            var TransportToReturn = DataStore.Current.Transports.FirstOrDefault(s => s.Id == id);

            if (TransportToReturn == null)
            {
                return NotFound();
            }

            return Ok(TransportToReturn);
        }
    }
}
