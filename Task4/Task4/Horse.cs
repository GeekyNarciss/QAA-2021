using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Horse : IMovable
    {
        public string Type { get; set; } = "";

        public Horse(string type) 
        {
            Type = type;
        }

        public void Move()
        {
            Console.Write("Horse is running");
        }
    }
}
