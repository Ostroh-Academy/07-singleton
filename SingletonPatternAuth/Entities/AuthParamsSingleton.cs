using SingletonPatternAuth.Entities.Interfaces;

namespace SingletonPatternAuth.Entities;

public class AuthParamsSingleton : IAuthParamsSingleton
{
    private static IAuthParams? _instance;

    public IAuthParams GetInstance()
    {
        return _instance ??= new AuthParamsBuilder()
            .WithUsername("defaultUser")
            .WithPassword("defaultPassword")
            .WithExpiration(DateTime.Now.AddHours(1))
            .Build();
    }
}