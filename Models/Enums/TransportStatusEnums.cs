namespace TrackTrace.Models.Enums
{
    public class TransportStatusEnums
    {
        public enum TransportStatus : byte
        {
            Booked = 0,
            InProgress = 1,
            InTransit = 2,
            OnHold = 3,
            Delivered = 4,
            Canceled = 5
        }
    }
}
