using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_2
{
    public class MaxNumberSearcher
    {
        //<summary>
        //Recursive  method for finding biggest element in unsorted array
        //</summary>
        public int Seek(int[] array, int biggestNumber = Int32.MinValue, int counter = 0)
        {
            if(array.Length>counter)
            {
                return array[counter] > biggestNumber ? Seek(array,array[counter],counter+1) : Seek(array,biggestNumber,counter+1);
            }else
            {
                return biggestNumber;
            }
        }
    }
}
