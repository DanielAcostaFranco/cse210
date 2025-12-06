using System;
using System.Collections.Generic;
using System.IO; // Necesario para SaveQuiz y LoadQuiz

public class Menu
{
    private int _points;
    private List<Quiz> _quizzes = new List<Quiz>();

    public Menu()
    {
        _points = 0;
    }

    public void MenuLoop()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n");
            Console.WriteLine("     Welcome to Dahoot!");
            Console.WriteLine("");
            Console.WriteLine("1. Create New Quiz");
            Console.WriteLine("2. Play a Quiz");
            Console.WriteLine("3. Display Available Quizzes");
            Console.WriteLine("4. Save Quiz");
            Console.WriteLine("5. Load Quiz");
            Console.WriteLine("6. Exit Application");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                CreateQuiz();
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nStarting game...");
                CreateGame(new Quiz("New Quiz")); 
            }
            else if (choice == "3")
            {
                DisplayQuizzes();
            }
            else if (choice == "4")
            {
                SaveQuiz("test.txt");
            }
            else if (choice == "5")
            {
                LoadQuiz();
            }
            else if (choice == "6")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
            }
        }
    }

    public void CreateGame(Quiz quiz)
    {
        Console.WriteLine($"\nCreate game");
    }

    public void CreateQuiz()
    {
        Console.WriteLine("\nCreate quiz.");
        Console.Write("Enter the title for the new quiz: ");
        string title = Console.ReadLine();
        
        Quiz newQuiz = new Quiz(title);
        _quizzes.Add(newQuiz);
        
        Console.WriteLine($"Quiz '{title}' created and ready.");
    }

    public void SaveQuiz(string fileName)
    {
        if (_quizzes.Count == 0)
        {
            Console.WriteLine("\nCannot save: No quizzes available.");
            return;
        }

        string quizTitle = _quizzes[0].GetQuizTitle();
        System.IO.File.WriteAllText(fileName, quizTitle);
        Console.WriteLine($"\nQuiz '{quizTitle}' saved successfully to {fileName}.");
    }

    public void LoadQuiz()
    {
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        if (!System.IO.File.Exists(fileName))
        {
            Console.WriteLine($"\nCannot load: File {fileName} not found.");
            return;
        }

        string title = System.IO.File.ReadAllText(fileName);
        Quiz loadedQuiz = new Quiz(title);
        _quizzes.Add(loadedQuiz);
        Console.WriteLine($"\nQuiz '{title}' loaded succesfully.");
    }
    public void DisplayQuizzes()
    {
        Console.WriteLine("\nDisplay quizzes.");
    }
}