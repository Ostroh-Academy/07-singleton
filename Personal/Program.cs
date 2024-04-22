namespace Singleton.Personal
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Measure { get; set; }

        public InventoryItem(string name, int count, string measure)
        {
            Name = name;
            Count = count;
            Measure = measure;
        }
    }

    public sealed class InventoryTracker
    {
        private static InventoryTracker instance = null;

        private List<InventoryItem> inventory;

        private InventoryTracker()
        {
            inventory = new List<InventoryItem>();
        }

        public static InventoryTracker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventoryTracker();
                }
                return instance;
            }
        }

        public void AddItem(string name, int count, string measure)
        {
            InventoryItem existingItem = inventory.Find(item => item.Name == name);
            if (existingItem != null)
            {
                existingItem.Count += count;
                Console.WriteLine($"Added {count} {measure} of \"{name}\". Total count: {existingItem.Count} {existingItem.Measure}");
            }
            else
            {
                InventoryItem newItem = new InventoryItem(name, count, measure);
                inventory.Add(newItem);
                Console.WriteLine($"Added \"{name}\" ({count} {measure}) to the inventory.");
            }
        }

        public void RemoveItem(string name, int count)
        {
            InventoryItem existingItem = inventory.Find(item => item.Name == name);
            if (existingItem != null)
            {
                if (existingItem.Count >= count)
                {
                    existingItem.Count -= count;
                    Console.WriteLine($"Removed {count} items of \"{name}\". Total count: {existingItem.Count} {existingItem.Measure}");
                }
                else
                {
                    Console.WriteLine($"Cannot remove {count} items of \"{name}\", only {existingItem.Count} {existingItem.Measure} available in the inventory.");
                }
            }
            else
            {
                Console.WriteLine($"Item \"{name}\" not found in the inventory.");
            }
        }

        public void PrintInventory()
        {
            Console.WriteLine("Inventory List:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Name} - {item.Count} {item.Measure}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            InventoryTracker tracker = InventoryTracker.Instance;

            tracker.AddItem("Lamp", 10, "pcs");
            tracker.AddItem("Milk", 5, "liters");
            tracker.AddItem("Bread", 20, "pcs");

            tracker.PrintInventory();

            tracker.AddItem("Lamp", 5, "pcs");

            tracker.PrintInventory();

            tracker.RemoveItem("Milk", 3);

            tracker.PrintInventory();
        }
    }
}
