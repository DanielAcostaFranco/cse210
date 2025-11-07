using System.Data;

public class Course
{
    private string _number;

    private int _begTime;

    private int _endTime;

    private string _days { get; set;}

    public Course(string number, int begTime, int endTime, string days)
    {
        _number = number;
        _begTime = begTime;
        _endTime = endTime;
        _days = days;
    }

    public void UpdateDays(string days)
    {
        if (days.Count() > 0)
        {
            _days = days;
        }
    }
    

    public void Display()
    {
        Console.WriteLine($"Course: {_number} on days: {_days}.");
    }

}