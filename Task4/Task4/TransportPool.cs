using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class TransportPool
    {
        private int PoolSize;
        private Vehicle[] vehicles = null;
        private int Counter = 0;

        public TransportPool(int size)
        {
            PoolSize = size;
            vehicles = new Vehicle[size];
        }

        public void AddVehicleToPool(Vehicle vehicle)
        {
            if (Counter < PoolSize)
            {
                vehicles[Counter] = vehicle;
                Counter++;
            }
            else 
            {
                Console.WriteLine("Garage is full");
            }
        }

        public void PrintInfoAboutAllVehicles()
        {
            for (int i = 0; i < Counter; i++)
            {
                Console.WriteLine(vehicles[i].GetFullInfo());
            }
            
        }
    }
}
