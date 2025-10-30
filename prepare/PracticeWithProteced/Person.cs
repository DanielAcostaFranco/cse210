using System;

public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    protected string GetName()
    {
        return _name;
    }

}