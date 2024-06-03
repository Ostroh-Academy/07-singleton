namespace Lab_07_Zahrebelnyi
{
    public class House
    {
        private static House _instance;
        private static readonly object _lock = new object();

        private House()
        {
            NumberOfRooms = 4;
            Address = "123 Main St";
        }

        public int NumberOfRooms { get; private set; }
        public string Address { get; private set; }

        public static House GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new House();
                    }
                }
            }
            return _instance;
        }

        public void DisplayHouseInfo()
        {
            Console.WriteLine($"House Address: {Address}, Number of Rooms: {NumberOfRooms}");
        }
    }
}