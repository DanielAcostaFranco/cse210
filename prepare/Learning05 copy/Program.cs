using System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle("Nissan", "Altima", 2019, 4, "Red");
        {
            vehicle1.GetBaseDescription();
        }

        Truck truck1 = new Truck("20 feet", "Med-Cab", "Diesel", "Tesla", "F12387", 2019, 9, "Silver");
        {
            truck1.GetDescription();
        }
    }


}