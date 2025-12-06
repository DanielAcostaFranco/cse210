public abstract class Question
{
    protected string _title;
    protected string _description;
    protected string _rawAnswer;
    protected int _points;

    public Question(string title, string description, string rawAnswer, int points = 10)
    {
        _title = title;
        _description = description;
        _rawAnswer = rawAnswer;
        _points = points;
    }

    public string Title
    {
        get { return _title; }
    }
    
    public abstract void DisplayQuestion();
    public abstract bool CheckAnswer(string userAnswer);

    public virtual void DisplayQuestionDetails()
    {
        Console.WriteLine($"--- Question: {_title} ({_points} points) ---");
        Console.WriteLine(_description);
    }
}