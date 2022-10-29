using TrackTrace.Models.Enums;
using static TrackTrace.Models.Enums.EventClassifierEmums;
using static TrackTrace.Models.Enums.EventLevelEnums;

namespace TrackTrace.Models
{
    public class EventDto
    {
        public int Id { get; set; }
        public EventClassifier Classifier { get; set; }
        public EventLevel Level { get; set; }


    }



}
