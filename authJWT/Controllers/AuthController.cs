using authJWT.Dto;
using authJWT.Services.AuthService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace authJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthInterface _authIterface;

        public AuthController(IAuthInterface authIterface)
        {
            _authIterface = authIterface;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(UserLoginDto userLogin)
        {
            var response = await _authIterface.UserLogin(userLogin);
            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(UserRegisterDto userRegister)
        {
            var response = await _authIterface.UserRegister(userRegister);
            return Ok(response);
        } 
    }
}
