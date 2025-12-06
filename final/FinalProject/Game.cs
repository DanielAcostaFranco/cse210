using System;
using System.Collections.Generic;

public class Game
{
    private Quiz _quizPlayed;
    private int _currentScore;
    private int _currentQuestion;

    public Game(Quiz quiz)
    {
        _quizPlayed = quiz;
        _currentScore = 0;
        _currentQuestion = 0;
    }

    public void StartGame()
    {
        Console.WriteLine($"\n--- STARTING QUIZ: {_quizPlayed.GetQuizTitle()} ---");
        
        if (_quizPlayed.Questions.Count == 0)
        {
            Console.WriteLine("This quiz has no questions. Returning to menu.");
            return;
        }

        foreach (Question question in _quizPlayed.Questions)
        {
            NextQuestion();
            
            question.DisplayQuestion();
            
            Console.Write("Your input: ");
            string userAnswer = Console.ReadLine();

            if (CheckAnswer(question, userAnswer))
            {
                int pointsGained = 10; 
                _currentScore += pointsGained; 
                Console.WriteLine($"Correct! You earned {pointsGained} points.");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }
        
        DisplayResult();
    }

    public void NextQuestion()
    {
        _currentQuestion++;
        Console.WriteLine($"\n--- Question {_currentQuestion} of {_quizPlayed.Questions.Count} ---");
    }

    private bool CheckAnswer(Question question, string userAnswer)
    {
        return question.CheckAnswer(userAnswer);
    }

    public bool CheckAnswer(string userAnswer)
    {
        return true; 
    }

    public void DisplayResult()
    {
        Console.WriteLine("\n=============================");
        Console.WriteLine("       QUIZ FINISHED");
        Console.WriteLine("=============================");
        Console.WriteLine($"Quiz: {_quizPlayed.GetQuizTitle()}");
        Console.WriteLine($"Total Questions: {_quizPlayed.Questions.Count}");
        Console.WriteLine($"FINAL SCORE: {_currentScore} points!");
    }
}