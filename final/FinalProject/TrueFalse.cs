using System;

public class TrueFalse : Question
{
    public TrueFalse(string description, string rawAnswer, int points)
        : base(description, rawAnswer, points)
    {
    }

    protected override string GetInstructionHeader()
    {
        return "Choose if the statement is True or False:";
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"--- Question: {Title} ({_points} points) ---");
        Console.WriteLine(GetInstructionHeader());
        Console.WriteLine(_description);
        Console.WriteLine("[T]rue / [F]alse");
    }

    public override bool CheckAnswer(string userAnswer)
    {
        string normAnswer = userAnswer.ToLower().Trim();
        return normAnswer == _rawAnswer.ToLower().Trim() 
            || (normAnswer == "t" && _rawAnswer.ToLower().StartsWith("t"))
            || (normAnswer == "f" && _rawAnswer.ToLower().StartsWith("f"));
    }
    
    public override string Serialize()
    {
        return $"TrueFalse|{Title}|{_points}|{_rawAnswer}";
    }
}