public class TrueFalse : Question
{
    public TrueFalse(string title, string description, string rawAnswer, int points)
        : base(title, description, rawAnswer, points)
    {
    }

    public override void DisplayQuestion()
    {
        base.DisplayQuestionDetails();
        Console.WriteLine("Is this statement True or False? (T/F)");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        string normAnswer = userAnswer.ToLower().Trim();
        return normAnswer == _rawAnswer.ToLower() || (normAnswer == "t" && _rawAnswer.ToLower().StartsWith("t"));
    }
}