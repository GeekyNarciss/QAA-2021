using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Truck : Vehicle
    {
        public bool HasATowHitch { get; set; } //наличие прицепного устройства

        public Truck(string type, string brand, double engineVolume, string fuel, int numberOfPassengers,
                    int liftingCapacity, int maxSpeed, int tankVolume, double fuelConsumption, bool hasATowHitch) :
                    base(type, brand, engineVolume, fuel, numberOfPassengers, liftingCapacity, maxSpeed, tankVolume, fuelConsumption)
        {
            HasATowHitch = hasATowHitch;
        }

        public override string GetFullInfo()
        {
            return base.GetFullInfo() + $", has a tow hitch: {HasATowHitch}";
        }
    }
}
