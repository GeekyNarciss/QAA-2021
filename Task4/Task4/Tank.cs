using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Tank : Vehicle
    {
        public bool HasAGun { get; set; } //наличие оружия
        public string WheelsType { get; set; } //тип колес

        public Tank(string type, string brand, double engineVolume, string fuel, int numberOfPassengers,
                    int liftingCapacity, int maxSpeed, int tankVolume, double fuelConsumption, bool hasAGun, string wheelsType) :
                    base(type, brand, engineVolume, fuel, numberOfPassengers, liftingCapacity, maxSpeed, tankVolume, fuelConsumption)
        {            
            HasAGun = hasAGun;
            WheelsType = wheelsType;//"tracks"
        }

        public override string GetFullInfo()
        {
            return base.GetFullInfo() + $", has a weapon?: {HasAGun}, wheels type: {WheelsType}";
        }
    }
}
