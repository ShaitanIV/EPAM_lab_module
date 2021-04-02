using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_4_2
{
    public struct Angle
    {
        public double Degree {  get; set; }

        public Angle(double degree)
        {
            if (degree <= 0)
                throw new Exception("Angle must be greater than 0");
            Degree = degree % 360;
        }
    }
}
