namespace ConsoleApp2
{
    internal class Program
    {
        public sealed class Singleton
        {
            private Singleton() { }

            private static Singleton _instance = null;

            public static Singleton GetInstance()
            {
                _instance ??= new Singleton();
                return _instance;
            }

            public void someBusinessLogic()
            {
            }
        }

        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
