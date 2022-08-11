using AutoMapper;
using DTO.User;
using Models.Models;

namespace Business.Configuration.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateUserRequest, UserInfo>();
            CreateMap<UpdateUserRequest, UserInfo>();
        }
    }
}
