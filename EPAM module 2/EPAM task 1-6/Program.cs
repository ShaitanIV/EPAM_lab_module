using System;

namespace EPAM_task_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 7;
            int[] array = new int[8] { 1, 7, 17, 23, 56, 87, 79, 178567 };
            var searcher = new Filter();
            int[] result = searcher.FilterDigit(array, number);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }


        }
    }
}
