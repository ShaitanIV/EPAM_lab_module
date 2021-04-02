using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_5_1
{
    public class SymmetricMatrix<T> : SquareMatrix<T>, IMatrix<T>
    {
        public SymmetricMatrix(T[,] array) : base(array)
        {
            for (int x = 0; x < array.GetLength(0) - 1; x++)
            {
                for (int y = x + 1; y < array.GetLength(1); y++)
                {
                    if ((dynamic)array[x, y] != (dynamic)array[y, x])
                        throw new Exception("Array must be symmetrical to the main diagonal");

                }
            }
        }
        public override T this [int x, int y]
        {
            get
            {
                return Matrix[x, y];
            }
            set 
            {
                Matrix[x, y] = value;
                Matrix[y, x] = value;
            }
        }

        public override void MatrixAdd(IMatrix<T> matrix)
        {
            if (matrix is SymmetricMatrix<T>)
                base.MatrixAdd(matrix);
        }
    }
}
