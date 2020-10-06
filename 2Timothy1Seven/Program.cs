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
            if (Config.name == "100")
            {
                Configuration();
            } else
            {
                Console.WriteLine("Welcome to 2Timothy1Seven!" + Config.name);
                Console.Beep();
                Console.WriteLine("By Vincent Jenei (Lite #4211)");
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("For God has not given us a spirit of fear, but of power and of love and of a sound mind.");
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Today: " + thisDate);
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
            }
            Console.Write("Press enter key to exit.");
            Console.Beep();
            Console.ReadLine();
        }

        public static void Configuration()
        {
            Console.Write("Enter your name: ");
            Console.Beep();
            Config.name = Console.ReadLine();;
            Console.WriteLine("Configuration Complete.");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();
        }
    }
}
