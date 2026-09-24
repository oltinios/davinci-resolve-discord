using System.Diagnostics;

while (true)
{
    bool resolveRunning = Process.GetProcessesByName("Resolve").Length > 0;

    if (resolveRunning)
    {
        Console.WriteLine("DaVinci Resolve is running");
    }
    else
    {
        Console.WriteLine("DaVinci Resolve is not running");
    }

    Thread.Sleep(10000);
}