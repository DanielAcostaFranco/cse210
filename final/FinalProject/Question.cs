using System;

public abstract class Question
{
    private string _description;
    private string _rawAnswer;
    private int _points;

    public Question(string description, string rawAnswer, int points = 10)
    {
        _description = description;
        _rawAnswer = rawAnswer;
        _points = points;
    }

    public string Title => _description;
    public int Points => _points;

    public virtual string GetInstructionHeader()
    {
        return "Complete the following task:";
    }

    public string GetRawAnswer()
    {
        return _rawAnswer;
    }

    public abstract void DisplayQuestion();
    public abstract bool CheckAnswer(string userAnswer);
    public abstract string Serialize();
}