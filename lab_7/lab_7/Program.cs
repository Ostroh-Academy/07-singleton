using lab_7;

class Program
{
    static void Main(string[] args)
    {
        Logger logger = Logger.GetInstance();

        logger.Log("Application started.");
        logger.Log("Something happened.");
        logger.Log("Application stopped.");
    }
}
