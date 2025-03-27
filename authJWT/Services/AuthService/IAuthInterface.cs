using authJWT.Dto;
using authJWT.Models;

namespace authJWT.Services.AuthService
{
    public interface IAuthInterface
    {
        public Task<Response<UserRegisterDto>> UserRegister(UserRegisterDto userRegister);
    }
}
