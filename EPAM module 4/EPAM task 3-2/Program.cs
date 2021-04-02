using System;

namespace EPAM_task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GreatesCommonDivisor test = new GreatesCommonDivisor();
            int[] arr = { 8, 4, 16, 24,48 };

            int a = test.GCDCalculate(new GreatesCommonDivisor().Euclid, arr, false);
            int b = test.GCDCalculate(new GreatesCommonDivisor().EuclidBin, arr, false);
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
