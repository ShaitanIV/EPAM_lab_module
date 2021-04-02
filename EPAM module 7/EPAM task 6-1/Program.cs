using System;

namespace EPAM_task_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer("asc", "+1234", 1234);
            string s = cust.CustomerToString();
            Console.WriteLine(s);
        }
    }
}
