using System;

public class ShortAnswer : Question
{
    public ShortAnswer(string description, string rawAnswer, int points)
        : base(description, rawAnswer, points)
    {
    }

    public override string GetInstructionHeader()
    {
        return "Answer the following question briefly:";
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"--- Question: {Title} ({Points} points) ---");
        Console.WriteLine(GetInstructionHeader());
        Console.WriteLine(Title);
        Console.WriteLine("Type your answer below:");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return GetRawAnswer().ToLower().Trim() == userAnswer.ToLower().Trim();
    }

    public override string Serialize()
    {
        return $"ShortAnswer|{Title}|{Points}|{GetRawAnswer()}";
    }
}