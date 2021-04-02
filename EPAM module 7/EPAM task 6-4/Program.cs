using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EPAM_task_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var formater = new StringFormater();
            var test = new List<double> { 1.1, 1.1, 2.2, 3.3 };
            var list = formater.UniqueInOrder<double>(test);
            foreach(var c in list)
                Console.Write(c);
        }
    }
}
