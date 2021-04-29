using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    class DiagonalMatrix : Matrix
    {
        public int[,] diagonalMatrixArray = new int[10, 10];
        public DiagonalMatrix(int width, int height) : base(width, height) { }

        public void Entranse()
        {
            if (N == M)
            {
                for (int i = 0; i < N; i+=N)
                {
                    for (int j = 0; j < M; j+=M)
                    {

                    }
                }
            }
        }
        
    }
}
