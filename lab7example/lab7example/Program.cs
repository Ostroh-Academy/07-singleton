using System;

public class StoreManager
{
   
    private static StoreManager _instance;

    
    private StoreManager()
    {
        Console.WriteLine("StoreManager instance created.");
    }

    
    public static StoreManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new StoreManager();
            }
            return _instance;
        }
    }

   
    public void ManageStore()
    {
        Console.WriteLine("Managing the store.");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        StoreManager manager1 = StoreManager.Instance;
        manager1.ManageStore();

        
        StoreManager manager2 = StoreManager.Instance;
        manager2.ManageStore();

        
        if (manager1 == manager2)
        {
            Console.WriteLine("Both instances are the same.");
        }
        else
        {
            Console.WriteLine("Instances are different.");
        }
    }
}
