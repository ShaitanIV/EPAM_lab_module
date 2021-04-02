using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_3
{
    public class ElementSearcher
    {
        //<summary>
        //Method for finding index of element for which sum of elements on the left and sum of elements on the right are equal
        //</summary>
        public int GoldenMiddle(double[] Array)
        {
            const double acc = 0.0001;
            int result=-1;
            var leftsum = 0.0;
            var rightsum = 0.0;

            for (int i = 1; i < Array.Length-1; i++)
            {
                SumOfBothSides(Array, i, out rightsum, out leftsum);

                if(Math.Abs(leftsum-rightsum)<acc)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        //<summary>
        //Method for finding sum of elements on the left and sum of elements on the right 
        //</summary>
        void SumOfBothSides(double[]arr,int pointer, out double rightsum, out double leftsum)
        {
            leftsum = 0.0;
            rightsum = 0.0;

            for (int j = 0; j < pointer; j++)
            {
                leftsum += arr[j];
            }

            for (int j = pointer+1; j < arr.Length; j++)
            {
                rightsum += arr[j];
            }
        }
    }
}
