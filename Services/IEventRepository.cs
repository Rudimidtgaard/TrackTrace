using TrackTrace.Models;

namespace TrackTrace.Services
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEventsAsync();

        Task<Event?>GetEventAsync(string id);

        Task<EventDto> AddEvent(Event eventForCreation);

    }
}
