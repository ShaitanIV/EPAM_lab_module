using System;

namespace EPAM_task_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculation();
            Console.WriteLine(calc.SummaryOfTwoDoubles("1234,3","1234,5"));
        }
    }
}
