using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EPAM_module_9
{
    public static class StudentDataManager
    {
        public static void ShowData(SortedList<string,StudentTest> dataList, int numberOfRows = -1, bool showName = true, bool showTest = true, bool showDate = true, bool showAssessment = true, bool isDescending = true)
        {
            var ShowList = dataList.Select(data => data.Value);

            var ShowListEnumerator = ShowList.GetEnumerator();
            var counter = 0;

            while (ShowListEnumerator.MoveNext())
            {
                if(showName)
                    Console.Write($"{ShowListEnumerator.Current.StudentName}; ");
                if(showTest)
                    Console.Write($"{ShowListEnumerator.Current.TestName}; ");
                if (showDate)
                    Console.Write($"{ShowListEnumerator.Current.TestDate}; ");
                if (showAssessment)
                    Console.Write($"{ShowListEnumerator.Current.Assessment}; ");
                if (counter == numberOfRows)
                    break;

                counter++;
                Console.WriteLine();
            }
        }
    }
}
