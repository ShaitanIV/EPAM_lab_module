using System;

namespace EPAM_task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            int? a = 123;
            bool t = a.isNull();
            bool d = str.isNull();
            Console.WriteLine(d);
        }
    }
}
