using System.Security.Cryptography;
using System.Text;
using SingletonPatternAuth.Entities.Interfaces;

namespace SingletonPatternAuth.Entities;

public class AuthParamsBuilder : IAuthParamsBuilder
{
    private string _username = string.Empty;
    private string _password = string.Empty;
    private DateTime _expiration;

    public IAuthParamsBuilder WithUsername(string username)
    {
        _username = username;
        return this;
    }

    public IAuthParamsBuilder WithPassword(string password)
    {
        _password = password;
        return this;
    }

    public IAuthParamsBuilder WithExpiration(DateTime expiration)
    {
        _expiration = expiration;
        return this;
    }

    public IAuthParams Build()
    {
        if (string.IsNullOrEmpty(_username))
            throw new InvalidOperationException("Username is required");
        if (string.IsNullOrEmpty(_password))
            throw new InvalidOperationException("Password is required");
        if (_expiration == default(DateTime))
            throw new InvalidOperationException("Expiration is required");

        var encryptedPassword = Encrypt(_password);
        return new AuthParams(_username, encryptedPassword, _expiration);
    }

    private string Encrypt(string input)
    {
        var inputBytes = Encoding.UTF8.GetBytes(input);
        var hashBytes = MD5.HashData(inputBytes);
        return Convert.ToBase64String(hashBytes);
    }
}