using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_task_4_3
{
    public class Polynomial
    {
        double[] Coefficients;
        int Degree;

        public Polynomial(int degree)
        {
            if (degree <= 0)
                throw new Exception("Degree must be greater than 0");
            Degree = degree;
            Coefficients = new double[degree + 1];
        }

        public double this[int i]
        {
            get { return Coefficients[i]; }
            set { Coefficients[i] = value; }
        }

        public void AddCoefficients(params Monomial[] coef)
        {
            foreach (Monomial mono in coef)
            {
                Coefficients[mono.Degree] = mono.Coefficent;
            }
        }

        public List<Monomial> ConvertToMonomialList()
        {
            List<Monomial> result = new List<Monomial>();
            for (int i = 0; i <= Degree; i++)
            {
                if (Coefficients[i] != 0)
                    result.Add(new Monomial(i, Coefficients[i]));
            }

            return result;
        }

        public double Calculate(double x)
        {
            var result = 0.0;

            for (int i = 0; i <= Degree; i++)
            {
                result += Coefficients[i] * Math.Pow(x, i);
            }

            return result;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (Coefficients[Degree] < 0)
                result.Append("-");
            result.Append($"{Coefficients[Degree]}x^{Degree}");

            for (int i = Degree - 1; i > 0; i--)
            {
                if (Coefficients[i] > 0)
                    result.Append($"+{Coefficients[i]}x^{i}");
                else if (Coefficients[i] < 0)
                    result.Append($"-{Math.Abs(Coefficients[i])}x^{i}");
            }

            if (Coefficients[0] != 0)
                if (Coefficients[0] < 0)
                    result.Append($"{Coefficients[0]}");
                else
                    result.Append($"+{Coefficients[0]}");

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Polynomial p = (Polynomial)obj;
                return (this.ToString() == p.ToString());
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
