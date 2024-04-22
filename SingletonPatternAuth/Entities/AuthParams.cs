using SingletonPatternAuth.Entities.Interfaces;

namespace SingletonPatternAuth.Entities;

public class AuthParams : IAuthParams
{
    public string Username { get; }
    public string EncryptedPassword { get; }
    public DateTime Expiration { get; }

    public AuthParams(string username, string encryptedPassword, DateTime expiration)
    {
        Username = username;
        EncryptedPassword = encryptedPassword;
        Expiration = expiration;
    }
}