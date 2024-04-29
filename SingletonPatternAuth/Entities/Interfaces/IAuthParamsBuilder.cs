namespace SingletonPatternAuth.Entities.Interfaces;

public interface IAuthParamsBuilder
{
    IAuthParamsBuilder WithUsername(string username);
    IAuthParamsBuilder WithPassword(string password);
    IAuthParamsBuilder WithExpiration(DateTime expiration);
    IAuthParams Build();
}