public class Student : Person
{
    private string _name;

    private string _id;

    public Student(string name, string id) : base(name) // try to use base here at the constructor.  
    {
        _id = id;
    }
    public void Display()
    {
        string myName = GetName();
        Console.WriteLine($"Student: {myName} with id: {_id}");
    }
}
    