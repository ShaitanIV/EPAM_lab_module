using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_2_2
{
    public interface ISortMethod
    {
        public double[] Sort(double[,] array, bool isDesc, int row);
    }
}
