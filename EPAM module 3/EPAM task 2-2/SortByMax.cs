using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_2_2
{
    public class SortByMax : ISortMethod
    {
        struct ElemAndIndex
        {
            public int index;
            public double value;
        }

        /// <summary>
        /// Rule for sorting method, to sort by max element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="isDesc"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public double[] Sort(double[,] array, bool isDesc, int row)
        {
            int column = array.Length / row;
            double[] result = new double[row];
            ElemAndIndex[] tempArray = new ElemAndIndex[row];

            for (int i = 0; i < row; i++)
            {
                tempArray[i].value = array[i, 0];
                for (int j = 1; j < column; j++)
                {
                    if (tempArray[i].value < array[i, j])
                        tempArray[i].value = array[i, j];
                }
                tempArray[i].index = i;
            }

            if(isDesc)
            for (int i = 1; i < row; i++)
                for (int j = 0; j < row - i; j++)
                {
                    if (tempArray[j].value < tempArray[j + 1].value)
                    {
                        var temp = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = temp;
                    }
                }
            else
                for (int i = 1; i < row; i++)
                    for (int j = 0; j < row - i; j++)
                    {
                        if (tempArray[j].value > tempArray[j + 1].value)
                        {
                            var temp = tempArray[j];
                            tempArray[j] = tempArray[j + 1];
                            tempArray[j + 1] = temp;
                        }
                    }

            for (int i = 0; i < row; i++)
            {
                result[i] = tempArray[i].index;
                Console.Write(result[i]);
                Console.WriteLine(tempArray[i].value);
            }
            return result;
        }
    }
}