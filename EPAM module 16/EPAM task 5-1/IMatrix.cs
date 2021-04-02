using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_5_1
{
    public interface IMatrix<T> 
    {
        public int GetSize();

        public T GetDeterminant();
        public void MatrixAdd(IMatrix<T> matrix);

        public T this[int x, int y] { get;set; }
    }
}
