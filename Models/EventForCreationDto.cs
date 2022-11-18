using System.ComponentModel.DataAnnotations;
using static TrackTrace.Models.Enums.EventClassifierEmums;
using static TrackTrace.Models.Enums.EventLevelEnums;

namespace TrackTrace.Models
{
    public class EventForCreationDto
    {
        public EventClassifier Classifier { get; set; }
        //Input data annotation Requred
        [Required(ErrorMessage ="Please add a event levet for this event")]
        public EventLevel Level { get; set; }
    }
}
