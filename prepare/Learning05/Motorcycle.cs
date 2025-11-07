public class Motorcycle : Vehicle
{
    private string _seattype;
    private string _engine;
    private bool _hassidecar;

    public Motorcycle(string seattype, string engine, bool hassidecar, string make, string model, int year, int tires, string color)
 : base(make, model, year, tires, color)
    {
        _seattype = seattype;
        _engine = engine;
        _hassidecar = hassidecar;

    }
    
    public void GetDescription()
    {
        GetBaseDescription();
        Console.WriteLine($"Motorcycle seat: {_seattype}, engine: {_engine}, has side car: {_hassidecar}.");
    }
 }