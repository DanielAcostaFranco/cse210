using System;
using System.Collections.Generic;
using System.Linq;

public class Quiz
{
    private string _quizTitle; 
    private List<Question> _questions;
    private int _timer;
    private int _points;

    public Quiz(string title, int timer = 0, int points = 10)
    {
        _quizTitle = title;
        _questions = new List<Question>();
        _timer = timer;
        _points = points;
    }
    
    public string GetQuizTitle()
    {
        return _quizTitle;
    }
    
    public List<Question> Questions
    {
        get { return _questions; }
    }

    public void AddQuestion(Question question)
    {
        _questions.Add(question);
    }

    public void RemoveQuestion(Question question)
    {
        _questions.Remove(question);
    }
}