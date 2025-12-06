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
        // something again.. :) Hi Maddie or brother Tuck! :) 
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return _rawAnswer.ToLower().Trim() == userAnswer.ToLower().Trim();
    }
}