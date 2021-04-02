using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_9
{
    public class StudentTest
    {
        public string StudentName;
        public string TestName;
        public string TestDate;
        public int Assessment;

        public StudentTest(string student, string test, string date, int assessment)
        {
            StudentName = student;
            TestName = test;
            TestDate = date;
            Assessment = assessment;
        }
    }
}
