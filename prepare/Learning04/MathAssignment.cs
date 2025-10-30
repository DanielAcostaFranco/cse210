public class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public string GetHomeworkList()
    {
        return $"{_textbookSection}, {_problems}";
    }

    public void SetHomeworkList(string textbooksection, string problems)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }
    
    public string GetMathAssignment()
    {
        return $"{_studentName} - {_topic}\n{_textbookSection}  {_problems}";
    }

}