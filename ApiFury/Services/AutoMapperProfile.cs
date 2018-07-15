using ApiFury.Entities;
using ApiFury.Models;
using AutoMapper;

namespace ApiFury.Services
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDB>();
            CreateMap<UserDB, User>();
        }
    }
}