using AutoMapper;

namespace TrackTrace.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Models.Event, Models.EventDto>();
            CreateMap<Models.Event, Models.EventForCreationDto>();
            CreateMap<Models.EventForCreationDto, Models.Event>();
        }
    }
}
