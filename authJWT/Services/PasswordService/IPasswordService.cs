﻿namespace authJWT.Services.PasswordService
{
    public interface IPasswordService
    {
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
    }
}
