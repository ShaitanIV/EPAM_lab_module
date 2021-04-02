using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_5_1
{
    public class SquareMatrix<T> : IMatrix<T>
    {
        protected T[,] Matrix;
        public virtual T GetDeterminant()
        {
            throw new NotImplementedException();
        }

        public SquareMatrix(T[,] array )
        {
            if (array.GetLength(0) != array.GetLength(1))
                throw new Exception("Array height and width must be equal");
            Matrix = array;
        }

        public virtual T this[int x, int y] 
        {
            get
            {
                return Matrix[x, y];   
            } 
            set
            {
                Matrix[x, y] = value;
            }
        }

        public virtual int GetSize()
        {
            return (int)Math.Sqrt(Matrix.Length);
        }

        public virtual void MatrixAdd(IMatrix<T> matrix)
        {
            if(matrix is SquareMatrix<T> && matrix.GetSize()== this.GetSize())
            {
                for (int y = 0; y < this.GetSize(); y++)
                {
                    for (int x = 0; x < this.GetSize(); x++)
                    {
                        Matrix[x, y] = (dynamic)matrix[x, y] + (dynamic)Matrix[x,y];
                    }
                }
            }
        }

        public override bool Equals(object obj)
        {
            var compareobj = obj as SquareMatrix<T>;
            double tolerance = 0.001;
            if (compareobj == null || compareobj.Matrix.GetLength(0)!= this.Matrix.GetLength(0))
                return false;

            for (int x = 0; x < compareobj.Matrix.GetLength(0); x++)
            {
                for (int y = 0; y < compareobj.Matrix.GetLength(0); y++)
                {
                    if (Math.Abs((dynamic)this.Matrix[x, y] - (dynamic)compareobj.Matrix[x, y]) > tolerance)
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int x = 0; x < Matrix.GetLength(0); x++)
            {

                for (int y = 0; y < Matrix.GetLength(1); y++)
                {
                    result.Append($"{Matrix[x, y]}; ");
                }

                result.Append("\n");
            }

            return result.ToString();
        }
    }
}
