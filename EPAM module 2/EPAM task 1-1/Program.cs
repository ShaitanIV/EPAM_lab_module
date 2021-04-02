using System;

namespace EPAM_task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var unity = new StringUnite();
            int result = unity.Unite(8, 15, 3, 8);
            Console.WriteLine(result);

        }
    }
}
