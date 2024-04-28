using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    internal class TrainReservationSystem
    {
        private static TrainReservationSystem _instance;

        private bool[] seats = new bool[100];

        private TrainReservationSystem() { }

        public static TrainReservationSystem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TrainReservationSystem();
                }

                return _instance;
            }
        }

        public bool ReserveSeat(int seatNumber)
        {
            if (seatNumber < 0 || seatNumber >= seats.Length)
            {
                Console.WriteLine("Неправильний номер місця.");
                return false;
            }

            if (seats[seatNumber] == true)
            {
                Console.WriteLine($"Місце {seatNumber} вже заброньоване.");
                return false;
            }

            seats[seatNumber] = true;
            Console.WriteLine($"Місце {seatNumber} успішно заброньоване.");
            return true;
        }
    }
}
