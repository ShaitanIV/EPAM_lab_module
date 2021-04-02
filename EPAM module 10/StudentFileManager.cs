using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace EPAM_module_9
{
    static class StudentFileManager
    {
        public static void Write(List<StudentTest> tests, string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (StudentTest test in tests)
                {
                    writer.Write(test.StudentName);
                    writer.Write(test.TestName);
                    writer.Write(test.TestDate);
                    writer.Write(test.Assessment);
                }
            }
        }

        public static SortedList<string, StudentTest> Read (string path)
        {
            SortedList<string, StudentTest> result = new SortedList<string, StudentTest>();

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    string tempName = reader.ReadString();
                    string tempTest = reader.ReadString();
                    string tempDate = reader.ReadString();
                    int tempAssessment = reader.ReadInt32();

                    result.Add(tempName, new StudentTest(tempName, tempTest, tempDate, tempAssessment));
                }
            }

            return result;
        }
    }
}
