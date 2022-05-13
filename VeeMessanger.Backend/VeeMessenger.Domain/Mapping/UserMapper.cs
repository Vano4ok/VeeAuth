using AutoMapper;
using VeeMessenger.Data.Entities;
using VeeMessenger.Domain.Dto.User;

namespace VeeMessenger.Domain.Mapping
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserForRegistrationDto, User>().ReverseMap();
        }
    }
}
