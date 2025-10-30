public class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        return _title;
    }

    public void SetWritingInformation(string title)
    {
        _title = title;
    }
    
    public string GetWritingAssignment()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }

}