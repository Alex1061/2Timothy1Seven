﻿using System;
using System.Diagnostics;
using System.Threading;
using Memory;

namespace _2Timothy1Seven
{
    //Process Checker:
    public class AmongUsHack
    {
        public Mem mem = new Mem();
        public Player player = new Player();
        public bool processOpen = false;

        public AmongUsHack()
        {
            while (true)
            {
                if (processOpen)
                {
                    if (!mem.OpenProcess("Among Us"))
                    {
                        Console.WriteLine("Process Closed. ");
                        processOpen = false;
                    }
                    else
                    //Among us IS open:
                    {
                        HackSelection();
                    }
                }
                else if (!processOpen)
                {
                    if (mem.OpenProcess("Among Us"))
                    {
                        Console.WriteLine("Process Opened. ");
                        processOpen = true;
                    }
                    else
                    //Among us IS NOT open:
                    {
                        Console.WriteLine("Open the Among Us process. ");
                    }
                }
                Thread.Sleep(2500);
            }
        }

        public string hackSelection;
        public void HackSelection()
        {
            Console.WriteLine(" ");
            Console.Beep();
            Console.WriteLine(" Select what you would like to perform.");
            Console.Beep();
            Console.Write("1: ");
            Console.Beep();
            Console.WriteLine("Force Imposter.");
            Console.Beep();
            Console.Write("2: ");
            Console.Beep();
            Console.WriteLine("Exit.");
            Console.Beep();
            Console.WriteLine(" ");
            Console.Beep();
            Console.Write("Selection: ");
            Console.Beep();

            hackSelection = Console.ReadLine();

            if (hackSelection == "1")
            {
                Console.WriteLine(" ");
                Console.Beep();

                player.Set_Impostor(1);

                Console.WriteLine("Imposter enabled!");
                Console.Beep();
            }

            if (hackSelection == "2")
            {
                Console.WriteLine(" ");
                Console.Beep();
                Console.Write("Goodbye!");
                Console.Beep();
                Console.Write(".");
                Console.Beep();
                Console.Write(".");
                Console.Beep();
                Console.WriteLine(".");
                Console.Beep();
                Process.GetCurrentProcess().Kill();
                return;
            }

            HackSelection();
        }
    }

    //Actual Hacks:
    public class AmongUsHacks
    {

    }
}