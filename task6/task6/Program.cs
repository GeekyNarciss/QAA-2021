using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(3, 4, 5);
            Console.WriteLine($"Стороны треугольника {tr.ShowInfo()}");
            Console.WriteLine($"Периметр равен {tr.Perimetr()}");
        }
    }
}
