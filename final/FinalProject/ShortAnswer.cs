using System;

public class ShortAnswer : Question
{
    public ShortAnswer(string description, string rawAnswer, int points)
        : base(description, rawAnswer, points)
    {
    }
    
    protected override string GetInstructionHeader()
    {
        return "Answer the following question briefly:";
    }

    public override void DisplayQuestion()
    {
       Console.WriteLine($"--- Question: {Title} ({_points} points) ---");
       Console.WriteLine(GetInstructionHeader());
       Console.WriteLine(_description);
       Console.WriteLine("Type your answer below:");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        string normalizedRawAnswer = _rawAnswer.ToLower().Trim();
        string normalizedUserAnswer = userAnswer.ToLower().Trim();
        
        return normalizedRawAnswer == normalizedUserAnswer;
    }

    public override string Serialize()
    {
        return $"ShortAnswer|{Title}|{_points}|{_rawAnswer}";
    }
}