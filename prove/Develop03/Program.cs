using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = ScriptureLoader.LoadScriptures("scriptures.json");

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AllHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine();
                Console.WriteLine("All words are hidden");
                break;
            }
        }
    }
}