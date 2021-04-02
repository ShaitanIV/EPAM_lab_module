using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_4_2
{
    public class Rectangle : GeometricShape
    {
        double Width;
        double Height;

        public Rectangle(double height, double widht)
        {
            if (height <= 0 || widht <= 0)
                throw new Exception("Sides must be greater than 0");
            Width = widht;
            Height = height;
        }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Height + Width);
            }
        }
    }
}
