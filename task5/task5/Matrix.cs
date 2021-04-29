using System;

namespace task5
{
    public class Matrix
    {
        /// <summary>
        /// size for matrix
        /// </summary>
        public int Size { get; private set; } = 0;
        /// <summary>
        /// matrix array
        /// </summary>
        public int[] MatrixArray;
               
        /// <summary>
        /// made matrix filled 0
        /// </summary>
        /// <param name="size"></param>
        public Matrix(int size)
        {
            Size = size;
            int squareSize = size * size;
            MatrixArray = new int[squareSize];
            for (int i = 0; i < squareSize; i++)
            {
                MatrixArray[i] = 0;
            }
        }
        /// <summary>
        /// this definition
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
        public virtual int this[int index1, int index2]
        {
            get
            {
                return MatrixArray[index1 * Size + index2];
            }
            set
            {
                MatrixArray[index1 * Size + index2] = value;
            }
        }

        /// <summary>
        /// for random filling
        /// </summary>
        public void Entrance()
        {
            Random rand = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    this[i, j] = rand.Next(1, 10);
                    Console.Write($"{this[i, j]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}
