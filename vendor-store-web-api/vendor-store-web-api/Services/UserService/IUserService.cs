using vendor_store_web_api.Dtos;
using vendor_store_web_api.Dtos.UserDto;

namespace vendor_store_web_api.Services.UserService
{
    public interface IUserService
    {
        public Task<ServiceResponse> SignUpAsync(UserDto model);
        public Task<ServiceResponse> SignInAsync(SignInDto model);


    }
}
