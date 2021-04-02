using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_8
{
    public static class BinarySearch 
    {
        public static int Search<T>(T[] array, T targetElement) where T:IComparable
        {
            if (array==null)
            {
                throw new NullReferenceException();
            }
            if(array.Length==0)
            {
                throw new ArgumentException();
            }    
            int leftIndex = 0;
            int rightIndex = array.Length-1;

            if (array[leftIndex].CompareTo(targetElement) == 0)
                return leftIndex;
            else if (array[rightIndex].CompareTo(targetElement) == 0)
                return rightIndex;
            else
            {
                while (leftIndex <= rightIndex)
                {
                    int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                    if (array[middleIndex].CompareTo(targetElement) == 0)
                        return middleIndex;
                    else if (array[middleIndex].CompareTo(targetElement) < 0)
                        leftIndex = middleIndex + 1;
                    else
                        rightIndex = middleIndex - 1;
                }
            }

            return -1;
        }

    }
}
