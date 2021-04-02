using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_2_2
{
    public class SortBySum:ISortMethod
    {
        /// <summary>
        /// Rule for method to sort by sum of elements
        /// </summary>
        struct ElemAndIndex
        {
            public int index;
            public double value;
        }
        public double[] Sort(double[,] array, bool isDesc, int row)
        {
            int column = array.Length / row;
            double[] result = new double[row];
            ElemAndIndex[] tempArray = new ElemAndIndex[row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    tempArray[i].value += array[i, j];
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
