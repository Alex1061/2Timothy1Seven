using System;
using System.Threading;
using Memory;

public class AmongUsHack
{
	public Mem m = new Mem();

	public AmongUsHack()
	{
        while (true)
        {
            if (m.OpenProcess("Among Us"))
            {
                Console.WriteLine("Process Opened.");
                Thread.Sleep(1000);
            }
            else if (!m.OpenProcess("Among Us"))
            {
                Console.WriteLine("Process Closed.");
                Thread.Sleep(1000);
            }            
        }
    }
}
