
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a design pattern to run:");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("2. Factory Method");
            Console.WriteLine("3. Decorator");
            Console.WriteLine("4. Observer");

            // Add more opt
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SingletonExample.Run();
                    break;
                case "2":
                    FactoryMethodExample.Run();
                    break;
                case "3":
                    DecoratorExample.Run();
                    break;
                case "4":
                    ObserverExample.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}