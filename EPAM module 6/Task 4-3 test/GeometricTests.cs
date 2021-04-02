using EPAM_task_4_2;
using NUnit.Framework;

namespace Task_4_3_test
{
    public class Tests
    {
        /// <summary>
        /// Methods for testing calculation of square perimeter
        /// </summary>
        /// <param name="side">Side of sqaure</param>
        /// <param name="expected">Expected perimeter</param>
        /// <param name="tolerance">Toletance</param>

        [TestCase(1,4,0.0001)]
        [TestCase(4, 16, 0.0001)]
        [TestCase(2.5,10,0.0001)]

        public void SquareTestPer(double side, double expected, double tolerance)
        {
            var square = new Square(side);
            double result = square.Perimeter;
            Assert.AreEqual(expected, result, tolerance);
        }

        /// <summary>
        /// Methods for testing calculation of square area
        /// </summary>
        /// <param name="side">Side of sqaure</param>
        /// <param name="expected">Expected area</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 1, 0.0001)]
        [TestCase(4, 16, 0.0001)]
        [TestCase(1.4, 1.96, 0.0001)]

        public void SquareTestArea(double side, double expected, double tolerance)
        {
            var square = new Square(side);
            double result = square.Area;
            Assert.AreEqual(expected, result, tolerance);
        }

        /// <summary>
        /// Methods for testing calculation of rectangle perimeter
        /// </summary>
        /// <param name="height">Height of rectangle</param>
        /// <param name="width">Width of rectangle</param>
        /// <param name="expected">Expected perimeter</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 2, 6, 0.0001)]
        [TestCase(4, 5, 18, 0.0001)]
        [TestCase(1.4, 1.96, 6.72, 0.0001)]

        public void RectangleTestPer(double height, double width, double expected, double tolerance)
        {
            var rect = new Rectangle(height,width);
            double result = rect.Perimeter;
            Assert.AreEqual(expected, result, tolerance);
        }

        /// <summary>
        /// Methods for testing calculation of rectangle area
        /// </summary>
        /// <param name="height">Height of rectangle</param>
        /// <param name="width">Width of rectangle</param>
        /// <param name="expected">Expected area</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 2, 2, 0.0001)]
        [TestCase(4, 16, 64, 0.0001)]
        [TestCase(1.4, 1.96, 2.744, 0.0001)]

        public void RectangleTestArea(double height, double width, double expected, double tolerance)
        {
            var rect = new Rectangle(height, width);
            double result = rect.Area;
            Assert.AreEqual(expected, result, tolerance);
        }

        /// <summary>
        /// Methods for testing calculation of triangle perimeter
        /// </summary>
        /// <param name="first">First side of triangle</param>
        /// <param name="second">Second side of triangle</param>
        /// <param name="third">Third side of triangle</param>
        /// <param name="expected">Expected perimeter</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 1, 1, 0.4330127018922193, 0.0001)]
        [TestCase(2, 5, 6.5, 3.7453095666446585, 0.0001)]
        [TestCase(3, 3, 2, 2.8284271247461903, 0.0001)]

        public void TriangleTestArea(double first, double second, double third, double expected, double tolerance)
        {
        
            var triangle = new Triangle(first,second, third);
            double result = triangle.Area;
            Assert.AreEqual(expected, result, tolerance);
        }

        /// <summary>
        /// Methods for testing calculation of triangle area
        /// </summary>
        /// <param name="first">First side of triangle</param>
        /// <param name="second">Second side of triangle</param>
        /// <param name="third">Third side of triangle</param>
        /// <param name="expected">Expected area</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 1, 1, 3, 0.0001)]
        [TestCase(2, 5, 6.5, 13.5, 0.0001)]
        [TestCase(3, 3, 2, 8, 0.0001)]

        public void TriangleTestPer(double first, double second, double third, double expected, double tolerance)
        {
            var triangle = new Triangle(first, second, third);
            double result = triangle.Perimeter;
            Assert.AreEqual(expected, result, tolerance);
        }
       
        /// <summary>
        /// Method for testing calculation of circle perimeter
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <param name="expected">Expected perimeter</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 3.141592653589793, 0.01)]
        [TestCase(0.4, 0.5026548245743669, 0.01)]
        [TestCase(84, 22167.07776372958, 0.01)]
        public void CircleTestArea(double radius, double expected, double tolerance)
        {
            var circle = new Circle(radius);
            double result = circle.Area;
            Assert.AreEqual(expected, result, tolerance);
        }

        /// <summary>
        /// Method for testing calculation of circle area
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <param name="expected">Expected area</param>
        /// <param name="tolerance">Tolerance</param>

        [TestCase(1, 6.283, 0.01)]
        [TestCase(0.4, 2.513, 0.01)]
        [TestCase(84, 527.788, 0.01)]
        public void CircleTestPer(double radius, double expected, double tolerance)
        {
            var circle = new Circle(radius);
            double result = circle.Perimeter;
            Assert.AreEqual(expected, result, tolerance);
        }

        
    }
}