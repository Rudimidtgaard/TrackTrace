using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using TrackTrace.Data;
using TrackTrace.Models;
using TrackTrace.Services;

namespace TrackTrace.Controllers
{
    [Route("api/Events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventController(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDto>>> GetEvents()
        {
            var eventEntities = await _eventRepository.GetEventsAsync();

            if (eventEntities == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<EventDto>>(eventEntities));
        }

        [HttpGet("{eventid}", Name = "GetEvent")]
        public async Task<ActionResult<EventDto>> GetEvent(string eventId)
        {
            var eventEntity = await _eventRepository.GetEventAsync(eventId);

            if (eventEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<EventDto>(eventEntity));
        }

        //[HttpPut("{eventid}")]
        //public  async Task<ActionResult> UpdateEvent(string eventId, EventForUpdateDto eventForUpdateDto) 
        //{
        //    var eventDto = await _eventRepository.GetEventAsync(eventId);

        //    if (eventDto == null)
        //    {
        //        return NotFound();
        //    }

        //    _mapper.Map(eventForUpdateDto, eventDto);
        
        //}

        [HttpPost(Name = "CreateEvent")]
        public async Task<ActionResult<EventDto>> CreateEvent(EventForCreationDto eventForCreation)
        {
            //Input data annotation 
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var finalEvent = _mapper.Map<Event>(eventForCreation);

            var intertedEvent = await _eventRepository.AddEvent(finalEvent);

            return CreatedAtRoute("GetEvent", new { eventid = intertedEvent.Id }, intertedEvent);
            
        }

    }
}
