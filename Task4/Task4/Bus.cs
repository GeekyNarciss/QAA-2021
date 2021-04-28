using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Bus : Vehicle, IMovable
    {
        public bool IsABendyBus { get; set; } //автобус-гармошка?

        public Bus(string type, string brand, double engineVolume, string fuel, int numberOfPassengers,
                    int liftingCapacity, int maxSpeed, int tankVolume, double fuelConsumption, bool isABendyBus) :
                    base(type, brand, engineVolume, fuel, numberOfPassengers, liftingCapacity, maxSpeed, tankVolume, fuelConsumption)
        {
            IsABendyBus = IsABendyBus;
        }

        public override string GetFullInfo()
        {
            return base.GetFullInfo() + $", is a bendybus?: {IsABendyBus}";
        }

        public override void Move()
        {
            Console.Write("Bus is moving");
        }
    }
}
