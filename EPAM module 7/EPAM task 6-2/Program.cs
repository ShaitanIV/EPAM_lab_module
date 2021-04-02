using System;

namespace EPAM_task_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "www.example.com?key=value&key2=value2";
            var formater = new StringFormater();
            Console.WriteLine(formater.ToTitle("THE WIND IN THE WILLOWS", "The In"));

        }
    }
}
