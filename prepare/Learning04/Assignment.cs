public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public string getStudent()
    {
        return _studentName;
    }
    public void setStudent(string studentName)
    {
        _studentName = studentName;
    }
    public string getTopic()
    {
        return _topic;
    }
    public void setTopic(string topic)
    {
        _topic = topic;
    }
        public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}