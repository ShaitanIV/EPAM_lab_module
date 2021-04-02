using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_2_1
{
    public class RootFinder
    {
        /// <summary>
        /// Method for finding n'th root based on Newton alghorithm
        /// </summary>
        /// <param name="targetNumber"></param>
        /// <param name="power"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public double NewtonMethod(double targetNumber, int power, double accuracy)
        {
            var result=1.0;
            var x0 = targetNumber/power;
            var x1= (1.0 / power) * ((power - 1) * x0 + targetNumber / Pow(power - 1, targetNumber));

            while (Math.Abs(x1 - x0) > accuracy) 
            {
                x0 = x1;
                x1 = (1.0 / power) * ((power - 1) * x0 + targetNumber / Pow(power - 1, x0));
            }
             
            result = Math.Round(x1,(int)Math.Abs(Math.Log10(accuracy)));
            return result;
        }

        //Method for raising number to a power pow
        double Pow(int pow, double targetNum)
        {
            var result = 1.0;
            if (pow > 0)
                for (int i = 0; i < pow; i++)
                {
                    result *= targetNum;
                }
            else if (pow < 0)
            {
                pow *= -1;
                for (int i = 0; i < pow; i++)
                {
                    result *= targetNum;
                }

                result = 1 / result;
            }

            return result;
        }
    }
}
