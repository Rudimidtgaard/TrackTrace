namespace TrackTrace.Models
{
    public class TransportDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string?  Description { get; set; }

        public int NumberOfEvents 
        { 
            get
            {
                return Events.Count;
            }
        }

        public ICollection<EventDto> Events { get; set; } = new List<EventDto>();
    }
}
