using authJWT.Data;
using authJWT.Dto;
using authJWT.Models;
using authJWT.Services.PasswordService;
using Microsoft.EntityFrameworkCore;

namespace authJWT.Services.AuthService
{
    public class AuthService : IAuthInterface
    {
        private readonly AppDbContext _context;
        private readonly IPasswordService _password;

        public AuthService(AppDbContext context, IPasswordService password)
        {
            _context = context;
            _password = password;
        }

        public async Task<Response<UserRegisterDto>> UserRegister(UserRegisterDto userRegister)
        {
            Response<UserRegisterDto> response = new Response<UserRegisterDto>();

            try
            {
                if (!CheckUserAndEmail(userRegister))
                {
                    response.Data = null;
                    response.Message = "Username or email already in use!";
                    response.Status = false;

                    return response;
                }

                _password.CreatePasswordHash(userRegister.Password, out byte[] passwordHash, out byte[] passowordSalt);

                User user = new User()
                {
                    Username = userRegister.Username,
                    Email = userRegister.Email,
                    JobTitle = userRegister.JobTitle,
                    SenhaHash= passwordHash,
                    SenhaSalt = passowordSalt
                };


                await _context.AddAsync(user);
                await _context.SaveChangesAsync();

                response.Message = "User registered sucessfully";

            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Status = false;

                return response;
            }

            return response;

        }

        public bool CheckUserAndEmail(UserRegisterDto userRegister)
        {
            var user = _context.Users.FirstOrDefault(user => user.Email == userRegister.Email || user.Username == userRegister.Username);

            if (user != null)
                return false;

            return true;
        }
    }
}
