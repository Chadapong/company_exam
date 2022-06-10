using AutoMapper;
using vendor_store_web_api.Dtos.UserDto;
using vendor_store_web_api.Models;

namespace vendor_store_web_api.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
        }
    }
}
