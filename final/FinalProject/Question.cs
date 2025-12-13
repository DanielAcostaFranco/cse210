using System;

public abstract class Question
{
    protected string _description;
    protected string _rawAnswer;
    protected int _points;

    public Question(string description, string rawAnswer, int points = 10)
    {
        _description = description;
        _rawAnswer = rawAnswer;
        _points = points;
    }

    public string Title 
    {
        get { return _description; }
    }
    
    public int Points
    {
        get { return _points; }
    }
    
    protected virtual string GetInstructionHeader()
    {
        return "Complete the following task:";
    }

    public abstract void DisplayQuestion(); 
    
    public abstract bool CheckAnswer(string userAnswer);

    public abstract string Serialize(); 
}