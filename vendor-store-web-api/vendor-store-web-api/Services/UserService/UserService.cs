using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using vendor_store_web_api.Dtos;
using vendor_store_web_api.Dtos.UserDto;
using vendor_store_web_api.Helpers;
using vendor_store_web_api.Models;
namespace vendor_store_web_api.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private readonly IMapper _mapper; 
        public UserService( ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponse> SignUpAsync(UserDto model)
        {
            ServiceResponse response = new ServiceResponse();
            try
            {
                string pattern = @"^\d{10}$";
                Regex rg = new Regex(pattern);
                if (!rg.IsMatch(model.Phone))
                {
                    throw new AppException("Phone must be 10 numbers");
                }

                pattern = @"^.{8,}$";
                rg = new Regex(pattern);
                if (!rg.IsMatch(model.Password))
                {
                    throw new AppException("Password legnth must be at least 8 characters");
                }

        
                if (await _applicationDbContext.Users.Where(item => item.Email == model.Email).AnyAsync())
                {
                    throw new AppException("Email have already been used ");
                }
                

                User newUser = new User();
                newUser = _mapper.Map<User>(model);
                Console.WriteLine(newUser.Email);
                newUser.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                newUser.Birthday = newUser.Birthday.ToUniversalTime();
                await _applicationDbContext.Users.AddAsync(newUser);
                await _applicationDbContext.SaveChangesAsync();
                response.Status = StatusCodes.Status200OK;
                response.StatusMessage = "Register Successfully";

                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
        
        public async Task<ServiceResponse> SignInAsync(SignInDto model)
        {
            ServiceResponse response = new ServiceResponse();
            try
            {
                var existAccount = await _applicationDbContext.Users.Where(item => item.Email == model.Email).FirstOrDefaultAsync() ?? null;

                if (existAccount.Email != model.Email)
                {
                    throw new AppException("Email does not match");
                }

                if (!BCrypt.Net.BCrypt.Verify(model.Password,existAccount.Password))
                {
                    throw new AppException("Email or Password does not match");
                }

                response.Status = StatusCodes.Status200OK;
                response.StatusMessage = "Login Successfully";
                return response;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
      
    }
}
