using System;

namespace SingletonPatternExample
{
    public sealed class Singleton
    {

        private static Singleton? _instance = null;
        

        private static readonly object _lock = new object();


        private Singleton()
        {
            // nothing to write here, cuz it's only example 
        }

        
        public static Singleton Instance
        {
            get
            {
                
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }

       
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
  
            Singleton singleton = Singleton.Instance;

            
            singleton.DoSomething();

     
            Singleton anotherSingleton = Singleton.Instance;
            if (ReferenceEquals(singleton, anotherSingleton))
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
        }
    }
}