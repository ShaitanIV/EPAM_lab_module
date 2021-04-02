using System;

namespace EPAM_task_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var formater = new StringReverser();
            Console.WriteLine(formater.Reverse("The greatest victory is that which requires no battle"));
        }
    }
}
