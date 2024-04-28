public class TrainBookingSystem
{
    private static TrainBookingSystem _instance;
    private static readonly object _lock = new object();
    private List<int> _availableSeats;

    private TrainBookingSystem()
    {
        _availableSeats = new List<int>();
        // список доступних місць для бронювання
        for (int i = 1; i <= 50; i++)
        {
            _availableSeats.Add(i);
        }
    }

    public static TrainBookingSystem Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new TrainBookingSystem();
                }
                return _instance;
            }
        }
    }

    public void ReserveSeat(string passengerName, int seatNumber)
    {
        if (_availableSeats.Contains(seatNumber))
        {
            // бронювання місця
            Console.WriteLine($"Місце {seatNumber} було заброньовано для пасажира {passengerName}");
            _availableSeats.Remove(seatNumber);
        }
        else
        {
            Console.WriteLine($"Місце {seatNumber} вже заброньовано або недоступно.");
        }
    }

    public void CancelReservation(int seatNumber)
    {
        // скасування резервації
        if (!_availableSeats.Contains(seatNumber))
        {
            _availableSeats.Add(seatNumber);
            Console.WriteLine($"Резервація для місця {seatNumber} була скасована");
        }
        else
        {
            Console.WriteLine($"Місце {seatNumber} не було заброньовано.");
        }
    }
}
