using NUnit.Framework;
using EPAM_task_5_1;

namespace Task_5_1_test
{
    public class Tests
    {
        static readonly double[,] arrSq1 = new double[,]
        {
            {1,2,3 },
            {6,3,7 },
            {6.2,1,2 }
        };

        static readonly double[,] arrSq2 = new double[,]
        {
            {4,1,3 },
            {6,23,7 },
            {6,1,2.4 }
        };

        static readonly double[,] arrSym1 = new double[,]
        {
            {1,6,6 },
            {6,3,7 },
            {6,7,2 }
        };

        static readonly double[,] arrSym2 = new double[,]
{
            {1,3,6 },
            {3,3,3 },
            {6,3,0 }
};

        static readonly double[,] arrres1 = new double[,]
        {
            {5,3,6 },
            {12,26,14 },
            {12.2,2,4.4 }
        };

        static readonly double[,] arrres2 = new double[,]
        {
            {2,9,12 },
            {9,6,10 },
            {12,10,2 }
        };

        static readonly object[] MatrixAddSqXSqTestData = new object[]
        {
            new object[] {arrSq1,arrSq2,arrres1 },
            new object[] {arrSym1,arrSym2,arrres2 }
        };

        [TestCaseSource("MatrixAddSqXSqTestData")]
        public void TestMatrixAddSqXSq (double[,] array1, double[,] array2, double[,] arrayres)
        {
            SquareMatrix<double> matr1 = new SquareMatrix<double>(array1);
            SquareMatrix<double> matr2 = new SquareMatrix<double>(array2);
            SquareMatrix<double> matrres = new SquareMatrix<double>(arrayres);
            matr1.MatrixAdd(matr2);
            Assert.That(matr1.Equals(matrres));
        }
    }
}