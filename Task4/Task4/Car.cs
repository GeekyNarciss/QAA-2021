using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Car : Vehicle
    {
        public string GearBox { get; set; } //тип коробки передач

        public Car(string type, string brand, double engineVolume, string fuel, int numberOfPassengers,
                    int liftingCapacity, int maxSpeed, int tankVolume, double fuelConsumption, string gearBox): 
                    base(type, brand, engineVolume, fuel, numberOfPassengers, liftingCapacity, maxSpeed, tankVolume, fuelConsumption)
        {
            GearBox = gearBox;            
        }
        
        public override string GetFullInfo()
        {
            string logString = $"{Type}: {Brand}, {EngineVolume}l, works on {Fuel}, people capacity: {NumberOfPassengers}," +
                                $" lifting capacity: {LiftingCapacity}kg, max speed: {MaxSpeed}kmph, tank volume: {TankVolume}l," +
                                $" fuel consumption: {FuelConsumption}lphk, gearbox: {GearBox}";
            return logString;            
        }
    }
}
