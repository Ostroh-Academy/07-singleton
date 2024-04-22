namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            if(singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works");
            }
            else
            {
                Console.WriteLine("Singleton failed");
            }
            singleton1.PrintDetails("From singleton1");
            singleton2.PrintDetails("From singleton2");
        }
    }
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
           if(_instance == null)
           {
                _instance = new Singleton();
           }
           return _instance;
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine($"Details {message}");
        }
    }
}
