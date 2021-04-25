using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //type, brand, engine volume, type of fuel, number of passengers, lifting capacity, max speed, tank volume, fuel consumption
            TransportPool Garage = new TransportPool(5);
            
            Garage.AddVehicleToPool(new Car("Car", "VW", 1.4, "Gas", 4, 2000, 220, 65, 7.8, "automatic"));
            Garage.AddVehicleToPool(new Bus("Bus", "MAZ", 9, "Diesel", 100, 12000, 90, 480, 18.2, true));
            Garage.PrintInfoAboutAllVehicles();
        }
    }
}
