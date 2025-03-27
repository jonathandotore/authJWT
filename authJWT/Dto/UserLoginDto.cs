using System.ComponentModel.DataAnnotations;

namespace authJWT.Dto
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "Username field is required"), EmailAddress(ErrorMessage = "Invalid e-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }
    }
}
