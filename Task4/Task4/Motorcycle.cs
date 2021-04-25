using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Motorcycle : Vehicle
    {
        public bool HasAWheelChair { get; set; } //наличие коляски

        public Motorcycle(string type, string brand, double engineVolume, string fuel, int numberOfPassengers,
                    int liftingCapacity, int maxSpeed, int tankVolume, double fuelConsumption, bool  hasAWheelChair) :
                    base(type, brand, engineVolume, fuel, numberOfPassengers, liftingCapacity, maxSpeed, tankVolume, fuelConsumption)
        {
            HasAWheelChair = hasAWheelChair;
        }

        public override string GetFullInfo()
        {
            return base.GetFullInfo() + $", has a wheelchair?: {HasAWheelChair}";
        }
    }
}
