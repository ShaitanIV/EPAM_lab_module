using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EPAM_task_3_2
{
    public delegate int calculationMethod(int[] array, bool timer);
    public class GreatesCommonDivisor
    {
        public int GCDCalculate(calculationMethod method, int[] array, bool timer)
        {
            return method(array, timer);
        }
        public int Euclid(int[] trueArray, bool timer)
        {
            DateTime timeStart = DateTime.Now;
            int[] temparr = new int[trueArray.Length];
            Array.Copy(trueArray, temparr, trueArray.Length);

            for (int i = 0; i < temparr.Length - 1; i++)
            {
                temparr[i + 1] = EuclidFor2(temparr[i], temparr[i + 1]);
            }

            if (timer)
                ExecTime(timeStart);

            return temparr[temparr.Length - 1];
        }

        public int EuclidBin(int[] trueArray, bool timer)
        {
            DateTime timeStart = DateTime.Now;
            int[] temparr = new int[trueArray.Length];
            Array.Copy(trueArray, temparr, trueArray.Length);

            for (int i = 0; i < temparr.Length - 1; i++)
            {
                temparr[i + 1] = EuclidBinFor2(temparr[i], temparr[i + 1]);
            }

            if (timer)
                ExecTime(timeStart);

            return temparr[temparr.Length - 1];
        }

        int EuclidBinFor2(int firstNumber, int secondNumber)
        {


            if (firstNumber == 0 || firstNumber == secondNumber)
                return secondNumber;

            else if (secondNumber == 0)
                return firstNumber;

            else if (firstNumber == 1 || secondNumber == 1)
                return 1;

            else if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                return 2 * EuclidBinFor2(firstNumber >> 1, secondNumber >> 1);

            else if (firstNumber % 2 == 0)
                return EuclidBinFor2(firstNumber >> 1, secondNumber);

            else if (secondNumber % 2 == 0)
                return EuclidBinFor2(firstNumber, secondNumber >> 1);

            else if (firstNumber > secondNumber)
                return EuclidBinFor2((firstNumber - secondNumber) / 2, secondNumber);

            else
                return EuclidBinFor2((secondNumber - firstNumber) / 2, firstNumber);

        }

        int EuclidFor2(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                var temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            while (firstNumber != 0 && secondNumber != 0 && firstNumber % secondNumber != 0)
            {
                var temp = firstNumber / secondNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            return secondNumber!=0?secondNumber:1;
        }

        void ExecTime(DateTime start)
        {
            System.TimeSpan timeToExecute = DateTime.Now - start;
            Console.WriteLine($"The programm was completed in { timeToExecute.Hours} hours {timeToExecute.Minutes}" +
                $" minutes {timeToExecute.Seconds} seconds {timeToExecute.Milliseconds} milliseconds");
        }
    }
}
