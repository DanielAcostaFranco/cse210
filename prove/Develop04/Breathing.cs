using System;

public class Breathing : Activity
{
    public Breathing(string title, string description, string endMessage)
        : base(title, description, endMessage)
    {
    }

    public void Run()
    {
        int elapsed = 0;

        while (elapsed < _seconds)
        {
            Console.WriteLine();
            ClearCurrentLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            elapsed += 4;
            if (elapsed >= _seconds) break;

            ClearCurrentLine();
            Console.Write("Breathe out... ");
            ShowCountdown(4);
            elapsed += 4;
        }
        Console.WriteLine();
    }
}
