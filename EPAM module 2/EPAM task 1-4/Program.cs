using System;

namespace EPAM_task_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1="coolText";
            string str2 = "coolertext";
            var con = new StringConnector();
            var result = con.Unite("aaAAbxdB", "bsadwW");
            Console.WriteLine(result);
        }

    }
}
