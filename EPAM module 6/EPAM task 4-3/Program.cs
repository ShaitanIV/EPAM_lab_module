using System;

namespace EPAM_task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p = new Polynomial(5);
            p[0] = 1;
            p[1] = 2;
            p[2] = 5;
            p[3] = 0;
            p[4] = -4;
            p[5] = 3;

            Console.WriteLine(p.ToString());
        }
    }
}
