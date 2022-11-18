using TrackTrace.Data;
using TrackTrace.Models;

namespace TrackTrace.Services
{
    public class EventRepository : IEventRepository
    {
        private readonly IDataProvider _dataProvider;

        public EventRepository(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
        }

        public async Task<Event?> GetEventAsync(string id)
        {
            return await _dataProvider.GetEvent(id);
        }

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            var events = await _dataProvider.GetEvents();
            
            return events.OrderBy(x => x.Id).ToList();
        }

        public async Task<EventDto> AddEvent(Event eventForCreation)
        {
            return await _dataProvider.AddEvent(eventForCreation);
        }
    }
}
