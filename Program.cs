using CarStore;
namespace CarStoreMain;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Insert Name of the Store Owner: ");
        string owner = Console.ReadLine();
        Carstore store = new Carstore(owner);

        while (true)
        {
            Console.WriteLine($"\nHello Mr.{owner}!\n" +
                $"1. add new Cars\n" +
                $"2. sell Cars\n" +
                $"3. print car details\n" +
                $"4. print store details\n" +
                $"5. Exit");

            Console.WriteLine("Choose option 1-5: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                store.AddCars();
            }
            else if (choice == "2")
            {
                store.SellCar();
            }
            else if (choice == "3")
            {
                store.DisplayCars();
            }
            else if (choice == "4")
            {
                Console.WriteLine(store);
            }
            else if (choice == "5")
            {
                Console.WriteLine($"Bye {owner}!");
                break;
            }
            else
            {
                Console.WriteLine($"Wrong Character Mr.{owner}");
                continue;
            }
        }
    }
}
