using System;
using System.Threading;

public class Activity
{
    protected string _title;
    protected string _description;
    protected string _endMessage;
    protected int _seconds;

    public Activity(string title, string description, string endMessage)
    {
        _title = title;
        _description = description;
        _endMessage = endMessage;
        _seconds = 0;
    }
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

         _seconds = int.Parse(Console.ReadLine());


        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_seconds} seconds of the {_title} activity.");
        ShowSpinner(2);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds)
    {
        char[] frames = new char[] { '|', '/', '-', '\\' };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        Console.Write(" "); 
        while (DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b"); 
            i++;
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            string s = i.ToString();
            Console.Write(s);
            Thread.Sleep(1000);

            for (int k = 0; k < s.Length; k++)
                Console.Write("\b \b");
        }
    }

    public void ClearCurrentLine()
    {
        Console.Write("\r" + new string(' ', 50) + "\r");
    }

}
