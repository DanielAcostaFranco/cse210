using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    Prompts _prompts = new Prompts();

    public void StartJournal()
    {
        string menuresponse = "";

        while (menuresponse != "5")
        {
            Console.WriteLine();
            Console.WriteLine(Greeting());
            Console.WriteLine("Welcome to your journal Daniel:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            menuresponse = Console.ReadLine();

            if (menuresponse == "1")
            {
                WriteEntry();
            }
            else if (menuresponse == "2")
            {
                DisplayEntries();
            }
            else if (menuresponse == "3")
            {
                SaveToFile();
            }
            else if (menuresponse == "4")
            {
                LoadFromFile();
            }
            else if (menuresponse == "5")
            {
                Console.WriteLine("Good Bye");
            }
        }
    }

    void WriteEntry()
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string prompt = _prompts.randomPrompt() + " ";

        Console.WriteLine(date + "\nPrompt: " + prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = date;
        entry._prompt = prompt;
        entry._response = response;

        _entries.Add(entry);
    }

    void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine("[" + e._date + "] " + e._prompt);
            Console.WriteLine(e._response);
            Console.WriteLine();
        }
    }

    void SaveToFile()
    {
        Console.WriteLine("Enter file name:");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                file.WriteLine(e.ToLine());
            }
        }

        Console.WriteLine("You Journal was successfully saved, Daniel!");
    }

    void LoadFromFile()
    {
        Console.WriteLine("Enter file name to load:");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            Entry e = Entry.FromLine(line);
            _entries.Add(e);
        }
    }

    // I added a greeting according to the time of the day.
    string Greeting()
    {
        int h = DateTime.Now.Hour;
        if (h < 12) return "Good morning 🌞!";
        else if (h < 18) return "Good afternoon 🌅!";
        else return "Good evening 🌙!";
    }

}
