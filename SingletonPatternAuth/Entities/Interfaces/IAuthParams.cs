namespace SingletonPatternAuth.Entities.Interfaces;

public interface IAuthParams
{
    string Username { get; }
    string EncryptedPassword { get; }
    DateTime Expiration { get; }
}