using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise54
{
    public class Rectangle : Shape
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

        public Rectangle(double side1Length, double side2Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
        }

        public double CalculatePerimeter(double side1Length, double side2Length)
        {
            double rectanglePerimeter = 2 * side1Length + 2 * side2Length;

            return rectanglePerimeter;
        }

        public double CalculateArea(double side1Length, double side2Length)
        {
            double rectangleArea = side1Length * side2Length;

            return rectangleArea;
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
