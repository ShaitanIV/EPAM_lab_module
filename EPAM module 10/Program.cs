using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EPAM_module_9
{
    class Program
    {       
        static void Main(string[] args)
        {
            List<StudentTest> testList = new List<StudentTest>();
            SortedList<string, StudentTest> TestBST = new SortedList<string, StudentTest>();
            string path = @"D:\states.dat";
            for (int i = 0; i < 10; i++)
            {
                testList.Add(new StudentTest("abc" + i, "test", "11.11.11", i * 10));
            }

            StudentFileManager.Write(testList, path);

            TestBST = StudentFileManager.Read(path);

            StudentDataManager.ShowData(TestBST);
        }
    }
}
