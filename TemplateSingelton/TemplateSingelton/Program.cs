namespace TemplateSingelton
{

        public class Singleton
        {
            private static Singleton instance;

            private Singleton() { }

            public static Singleton GetInstance()
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Singleton singleton1 = Singleton.GetInstance();
                Singleton singleton2 = Singleton.GetInstance();

                if (singleton1 == singleton2)
                    Console.WriteLine("Обєкти схожі");
                else
                    Console.WriteLine("Обєкти різні");

                Console.ReadLine();
            }
        }
    }

