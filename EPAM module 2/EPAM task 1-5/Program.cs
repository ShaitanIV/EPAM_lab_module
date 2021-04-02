using System;

namespace EPAM_task_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 414;
            var searcher = new Searcher();
            Console.WriteLine(searcher.FindNextBiggerNumber(number));
        }
    }
}
