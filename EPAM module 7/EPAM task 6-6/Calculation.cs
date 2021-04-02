    using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_6_6
{
    public class Calculation
    {
        public string SummaryOfTwoDoubles(string firstNumber, string secondNumber)
        {
            double fNumber;
            double sNumber;
            if (!Double.TryParse(firstNumber, out fNumber))
                throw new ArgumentException("First value is in incorrect format");
            if (!Double.TryParse(secondNumber, out sNumber))
                throw new ArgumentException("Second valuse is in incorrect format");

            return (fNumber + sNumber).ToString();

        }
    }
}
