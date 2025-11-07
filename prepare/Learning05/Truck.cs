public class Truck : Vehicle
{
    private string _bedsize;
    private string _cabtype;
    private string _gastype;

    public Truck(string bedsize, string cabtype, string gastype, string make, string model, int year, int tires, string color)
 : base(make, model, year, tires, color)
    {
        _bedsize = bedsize;
        _cabtype = cabtype;
        _gastype = gastype;

    }
    
    public void GetDescription()
    {
        GetBaseDescription();
        Console.WriteLine($"Truck bedsize: {_bedsize}, cabtype: {_cabtype}, gas type: {_gastype}.");
    }
 }
    