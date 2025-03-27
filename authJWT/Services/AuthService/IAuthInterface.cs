using authJWT.Dto;
using authJWT.Models;

namespace authJWT.Services.AuthService
{
    public interface IAuthInterface
    {
        Task<Response<UserRegisterDto>> UserRegister(UserRegisterDto userRegister);

        Task<Response<string>> UserLogin(UserLoginDto userLogin);
    }
}
