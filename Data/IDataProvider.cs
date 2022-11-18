using TrackTrace.Models;

namespace TrackTrace.Data
{
    public interface IDataProvider
    {
        Task<List<Event>> GetEvents();

        Task<Event> GetEvent(string id);

        Task<EventDto> AddEvent(Event eventForCreation);
    }
}