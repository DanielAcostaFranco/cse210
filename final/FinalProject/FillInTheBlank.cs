public class FillInTheBlank : Question
{
    private string _templateText;

    public FillInTheBlank(string title, string description, string rawAnswer, int points, string templateText)
        : base(title, description, rawAnswer, points)
    {
        _templateText = templateText;
    }

    public override void DisplayQuestion()
    {
        base.DisplayQuestionDetails();
        string display = _templateText.Replace("[BLANK]", "____________________");
        Console.WriteLine(display);
        Console.Write("Fill in the blank: ");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return _rawAnswer.ToLower().Trim() == userAnswer.ToLower().Trim();
    }
}