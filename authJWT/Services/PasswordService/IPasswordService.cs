using authJWT.Models;

namespace authJWT.Services.PasswordService
{
    public interface IPasswordService
    {
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

        bool PasswordChecker(string password, byte[] passwordHash, byte[] passwordSalt);

        string CreateToken(User user);
    }
}
