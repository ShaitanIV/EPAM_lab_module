using EPAM_task_2_2;
using NUnit.Framework;

namespace Task_2_2_test
{
    public class SortMehodsTest
    {

        static readonly double[,] arrayUnsorted = new double[,]
        {
            { 12, 23, 34 },
            { 0, -8, 4 },
            { 4, 3, 51 }
        };

        static readonly double[,] arrayMinAsc = new double[,]
        {
            { 0, -8, 4 },
            { 4, 3, 51 },
            { 12, 23, 34 }
        };

        static readonly double[,] arrayMaxAsc = new double[,]
        {
            { 0, -8, 4 },
            { 12, 23, 34 },
            { 4, 3, 51 }
        };

        static readonly double[,] arraySumDes = new double[,]
        {
            { 12, 23, 34 },
            { 4, 3, 51 },
            { 0, -8, 4 }
        };

        static readonly object[] MinCompareTestData =
        {
            new object[] { arrayUnsorted , false, 3, arrayMinAsc },
        };

        static readonly object[] MaxCompareTestData =
        {
            new object[] { arrayUnsorted , false, 3, arrayMaxAsc },
        };

        static readonly object[] SumCompareTestData =
        {
            new object[] { arrayUnsorted , true, 3, arraySumDes }
        };

        [TestCaseSource("MinCompareTestData")]
        public void TestMinSort(double[,] arrUnSort, bool isDesc, int row, double[,] expected)
        {
            ArraySorter sorter = new ArraySorter();
            SortByMin min = new SortByMin();
            sorter.SelectMethod(min);
            Assert.AreEqual(sorter.Sort(isDesc, arrUnSort, row),expected);
        }

        [TestCaseSource("MaxCompareTestData")]
        public void TestMaxSort(double[,] arrUnSort, bool isDesc, int row, double[,] expected)
        {
            ArraySorter sorter = new ArraySorter();
            SortByMax max = new SortByMax();
            sorter.SelectMethod(max);
            Assert.AreEqual(sorter.Sort(isDesc, arrUnSort, row), expected);
        }

        [TestCaseSource("SumCompareTestData")]
        public void TestSumSort(double[,] arrUnSort, bool isDesc, int row, double[,] expected)
        {
            ArraySorter sorter = new ArraySorter();
            SortBySum sum = new SortBySum();
            sorter.SelectMethod(sum);
            Assert.AreEqual(sorter.Sort(isDesc, arrUnSort, row), expected);
        }
    }
}