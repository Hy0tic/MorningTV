using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class TimeChecker
{
    public static void CheckTime(object state)
    {
        TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTime currentTimeEst = TimeZoneInfo.ConvertTime(DateTime.Now, est);

        if (currentTimeEst.Hour == 13 && currentTimeEst.Minute == 9)
        {
            DoSomething();
            Thread.Sleep(7000000);
        }
    }

    public static void DoSomething()
    {
        Console.WriteLine("It's 5 AM EST!");
        string url = "https://auth.max.com/login";
        // Process.Start(new ProcessStartInfo
        // {
        //     FileName = url,
        //     UseShellExecute = true
        // });
        using (var browser = new ChromeDriver())
        {
            browser.Navigate().GoToUrl(url);
            // Wait for the page to load and elements to be present
            EnterUsername(browser, "vothanhdat278@gmail.com");
            Thread.Sleep(5000000);
        }
    }

    public static void EnterUsername(IWebDriver driver, string username)
    {
        try
        {
            // Find the input field by its id and enter the username
            Thread.Sleep(19000);
            Console.WriteLine("enteringggg");
            var usernameInput = driver.FindElement(By.Name("username"));
            usernameInput.SendKeys(username);
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Username input field not found.");
        }
    }
}

