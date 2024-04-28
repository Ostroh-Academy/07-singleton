using Laba7;

TrainReservationSystem system = TrainReservationSystem.Instance;
TrainReservationSystem system2 = TrainReservationSystem.Instance;

system.ReserveSeat(10);
system2.ReserveSeat(20);

system.ReserveSeat(20);
system.ReserveSeat(10);

Console.WriteLine($"Чи посилаються обидва об'єкти {nameof(system)} та {nameof(system2)} на один екземпляр класу " +
    $"{nameof(TrainReservationSystem)}: {system == system2}");