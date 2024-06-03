using Lab_07_Zahrebelnyi;

class Program
{
    static void Main(string[] args)
    {
        House house1 = House.GetInstance();
        house1.DisplayHouseInfo();

        House house2 = House.GetInstance();
        house2.DisplayHouseInfo();

        if (house1 == house2)
        {
            Console.WriteLine("house1 and house2 are the same instance.");
        }
        else
        {
            Console.WriteLine("house1 and house2 are different instances.");
        }
    }
}