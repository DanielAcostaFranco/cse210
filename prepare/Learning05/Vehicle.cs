using System.Xml.Serialization;

public class Vehicle
{
    private string _make;
    private string _model;
    private int _year;
    private int _tires;
    private string _color;

    public Vehicle(string make, string model, int year, int tires, string color)
    {
        _make = make;
        _model = model;
        _year = year;
        _tires = tires;
        _color = color;
    }

    public void GetBaseDescription()
    {
        Console.WriteLine($"This vehicle is a {_year} {_make} {_model} {_color} {_tires} tires.");
    }
}