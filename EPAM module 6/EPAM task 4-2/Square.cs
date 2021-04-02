using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_4_2
{
    public class Square:GeometricShape
    {
        double Side;

        public Square(double side)
        {
            if (side <= 0)
                throw new Exception("Side must be greater then 0");
            Side = side;
        }

        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }
        public override double Perimeter
        {
            get
            {
                return 4 * Side;
            }
        }
    }
}
