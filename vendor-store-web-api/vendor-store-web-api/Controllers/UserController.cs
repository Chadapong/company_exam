using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vendor_store_web_api.Dtos.UserDto;
using vendor_store_web_api.Services.UserService;

namespace vendor_store_web_api.Controllers
{
    [Route("vendor-store/user/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController( IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("sign-up")]
        public async Task<IActionResult> SignUp([FromBody]UserDto model)
        {
            var result = await _userService.SignUpAsync(model);

            return result.Status == StatusCodes.Status200OK ? new OkObjectResult(new { message = result.StatusMessage }) : new BadRequestResult();
        }

        [HttpPost]
        [Route("sign-in")]
        public async Task<IActionResult> SignIn (SignInDto model)
        {
            var result = await _userService.SignInAsync(model);
            return result.Status == StatusCodes.Status200OK ? new OkObjectResult(new { message = result.StatusMessage }) : new BadRequestResult();
        }
    
    }
}
