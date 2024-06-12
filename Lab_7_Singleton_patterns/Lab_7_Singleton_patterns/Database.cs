using System;

public class Database
{

    private static Database instance;


    private Database()
    {

        Console.WriteLine("Database connection initialized.");
    }


    public static Database GetInstance()
    {
        if (instance == null)
        {
            if (instance == null)
            {
                instance = new Database();
            }
        }
        return instance;
    }

    public void Query(string sql)
    {
        Console.WriteLine($"Query executed: {sql}");
    }
}