using System;
using System.Collections.Generic;
using System.Linq;

public class MultipleChoice : Question
{
    private List<string> _options;

    public MultipleChoice(string description, string rawAnswer, int points, List<string> options)
        : base(description, rawAnswer, points)
    {
        _options = options;
    }
    
    protected override string GetInstructionHeader()
    {
        return "Select the correct option number:";
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"--- Question: {Title} ({_points} points) ---");
        Console.WriteLine(GetInstructionHeader());
        Console.WriteLine(_description);
        
        for (int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }
    }

    public override bool CheckAnswer(string userAnswer)
    {
        if (int.TryParse(userAnswer, out int userChoice) && userChoice > 0 && userChoice <= _options.Count)
        {
            return _options[userChoice - 1].ToLower() == _rawAnswer.ToLower();
        }
        
        return _rawAnswer.ToLower().Trim() == userAnswer.ToLower().Trim();
    }
    
    public override string Serialize()
    {
        string optionsData = string.Join(";", _options);
        return $"MultipleChoice|{Title}|{_points}|{_rawAnswer}|{optionsData}";
    }
}