using System;
using System.Threading;
using Memory;

namespace _2Timothy1Seven
{
    //Process Checker:
    public class AmongUsHack
    {
        public Mem m = new Mem();
        public bool processOpen = false;

        public AmongUsHack()
        {
            while (true)
            {
                if (processOpen)
                {
                    if (!m.OpenProcess("Among Us"))
                    {
                        Console.WriteLine("Process Closed. ");
                        processOpen = false;
                    }
                    else
                    //Among us IS open:
                    {

                    }
                }
                else if (!processOpen)
                {
                    if (m.OpenProcess("Among Us"))
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
    }

    //Actual Hacks:
    public class AmongUsHacks
    {

    }
}