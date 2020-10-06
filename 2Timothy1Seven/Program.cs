using System;
using System.IO;
using System.Reflection;

namespace _2Timothy1Seven
{
    class Program
    {
        static DateTime thisDate = DateTime.Now;

        static class Config
        {
            public static string name;
        }
        public static void Main()
        {
            Startup();
        }
        public static void Startup()
        {
            if (Config.name == null)
            {
                Configuration();
            } else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Welcome to 2Timothy1Seven!" + Config.name);
                Console.WriteLine("");
                Console.WriteLine("For God has not given us a spirit of fear, but of power and of love and of a sound mind.");
                Console.WriteLine("");
                Console.WriteLine("Today: " + thisDate);
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.Write("Press enter key to exit.");
            Console.ReadLine();
        }

        public static void Configuration()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}
