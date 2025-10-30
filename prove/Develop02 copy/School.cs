using System;

public class School
{
    public int _numStudents;
    public int _numTeachers;
    public string _name;

    public System.Collections.Generic.List<Student> _student = new System.Collections.Generic.List<Student>();

    public void Register()
    {
        //do something
    }

    public void ShowDetails()
    {
        Console.WriteLine($"School: {_name} has {_numStudents} and {_numTeachers}. {_student}");
    }
}
