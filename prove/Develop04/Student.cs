public class Student
{
    private string _name;

    private string _id;

    public Student(string name, string id)
    {
        _name = name;
        _id = id;
    }

    public void Display()
    {
        Console.WriteLine($"Student: {_name} with id: {_id}");
    }
}


