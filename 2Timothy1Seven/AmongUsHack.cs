using System;
using System.Threading;
using Memory;

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
                    Console.WriteLine("Process Closed.");
                    processOpen = false;
                }
            }
            else if (!processOpen)
            {
                if (m.OpenProcess("Among Us"))
                {
                    Console.WriteLine("Process Opened.");
                    processOpen = true;
                }
            }
            Thread.Sleep(5000);
        }
    }
}
