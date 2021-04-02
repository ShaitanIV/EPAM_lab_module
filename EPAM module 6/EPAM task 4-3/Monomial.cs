using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_4_3
{
    public struct Monomial
    {
        public int Degree;
        public double Coefficent;

        public Monomial(int degree, double coefficent)
        {
            Degree = degree;
            Coefficent = coefficent;
        }
    }
}
