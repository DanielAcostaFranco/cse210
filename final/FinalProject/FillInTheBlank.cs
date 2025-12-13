using System;

public class FillInTheBlank : Question
{
    private string _templateText;

    public FillInTheBlank(string description, string rawAnswer, int points, string templateText)
        : base(description, rawAnswer, points)
    {
        _templateText = templateText;
    }

    public override string GetInstructionHeader()
    {
        return "Fill in the blank space:";
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"--- Question: {Title} ({Points} points) ---");
        Console.WriteLine(GetInstructionHeader());
        
        string formattedText = _templateText.Replace("_____", "(___BLANK___)");
        Console.WriteLine(formattedText);
        Console.WriteLine("Type your word/phrase below:");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return GetRawAnswer().ToLower().Trim() == userAnswer.ToLower().Trim();
    }

    public override string Serialize()
    {
        return $"FillInTheBlank|{Title}|{Points}|{GetRawAnswer()}|{_templateText}";
    }
}