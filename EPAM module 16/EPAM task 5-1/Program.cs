using System;

namespace EPAM_task_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arrSq1 = new double[,]
{
            {1,2,3 },
            {6,3,7 },
            {6.2,1,2 }
};

            double[,] arrSq2 = new double[,]
            {
            {4,1,3 },
            {6,23,7 },
            {6,1,2.4 }
            };

            double[,] arrres1 = new double[,]
{
            {5,3,6 },
            {12,26,14 },
            {12.2,2,4.4 }
};

            SquareMatrix<double> m1 = new SquareMatrix<double>(arrSq1);
            SquareMatrix<double> m2 = new SquareMatrix<double>(arrSq2);
            SquareMatrix<double> m3 = new SquareMatrix<double>(arrres1);
            m1.MatrixAdd(m2);
            Console.WriteLine(m1.Equals(m3));
        }
    }
}
