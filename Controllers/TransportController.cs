using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TrackTrace.Models;

namespace TrackTrace.Controllers
{
    [Route("api/transports")]
    [ApiController]
    public class TransportController : ControllerBase
    {

        //[HttpGet("{id}")]
        //public ActionResult<TransportDto> GetTransport(int id)
        //{
        //    var TransportToReturn = DataStore.Current.Transports.FirstOrDefault(s => s.Id == id);

        //    if (TransportToReturn == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(TransportToReturn);
        //}

        //[HttpPatch("{transportId}")]
        //public ActionResult PartiallyUpdateTransport(int transportId, JsonPatchDocument<TransportForUpdateDto> patchDocument)
        //{
        //    var transportfromStore = DataStore.Current.Transports.FirstOrDefault(t => t.Id == transportId);

        //    if (transportfromStore == null)
        //        return NotFound();

        //    var transportToPatch = new TransportForUpdateDto()
        //    {
        //        Name = transportfromStore.Name,
        //        Description = transportfromStore.Description
        //    };

        //    patchDocument.ApplyTo(transportToPatch, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (!TryValidateModel(transportToPatch))
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    transportfromStore.Name = transportToPatch.Name;
        //    transportfromStore.Description = transportToPatch.Description;

        //    return NoContent();

        //}

    }
}
