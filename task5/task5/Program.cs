using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {              
                int size = 0;

                Matrix matrix1 = new Matrix(size);
                matrix1.Entrance();
                Console.WriteLine();

                DiagonalMatrix matrix2 = new DiagonalMatrix(size);
                matrix2.Entrance();
                Console.WriteLine();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
