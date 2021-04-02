using System;

namespace EPAM_task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortByMax max = new SortByMax();
            SortByMin min = new SortByMin();
            SortBySum sum = new SortBySum();
            ArraySorter sort = new ArraySorter();
            sort.SelectMethod(sum);
            double[,] array = { { 21, 242, 3 }, { 4, 3215, 6 }, { 0, 12, 52 } };
            double[,] truearray = sort.Sort(true, array, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(truearray[i, j]);
                    Console.Write(";");
                }
                Console.WriteLine();
            }
        }
    }
}
