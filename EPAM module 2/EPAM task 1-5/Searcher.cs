using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_5
{
    public class Searcher
    {
        ///<summary>
        ///Method for finding next number, consisting from the same digits
        ///If it's impossible return -1
        ///</summary>
        public int FindNextBiggerNumber(int NumberIn)
        {
            int result = -1;
            var targetedPosition = 0;
            char[] targetNumber = NumberIn.ToString().ToCharArray();

            // if number is not the biggest possible , we are searching for the next onr
            if (!IsBiggest(targetNumber, out targetedPosition))
            {
                // changing position of first two digits, which are ordered in descending way
                Swap(ref targetNumber[targetedPosition], ref targetNumber[targetedPosition - 1]);
                
                //sorting right part of the number in ascending way
                ArrayRearrangement(targetNumber, targetedPosition);

                string str = new string(targetNumber);
                result = int.Parse(str);
            }    
            return result;
        }

        bool IsBiggest(char[] targetNumber, out int targetedPosition)
        {
            var result = true;
            targetedPosition = 0;
            for (int i = targetNumber.Length - 1; i > 0; i--)
            {
                if ((int)targetNumber[i] > (int)targetNumber[i - 1])
                {
                    result = false;
                    targetedPosition = i;
                    break;
                }
            }
            return result;
        }

        void ArrayRearrangement(char[] targetNumber,int targetedPosition)
        {
            for (int i = targetNumber.Length - 2; i >= targetedPosition; i--)
            {
                for (int j = targetNumber.Length - 1; j > targetedPosition; j--)
                {
                    if (targetNumber[j] < targetNumber[j - 1])
                        Swap(ref targetNumber[j], ref targetNumber[j - 1]);
                }
            }
        }

        public void Swap(ref char first, ref char second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
