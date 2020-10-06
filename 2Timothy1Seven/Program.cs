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
            if (!File.Exists("Config.txt"))
            {
                Configuration();
            }
            else if (File.Exists("Config.txt"))
            {
                StreamReader sr = new StreamReader("Config.txt");
                Config.name = sr.ReadLine();
                sr.Close();
            }               
            {
                //Welcome Menu
                Console.WriteLine("Welcome: " + Config.name + " to 2Timothy1Seven!");
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

                SelectionMenu();
            }

            //If somehow returned to here:
            Console.WriteLine("");
            Console.Beep();
            Console.Write("Press enter key to exit.");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();
            Console.ReadLine();
        }

        public static void SelectionMenu()
        {
            //Select Menu
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("What hacks would you like to use today?");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("1: Among Us");
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("(Depreceted) 2: Roblox");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();

            Console.Write("Selection: ");
            Console.Beep();
            string selection = Console.ReadLine();

            if (selection != "1")
            {
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Invalid selection my g, input a valid value.");
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
                SelectionMenu();
            }
            else 
            if (selection == "1")
            {
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Valid selection my g!");
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
                LoadAmongUsHacks();
            }
        }
        public static void Configuration()
        {
            Console.Write("Enter your name: ");
            Console.Beep();
            Config.name = Console.ReadLine();
            Console.Beep();


            StreamWriter sw = new StreamWriter("Config.txt");
            sw.WriteLine(Config.name);
            sw.Close();

            Console.WriteLine("Configuration Complete.");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();

            Startup();
        }
        public static void LoadAmongUsHacks()
        {
            Console.WriteLine("");
            Console.Beep();
            Console.Write("Loading");
            Console.Beep();
            Console.Write(".");
            Console.Beep();
            Console.Write(".");
            Console.Beep();
            Console.Write(".");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("");
            Console.Beep();
            AmongUsHack amongUsHacks = new AmongUsHack();
        }
    }
}
