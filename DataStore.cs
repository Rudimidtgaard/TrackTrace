using TrackTrace.Models;
using TrackTrace.Models.Enums;
using static TrackTrace.Models.Enums.EventClassifierEmums;

namespace TrackTrace
{
    public class DataStore
    {
        public List<TransportDto> Transports { get; set; }

        public static DataStore Current { get; } = new DataStore();

        public DataStore()
        {
            Transports = new List<TransportDto>()
            {
                new TransportDto()
                {
                    Id = 1,
                    Name = "This is name for transport 1",
                    Description = "This is a description for transport 1",
                    Events = new List<EventDto>()
                    {
                        new EventDto() {Id = 1, Classifier = EventClassifier.Estimated, Level = EventLevelEnums.EventLevel.Shipment},
                        new EventDto() {Id = 2, Classifier = EventClassifier.Planned, Level = EventLevelEnums.EventLevel.Shipment}
                    }
                },
                new TransportDto()
                {
                    Id = 2,
                    Name = "This is name for transport 2",
                    Description = "This is a description for transport 2",
                    Events = new List<EventDto>()
                    {
                        new EventDto() {Id = 3, Classifier = EventClassifier.Estimated, Level = EventLevelEnums.EventLevel.Shipment},
                        new EventDto() {Id = 4, Classifier = EventClassifier.Planned, Level = EventLevelEnums.EventLevel.Shipment}
                    }
                },
                new TransportDto()
                {
                    Id = 3,
                    Name = "This is name for transport 3",
                    Description = "This is a description for transport 3",
                    Events = new List<EventDto>()
                    {
                        new EventDto() {Id = 5, Classifier = EventClassifier.Estimated, Level = EventLevelEnums.EventLevel.Shipment},
                        new EventDto() {Id = 6, Classifier = EventClassifier.Planned, Level = EventLevelEnums.EventLevel.Shipment}
                    }
                }
            };
        }

    }
}
