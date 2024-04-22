namespace ConsoleApp1
{
    internal class Program
    {
        public sealed class AuthSingleton
        {
            private readonly Dictionary<string, Dictionary<string, string>> _params;

            private AuthSingleton()
            {
                _params = [];
            }

            public static AuthSingleton Instance { get; } = new AuthSingleton();

            public void SetParameter(string resource, string username, string password)
            {
                if (!_params.TryGetValue(resource, out Dictionary<string, string>? value))
                {
                    value = [];
                    _params[resource] = value;
                }

                value["username"] = username;
                value["password"] = password;
            }

            public Dictionary<string, string>? GetParameter(string resource) => _params.GetValueOrDefault(resource);
        }

        static void Main(string[] args)
        {
            AuthSingleton authParams = AuthSingleton.Instance;

            authParams.SetParameter("Google", "user1", "password1");
            authParams.SetParameter("Facebook", "user2", "password2");

            Dictionary<string, string>? paramsGoogle = authParams.GetParameter("Google");
            Dictionary<string, string>? paramsFacebook = authParams.GetParameter("Facebook");

            Console.WriteLine("Google parameters:");

            if (paramsGoogle != null)
                Console.WriteLine($"Username: {paramsGoogle["username"]}, Password: {paramsGoogle["password"]}");

            Console.WriteLine();
            Console.WriteLine("Facebook parameters:");

            if (paramsFacebook != null)
                Console.WriteLine($"Username: {paramsFacebook["username"]}, Password: {paramsFacebook["password"]}");

            Console.WriteLine();

            AuthSingleton authParams2 = AuthSingleton.Instance;
            Console.WriteLine(authParams == authParams2);
        }
    }
}
