using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    abstract class Vehicle
    {
        /// <summary>
        /// тип тс
        /// </summary>
        public string Type { get; set; } = "";
        /// <summary>
        /// марка
        /// </summary>
        public string Brand { get; set; } = "";
        /// <summary>
        /// объем двигателя
        /// </summary>
        public double EngineVolume { get; set; } = 0;
        /// <summary>
        /// тип топлива
        /// </summary>
        public string Fuel { get; set; } = "";
        /// <summary>
        /// количество пассажиров
        /// </summary>
        public int NumberOfPassengers { get; set; } = 0;
        /// <summary>
        /// грузопоъемность
        /// </summary>
        public int LiftingCapacity { get; set; } = 100;
        /// <summary>
        /// максимальная скорость
        /// </summary>
        public double MaxSpeed { get; set; } = 0;
        /// <summary>
        /// объем бака
        /// </summary>
        public int TankVolume { get; set; } = 0;
        /// <summary>
        /// расход
        /// </summary>
        public double FuelConsumption { get; set; } = 0; 

        public Vehicle(string type, string brand, double engineVolume, string fuel, int numberOfPassengers,
                    int liftingCapacity, int maxSpeed, int tankVolume, double fuelConsumption)
        {
            Type = type;
            Brand = brand;
            EngineVolume = engineVolume;
            Fuel = fuel;
            NumberOfPassengers = numberOfPassengers;
            LiftingCapacity = liftingCapacity;
            MaxSpeed = maxSpeed;
            TankVolume = tankVolume;
            FuelConsumption = fuelConsumption;
        }

        public virtual string GetFullInfo()
        {
            string logString = $"{Type}: {Brand}, {EngineVolume}l, works on {Fuel}, people capacity: {NumberOfPassengers}," +
                                 $" lifting capacity: {LiftingCapacity}kg, max speed: {MaxSpeed}kmph, tank volume: {TankVolume}l," +
                                 $" fuel consumption: {FuelConsumption}lphk";           
            return logString;
        }
    }
}
