using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_4_2
{
    public class Triangle : GeometricShape
    {
        double FirstSide;
        double SecondSide;
        double ThirdSide;

        public Triangle(double first, double second, double third)
        {
            FirstSide = first;
            SecondSide = second;
            ThirdSide = third;
        }

        public override double Perimeter
        {
            get
            {
                return FirstSide + SecondSide + ThirdSide;
            }
        }
        public override double Area
        {
            get
            {
                return Math.Sqrt(Perimeter/2 * (Perimeter/2 - FirstSide) * (Perimeter/2 - SecondSide) * (Perimeter/2 - ThirdSide));
            }
        }
    }
}
