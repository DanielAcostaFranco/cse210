public class Car : Vehicle
{
    private string _trunk;
    private string _towHitch;
    private bool _fuelType;

   public Car(string trunk, string towHitch, bool fuelType, string make, string model, int year, int tires, string color)
: base(make, model, year, tires, color)
   {
      _fuelType = fuelType;
      _trunk = trunk;
      _towHitch = towHitch;
        
    }
 }