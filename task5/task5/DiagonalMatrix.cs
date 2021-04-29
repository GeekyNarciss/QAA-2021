namespace task5
{
    class DiagonalMatrix : Matrix
    {
        public DiagonalMatrix(int size) : base(size) 
        {
            MatrixArray = new int[size];
        }

        public override int this[int index1, int index2]
        {
            get
            {
                if (index1 == index2)
                    return MatrixArray[index1];
                else return 0;
            }
            set
            {
                if (index1 == index2)
                {
                    MatrixArray[index1] = value;
                }
            }
        }
    }
}
