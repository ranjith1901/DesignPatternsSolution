using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // Define the SingletonExample class
    public class SingletonExample
    {
        // Define the static Run method within the SingletonExample class
        public static void Run()
        {
            // Create a variable to hold the instance of the Singleton class
            var instance = Singleton.Instance;
            // Call the DoSomething method on the Singleton instance
            instance.DoSomething();
        }
    }

    // Define the Singleton class
    public class Singleton
    {
        // Private static field to hold the single instance of the Singleton class
        private static Singleton _instance;
        // Private constructor to prevent external instantiation of the class
        private Singleton() { }
        // Public static property to provide access to the single instance of the Singleton class
        public static Singleton Instance
        {
            get
            {
                // Check if the _instance field is null (i.e., the Singleton instance has not been created yet)
                if (_instance == null)
                {
                    // If _instance is null, create a new instance of the Singleton class
                    _instance = new Singleton();
                }
                // Return the single instance of the Singleton class
                return _instance;
            }
        }

        // Public method to perform some action
        public void DoSomething()
        {
            // Print a message to the console indicating that the Singleton instance is performing an action
            Console.WriteLine("Singleton instance is doing something!");
        }
    }
}
