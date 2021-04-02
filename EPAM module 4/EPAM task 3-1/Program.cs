using System;

namespace EPAM_task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://math.semestr.ru/inf/ieee754.php
            double a = 4294967295.0;
            double b = 0.0;
            Console.Write(a.ToIEEE754());
        }
    }
}
