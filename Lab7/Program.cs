namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileAppSingleton instance1 = MobileAppSingleton.GetInstance();
            Console.WriteLine(instance1.SomeData); 

            instance1.SomeData = "Modified data";

            MobileAppSingleton instance2 = MobileAppSingleton.GetInstance();
            Console.WriteLine(instance2.SomeData); 

            if (instance1 == instance2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Different instances of Singleton are returned.");
            }
        }
    }
}
