// Create a timer that ticks every 10 seconds
Timer timer = new Timer(new TimerCallback(TimeChecker.CheckTime), null, 0, 10000);

// Prevent the Main thread from exiting
Console.ReadLine();