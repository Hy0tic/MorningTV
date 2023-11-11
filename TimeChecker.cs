using System;
using System.Diagnostics;
using System.Threading;

public static class TimeChecker
{
    public static void CheckTime(object state)
    {
        TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTime currentTimeEst = TimeZoneInfo.ConvertTime(DateTime.Now, est);

        if (currentTimeEst.Hour == 1 && currentTimeEst.Minute == 0)
        {
            DoSomething();
            Thread.Sleep(60000);
        }
    }

    public static void DoSomething()
    {
        Console.WriteLine("It's 5 AM EST! Performing the action...");
        string url = "https://play.max.com/video/watch/6e753253-9b38-4e02-a86c-b691b4d51f33/ddfe9a93-16d2-4233-b3a1-36ac18b9b795";
        Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
    }
}

