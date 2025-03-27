using authJWT.Models.Enums;

namespace authJWT.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Email { get; set; }
        public string Username { get; set; }
        public EJobTitle JobTitle { get; set; }
        public byte[] SenhaHash { get; set; }
        public byte[] SenhaSalt { get; set; }
        public DateTime CreateDateToken { get; set; } = DateTime.Now;
    }
}
