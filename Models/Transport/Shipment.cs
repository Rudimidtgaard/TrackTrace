namespace TrackTrace.Models.Transport
{
    public class Shipment : TransportBase
    {
        public List<Container> Containers { get; set; }


        public Shipment()
        {
            Containers = new List<Container>();
        }


    }

}
