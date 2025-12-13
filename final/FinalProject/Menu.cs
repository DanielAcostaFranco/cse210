using System;
using System.Collections.Generic;
using System.IO;

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
                PlayQuiz(); 
            }
            else if (choice == "3")
            {
                DisplayQuizzes();
            }
            else if (choice == "4")
            {
                Console.Write("Enter the file name to save (e.g., myquiz.txt): ");
                string fileName = Console.ReadLine();
                SaveQuiz(fileName);
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

    public void PlayQuiz()
    {
        if (_quizzes.Count == 0)
        {
            Console.WriteLine("\nNo quizzes available to play. Create or load one first.");
            return;
        }

        DisplayQuizzes();
        Console.Write("Enter the number of the quiz you want to play: ");
        
        if (int.TryParse(Console.ReadLine(), out int quizIndex) && quizIndex > 0 && quizIndex <= _quizzes.Count)
        {
            Quiz selectedQuiz = _quizzes[quizIndex - 1];
            CreateGame(selectedQuiz);
        }
        else
        {
            Console.WriteLine("Invalid quiz selection.");
        }
    }

    public void CreateGame(Quiz quiz)
    {
        Game game = new Game(quiz);
        game.StartGame();
    }

    public void CreateQuiz()
    {
        Console.WriteLine("\n--- Create New Quiz ---");
        Console.Write("Enter the title for the new quiz: ");
        string title = Console.ReadLine();
        
        Quiz newQuiz = new Quiz(title);
        
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nSelect a Question Type to Add:");
            Console.WriteLine("1. Short Answer");
            Console.WriteLine("2. True/False");
            Console.WriteLine("3. Multiple Choice");
            Console.WriteLine("4. Fill in the Blank");
            Console.WriteLine("5. Finish Adding Questions");
            Console.Write("Enter choice: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1") AddShortAnswer(newQuiz);
            else if (choice == "2") AddTrueFalse(newQuiz);
            else if (choice == "3") AddMultipleChoice(newQuiz);
            else if (choice == "4") AddFillInTheBlank(newQuiz);
            else if (choice == "5") running = false;
            else Console.WriteLine("Invalid choice.");
        }
        
        if (newQuiz.Questions.Count > 0)
        {
            _quizzes.Add(newQuiz);
            Console.WriteLine($"\nQuiz '{title}' created with {newQuiz.Questions.Count} questions.");
        }
        else
        {
            Console.WriteLine("\nQuiz creation cancelled (no questions added).");
        }
    }

    private void AddShortAnswer(Quiz quiz)
    {
        Console.Write("Enter the question: ");
        string desc = Console.ReadLine();
        Console.Write("Enter correct answer: ");
        string answer = Console.ReadLine();
        quiz.AddQuestion(new ShortAnswer(desc, answer, 10));
    }
    
    private void AddTrueFalse(Quiz quiz)
    {
        Console.Write("Enter the statement: ");
        string desc = Console.ReadLine();
        string answer;
        while (true)
        {
            Console.Write("Enter correct answer (True/False): ");
            answer = Console.ReadLine().ToLower().Trim();
            if (answer == "true" || answer == "false" || answer == "t" || answer == "f") break;
            Console.WriteLine("Invalid answer. Must be 'True' or 'False'.");
        }
        quiz.AddQuestion(new TrueFalse(desc, answer, 10));
    }
    
    private void AddMultipleChoice(Quiz quiz)
    {
        Console.Write("Enter the question: ");
        string desc = Console.ReadLine();
        
        List<string> options = new List<string>();
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Enter option {i}: ");
            options.Add(Console.ReadLine());
        }
        
        string correctAnswerText = "";
        while (true)
        {
            Console.Write("Enter the number of the correct option (1-4): ");
            if (int.TryParse(Console.ReadLine(), out int correctNum) && correctNum >= 1 && correctNum <= 4)
            {
                correctAnswerText = options[correctNum - 1];
                break;
            }
            Console.WriteLine("Invalid option number.");
        }
        
        quiz.AddQuestion(new MultipleChoice(desc, correctAnswerText, 15, options));
    }
    
    private void AddFillInTheBlank(Quiz quiz)
    {
        Console.Write("Enter statement text (use '_____' for the blank): ");
        string template = Console.ReadLine();
        Console.Write("Enter the correct word/phrase to fill the blank: ");
        string answer = Console.ReadLine();
        quiz.AddQuestion(new FillInTheBlank(template, answer, 10, template)); 
    }

    public void SaveQuiz(string fileName)
    {
        if (_quizzes.Count == 0)
        {
            Console.WriteLine("\nCannot save: No quizzes available.");
            return;
        }

        DisplayQuizzes();
        Console.Write("Enter the number of the quiz to save: ");
        
        if (!int.TryParse(Console.ReadLine(), out int quizIndex) || quizIndex <= 0 || quizIndex > _quizzes.Count)
        {
            Console.WriteLine("Invalid quiz selection.");
            return;
        }
        
        Quiz quizToSave = _quizzes[quizIndex - 1];
        
        try
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(quizToSave.GetQuizTitle());
            
                foreach (Question q in quizToSave.Questions)
                {
                    sw.WriteLine(q.Serialize());
                }
            }
            Console.WriteLine($"\nQuiz '{quizToSave.GetQuizTitle()}' saved successfully to {fileName} with {quizToSave.Questions.Count} questions.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during save: {ex.Message}");
        }
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

        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            if (lines.Length == 0)
            {
                Console.WriteLine($"File {fileName} is empty.");
                return;
            }
            
            string title = lines[0];
            Quiz loadedQuiz = new Quiz(title);
            
            for (int i = 1; i < lines.Length; i++)
            {
                Question q = DeserializeQuestion(lines[i]);
                if (q != null)
                {
                    loadedQuiz.AddQuestion(q);
                }
            }
            
            _quizzes.Add(loadedQuiz);
            Console.WriteLine($"\nQuiz '{title}' loaded successfully with {loadedQuiz.Questions.Count} questions.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during load: {ex.Message}");
        }
    }

    private Question DeserializeQuestion(string line)
    {
        string[] parts = line.Split('|');

        string type = parts[0];
        string description = parts[1];
        
        int points = int.Parse(parts[2]); 
        
        string rawAnswer = parts[3];
        
        if (type == "ShortAnswer")
        {
            return new ShortAnswer(description, rawAnswer, points);
        }
        else if (type == "TrueFalse")
        {
            return new TrueFalse(description, rawAnswer, points);
        }
        else if (type == "FillInTheBlank")
        {
            string template = parts[4];
            return new FillInTheBlank(description, rawAnswer, points, template);
        }
        else if (type == "MultipleChoice")
        {
            string optionsString = parts[4];
            string[] optionArray = optionsString.Split(';');
            List<string> options = new List<string>(optionArray);
            
            return new MultipleChoice(description, rawAnswer, points, options);
        }
        else
        {
            return null;
        }
    }

    public void DisplayQuizzes()
    {
        Console.WriteLine("\n--- Available Quizzes ---");
        if (_quizzes.Count == 0)
        {
            Console.WriteLine("No quizzes available.");
            return;
        }

        for (int i = 0; i < _quizzes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_quizzes[i].GetQuizTitle()} ({_quizzes[i].Questions.Count} questions)");
        }
    }
}