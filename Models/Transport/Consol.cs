namespace TrackTrace.Models.Transport
{
    public class Consol : TransportBase 
    {
        public List<Shipment> Shipments { get; set; }

        public Consol()
        {
            Shipments= new List<Shipment>();
        }

    }
}
