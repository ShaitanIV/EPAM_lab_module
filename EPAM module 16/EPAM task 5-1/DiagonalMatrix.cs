using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_5_1
{
    public class DiagonalMatrix<T> : SymmetricMatrix<T> , IMatrix<T> 
    {
        public DiagonalMatrix(T[,] array):base(array)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    if (x != y && (dynamic)array[x, y] != (dynamic)default(T))
                        throw new Exception("Array element expect main diagonal must have default values");
                }
            }
        }

        public override T this[int x, int y]
        {
            get => base[x, y];
            set 
            {
                if (x == y)
                    Matrix[x, y] = value;
                else
                    Matrix[x, y] = default(T);
            }
        }

        public override void MatrixAdd(IMatrix<T> matrix)
        {
            if (matrix is DiagonalMatrix<T>)
                base.MatrixAdd(matrix);
        }
    }
}
