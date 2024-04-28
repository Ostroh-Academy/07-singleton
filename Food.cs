using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_P
{
    using System;

    public class FoodLoggerSingleton
    {
        private static FoodLoggerSingleton _instance;
        private int _foodCount = 0;
        private FoodLoggerSingleton() { }
        public static FoodLoggerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodLoggerSingleton();
            }
            return _instance;
        }
        public void LogFood(string foodName)
        {
            Console.WriteLine(_foodCount + ": " + foodName);
            _foodCount++;
        }
    }
    public class Chef
    {
        public void Cook(string foodName)
        {
            FoodLoggerSingleton logger = FoodLoggerSingleton.GetInstance();
            logger.LogFood("Cooking " + foodName + "...");
            logger.LogFood("Finished cooking " + foodName + ".");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();

            chef.Cook("Pasta");
            chef.Cook("Pizza");
            chef.Cook("Salad");
        }
    }
}
