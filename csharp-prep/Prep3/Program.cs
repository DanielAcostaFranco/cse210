using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // int magic_number = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);


        Console.WriteLine("Enter a guess: ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magic_number)
        {
            if (guess > magic_number)
            {
                Console.WriteLine("Too high");
                Console.WriteLine("Enter a guess: ");
                guess = int.Parse(Console.ReadLine());
            }

            else if (guess < magic_number)
            {
                Console.WriteLine("Too low");
                Console.WriteLine("Enter a guess: ");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You guessed it! Yay");

        }
    }
}