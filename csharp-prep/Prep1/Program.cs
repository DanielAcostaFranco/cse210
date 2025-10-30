using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        List<int> myList = new List<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(35);

        int count = myList.Count();

        Console.WriteLine($"The count is {count}");

        int total = 0;

        for (int i = 0; i < count; i++)
        {
            total = total + myList[i];
        }

        Console.WriteLine($"Total is {total}");

        float avg = total / (float)count;

        Console.WriteLine($"Average is {avg}");


    }
}



