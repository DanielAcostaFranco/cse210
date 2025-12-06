public class ShortAnswer : Question
{
    public ShortAnswer(string title, string description, string rawAnswer, int points)
        : base(title, description, rawAnswer, points)
    {
    }

    public override void DisplayQuestion()
    {
        base.DisplayQuestionDetails();
        Console.Write("Your answer: ");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return _rawAnswer.ToLower().Trim() == userAnswer.ToLower().Trim();
    }
}