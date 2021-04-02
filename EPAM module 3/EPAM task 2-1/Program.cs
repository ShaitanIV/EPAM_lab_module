using System;

namespace EPAM_task_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var pow1 = new RootFinder();
            //var pow2 = new RootFinder(-0.008, 3, 0.1);
            Console.WriteLine(pow1.NewtonMethod(0.0081, 4, 0.1));
            //Console.Write(pow2.NewtonMethod());
        }


    }
}
