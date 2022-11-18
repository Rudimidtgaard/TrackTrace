namespace TrackTrace.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string UNLOCODE { get; set; }
        public string AirportCode { get; set; }
        public string PortCode { get; set; }
        public string CountryCode { get; set; }
        public string CityName { get; set; }
    }
}
