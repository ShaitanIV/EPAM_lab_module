using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_1
{
    public class ConverterToInt
    {
        const int maxArrayLenght = 32;
        public int ToInt(int[] array)
        {
            var number = 0;
            for (int i = 0; i < maxArrayLenght; i++)
            {
                number += array[i] * (int)Math.Pow(2, i);
            }
            return number;
        }
    }
}
