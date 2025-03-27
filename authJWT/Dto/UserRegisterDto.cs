using authJWT.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace authJWT.Dto
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "Username field required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email field required"), EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and PasswordCheck fields do not match")]
        public string PassowordCheck { get; set; }

        [Required(ErrorMessage = "Jobtitle field required")]
        public EJobTitle JobTitle { get; set; }
    }
}
