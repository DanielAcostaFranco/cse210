using System;

public class Reflection : Activity
{
    private string[] _prompts =
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };

    private string[] _questions =
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };

    public Reflection(string title, string description, string endMessage)
        : base(title, description, endMessage)
    {
    }
        public void Run()
        {
        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        int index = random.Next(_prompts.Length);
        string prompt = _prompts[index];
        Console.WriteLine("> " + prompt);

        Console.WriteLine("\nWhen you have something in mind, press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions:");
        ShowSpinner(2);

        int elapsed = 0;
        while (elapsed < _seconds)
        {
        int q = random.Next(_questions.Length);
        string question = _questions[index];
        Console.WriteLine();
        Console.Write("- " + question + " ");
        ShowSpinner(5);
        elapsed += 5;
    }
        Console.WriteLine();
    }
}
