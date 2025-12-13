using System;

public class TrueFalse : Question
{
    public TrueFalse(string description, string rawAnswer, int points)
        : base(description, rawAnswer, points)
    {
    }

    public override string GetInstructionHeader()
    {
        return "Choose if the statement is True or False:";
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"--- Question: {Title} ({Points} points) ---");
        Console.WriteLine(GetInstructionHeader());
        Console.WriteLine(Title);
        Console.WriteLine("[T]rue / [F]alse");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        string normAnswer = userAnswer.ToLower().Trim();
        string correct = GetRawAnswer().ToLower().Trim();
        return normAnswer == correct 
            || (normAnswer == "t" && correct.StartsWith("t"))
            || (normAnswer == "f" && correct.StartsWith("f"));
    }

    public override string Serialize()
    {
        return $"TrueFalse|{Title}|{Points}|{GetRawAnswer()}";
    }
}