using AutoMapper;
using TrackTrace.Models.Transport;

namespace TrackTrace.Profiles
{
    public class TransportProfile : Profile
    {
        public TransportProfile()
        {
            CreateMap<TransportBase, Models.TransportDto>();
        }
    }
}
