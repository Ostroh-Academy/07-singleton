Database foo = Database.GetInstance();
foo.Query("SELECT ...");

Database bar = Database.GetInstance();
bar.Query("SELECT ...");

// Обидва об'єкти foo і bar посилаються на один і той самий екземпляр бази даних.
// Тобто, foo і bar рівні за посиланням і вказують на один об'єкт Database.
Console.WriteLine(foo == bar); 