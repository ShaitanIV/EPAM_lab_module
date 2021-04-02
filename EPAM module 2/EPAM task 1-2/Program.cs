using System;

namespace EPAM_task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 3};
            var searcher = new MaxNumberSearcher();
            Console.WriteLine(searcher.Seek(array));
        }
    }
}
