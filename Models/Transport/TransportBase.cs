using System.ComponentModel.DataAnnotations;
using TrackTrace.Models.Enums;
using TrackTrace.Models.Vessel;

namespace TrackTrace.Models.Transport
{
    public abstract class TransportBase
    {
        public int Id { get; set; }
        public List<Event> Events { get; set; } = new List<Event>();

        public TransportStatusEnums TransportStatus { get; set; };

        public string ExportPort { get; set; }

        public string ImportPort { get; set; }

        public List<VesselBase> Route { get; set; } = new List<VesselBase>();

    }
}
