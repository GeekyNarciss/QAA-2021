using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    public class Matrix
    {
        public int N { get; set; } = 0;
        public int M { get; set; } = 0;
        public int[,] matrixArray = new int[10, 10];
        public Matrix(int width, int height)
        {
            N = width;
            M = height;
        }

        public void Entrance()
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrixArray[i, j] = rand.Next(1, 10);
                    Console.Write($"{matrixArray[i, j]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}
