using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_4_2
{
    public class Circle : GeometricShape
    {
        double Radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("Radius must be greater than 0");
            Radius = radius;
        }
        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2.0 * Math.PI * Radius;
            }
        }
    }
}
