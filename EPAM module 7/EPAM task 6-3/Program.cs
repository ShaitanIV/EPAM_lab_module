using System;
using System.Security.Cryptography.X509Certificates;

namespace EPAM_task_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var changer = new UrlEditor();
            
            Console.WriteLine(changer.AddOrChangeUrlParameter("www.example.com?key=value&key2=value2", "key", "NewKey"));
        }
    }
}
