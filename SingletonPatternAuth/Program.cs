using SingletonPatternAuth.Entities;
using SingletonPatternAuth.Entities.Interfaces;

namespace SingletonPatternAuth;

public static class Program
{
    private static void Main()
    {
        IAuthParamsSingleton authParamsSingleton = new AuthParamsSingleton();
        var singletonParams = authParamsSingleton.GetInstance();

        Console.WriteLine("\nAuth Params retrieved from Singleton:");
        Console.WriteLine($"Username: {singletonParams.Username}");
        Console.WriteLine($"Encrypted Password: {singletonParams.EncryptedPassword}");
        Console.WriteLine($"Expiration: {singletonParams.Expiration}");
    }
}