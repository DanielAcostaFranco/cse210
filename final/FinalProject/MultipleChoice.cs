public class MultipleChoice : Question
{
    private List<string> _options;

    public MultipleChoice(string title, string description, string rawAnswer, int points, List<string> options)
        : base(title, description, rawAnswer, points)
    {
        _options = options;
    }

    public override void DisplayQuestion()
    {
        base.DisplayQuestionDetails();
        Console.WriteLine("Options:");
        for (int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_options[i]}");
        }
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return _rawAnswer.ToLower() == userAnswer.ToLower();
    }
}