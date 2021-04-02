using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_6
{
    public class Filter
    {
        /// <summary>
        /// Method for removing any nubmers in targeted array, which doesn't contain entered digit
        /// </summary>

        public int[] FilterDigit(int[] Array, int targetdigit)
        {
            int[] result = new int[ResultLenght(Array,targetdigit)];
            var counter = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if(IsMatched(Array[i],targetdigit))
                {
                    result[counter] = Array[i];
                    counter++;
                }
            }
            return result;
        }

        bool IsMatched(int targetNumber, int targetDigit)
        {
            var result = false;
            do
            {
                if (targetNumber % 10 == targetDigit)
                {
                    result = true;
                    break;
                }
                targetNumber = targetNumber / 10;
            }
            while (targetNumber % 10 != 0);

            return result;
        }
        int ResultLenght(int[] Array, int targetDigit)
        {
            int result = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (IsMatched(Array[i], targetDigit))
                    result++;

            }
            return result;
        }
    }
}
