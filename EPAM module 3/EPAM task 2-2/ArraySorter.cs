using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_2_2
{
    public class ArraySorter
    {
        ISortMethod Method;

        public void SelectMethod(ISortMethod method)
        {
            Method = method;
        }

        /// <summary>
        /// Method for sorting 2-dimensional array by chosed rules
        /// </summary>
        /// <param name="isDesc"></param>
        /// <param name="array"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public double[,] Sort(bool isDesc, double[,] array, int row)
        {
            double[] arrayHelper = Method.Sort(array,isDesc,row);
            var column = array.Length / row;
            double[,] result = new double[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = array[(int)arrayHelper[i], j];
                }
            }
            return result;
        }

    }
}
