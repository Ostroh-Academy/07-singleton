namespace SingletonPatternAuth.Entities.Interfaces;

public interface IAuthParamsSingleton
{
    IAuthParams GetInstance();
}