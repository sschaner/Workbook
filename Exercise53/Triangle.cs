using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise53
{
    public class Triangle : Shape
    {
        private double side1Length;
        public double Side1Length
        {
            get { return side1Length; }
            set { side1Length = value; }
        }
        private double side2Length;
        public double Side2Length
        {
            get { return side2Length; }
            set { side2Length = value; }
        }
        private double side3Length;
        public double Side3Length
        {
            get { return side3Length; }
            set { side3Length = value; }
        }

        public Triangle(double side1Length, double side2Length, double side3Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
        }

        /// <summary>
        /// Returns the perimeter of a triangle when given the 3 side lengths.
        /// </summary>
        /// <param name="side1Length"></param>
        /// <param name="side2Length"></param>
        /// <param name="side3Length"></param>
        /// <returns></returns>
        public double CalculatePerimeter(double side1Length, double side2Length, double side3Length)
        {
            double trianglePerimeter = side1Length + side2Length + side3Length;

            return trianglePerimeter;
        }

        /// <summary>
        /// Returns the area of a triangle when given the 3 side lengths.
        /// </summary>
        /// <param name="side1Length"></param>
        /// <param name="side2Length"></param>
        /// <param name="side3Length"></param>
        /// <returns></returns>
        public double CalculateArea(double side1Length, double side2Length, double side3Length)
        {
            double semiPerimeter = (side1Length + side2Length + side3Length) / 2;
            // Heron's Formula
            double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - side1Length) * (semiPerimeter - side2Length) * (semiPerimeter - side3Length));

            return triangleArea;
        }

        public override bool IsClosed()
        {
            return true;
        }

        public override bool HasEdges()
        {
            return true;
        }
    }
}
