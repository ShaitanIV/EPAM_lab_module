using System;

namespace EPAM_task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 1,2,3};
            var searcher = new ElementSearcher();
            Console.WriteLine(searcher.GoldenMiddle(array));
        }
    }
}
