using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3);
            matrix1.Entrance();

            DiagonalMatrix matrix2 = new DiagonalMatrix(3);
            matrix2.Entrance();
        }
    }
}
