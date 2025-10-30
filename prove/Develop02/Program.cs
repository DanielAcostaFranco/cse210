using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // I added a greeting according to the time of the day.
        Console.OutputEncoding = Encoding.UTF8;

        Journal journal = new Journal();
        journal.StartJournal();
    }
}
