using System;

public class Listing : Activity
{
    private string[] _prompts = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "Who are some of your personal heroes?"
    };

    public Listing(string title, string description, string endMessage)
        : base(title, description, endMessage)
    {
    }

    public void Run()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        string prompt = _prompts[index];


        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" - {prompt}");

        Console.WriteLine("\nYou can start in...");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> list = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_seconds);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
        }


        Console.WriteLine($"\nYou listed {list.Count} item(s).");
    }
}
