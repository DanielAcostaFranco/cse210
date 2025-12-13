using System;

public class FillInTheBlank : Question
{
    private string _templateText;

    public FillInTheBlank(string description, string rawAnswer, int points, string templateText)
        : base(description, rawAnswer, points)
    {
        _templateText = templateText;
    }

    protected override string GetInstructionHeader()
    {
        return "Fill in the blank space:";
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"--- Question: {Title} ({_points} points) ---");
        Console.WriteLine(GetInstructionHeader());
        
        string formattedText = _templateText.Replace("_____", "(___BLANK___)");
        Console.WriteLine(formattedText);
        Console.WriteLine("Type your word/phrase below:");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        string normalizedRawAnswer = _rawAnswer.ToLower().Trim();
        string normalizedUserAnswer = userAnswer.ToLower().Trim();
        
        return normalizedRawAnswer == normalizedUserAnswer;
    }
    
    public override string Serialize()
    {
        return $"FillInTheBlank|{Title}|{_points}|{_rawAnswer}|{_templateText}";
    }
}