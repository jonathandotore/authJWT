using authJWT.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace authJWT.Dto
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "Username field is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email field is required"), EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and PasswordCheck fields do not match")]
        public string PasswordCheck { get; set; }

        [Required(ErrorMessage = "Jobtitle field is required")]
        public EJobTitle JobTitle { get; set; }
    }
}
