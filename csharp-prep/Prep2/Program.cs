using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score?");
        int score = int.Parse(Console.ReadLine());

        /*Another way to do it is
        string to int=

        string example = ConsoleL.ReadLilne();
        int x =int.Parse(example);

        int to string = 
        string example2 = example2.ToString();

        */
        string letter;

        if (score >= 90)
        {
            //Console.WriteLine("Your grade letter is A");
            letter = "A";
        }

        else if (score >= 80)
        {
            //Console.WriteLine("Your grade letter is B");
            letter = "B";
        }

        else if (score >= 70)
        {
            //Console.WriteLine("Your grade letter is C");
            letter = "C";
        }

        else if (score >= 60)
        {
            //Console.WriteLine("Your grade letter is D");
            letter = "D";
        }

        else
        {
            //Console.WriteLine("Your grade letter is F");
            letter = "F";
        }

        Console.WriteLine($"Your grade letter is {letter}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations, you passed the class");
        }

        else
        {
            Console.WriteLine("You will need to take this course again.");
        }




    }
}


/*This are the 4 phases to save changes in the remote repo
File system
Staging
Local Repo
Remote Repo

<file>
git add . or /path or file name
git command -m "A explicit comment about the changes"
git push


USEFUL TIPS:

&& is and 
|| is or 
one equal = is for assigning variables
two equals == is comparison

for loops: 

while
    Example:    
        while (condition here);
        {
        }

for 
    Example:
        for(int i=o, i>5; i++);
        {
        Console.WriteLine();
        }

dowhile: here, the program do something before checking the  condition. At least the first time.
    Example:
    


foreach



*/